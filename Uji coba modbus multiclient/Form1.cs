using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EasyModbus;
using System.Threading.Tasks;
using FormsTimer = System.Windows.Forms.Timer;
using TimersTimer = System.Timers.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace Uji_coba_modbus_multiclient
{
    public partial class Form1 : Form
    {
        private ModbusClient modbusClient;
        private ModbusClient modbusClient2;
        private int rowCount = 0;
        private const int MaxRows = 50;
        private const int MaxFiles = 5;
        private SensorDataProcessor _processor;
        private FuzzyHelper _fuzhelper;

        public Form1()
        {
            InitializeComponent();
            InitializeModbusClients();
            InitializeMainTimer();
            _processor = new SensorDataProcessor(5);
            _fuzhelper = new FuzzyHelper();
        }

        private void InitializeModbusClients()
        {
            try
            {
                modbusClient = new ModbusClient("COM8");
                modbusClient.UnitIdentifier = 1;        //pressure sensor
               // modbusClient.UnitIdentifier = 2;        //arduino-turbidity
                modbusClient.UnitIdentifier = 3;        //relay
                modbusClient.Baudrate = 9600;
                modbusClient.Parity = System.IO.Ports.Parity.None;
                modbusClient.StopBits = System.IO.Ports.StopBits.One;

                modbusClient2 = new ModbusClient("COM7");                       //ARDUINOO
                //modbusClient2.UnitIdentifier = 1;        //pressure sensor
                modbusClient2.UnitIdentifier = 2;        //arduino-turbidity
                //modbusClient2.UnitIdentifier = 3;        //relay
                modbusClient2.Baudrate = 9600;
                modbusClient2.Parity = System.IO.Ports.Parity.None;
                modbusClient2.StopBits = System.IO.Ports.StopBits.One;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeMainTimer()
        {
            Maintimer = new System.Windows.Forms.Timer();
            Maintimer.Interval = 1000; // Interval dalam milidetik (1 detik)
            Maintimer.Tick += Maintimer_Tick;
        }

        private void Write(int channel, bool cond)                       //pengaturan relay
        {
            try
            {
                modbusClient.UnitIdentifier = 3;
                modbusClient.WriteSingleCoil(channel - 1, cond);
                if (cond)
                {
                    Console.WriteLine($"Channel {channel} Nyala");
                }
                else
                {
                    Console.WriteLine($"Channel {channel} Mati");
                }
            }
            catch
            {
                Console.WriteLine($"Channel {channel} Mati");
            }
        }
        private void Maintimer_Tick(object sender, EventArgs e)          //turbidity dan keduapressure
        {
            try
            {
                // Baca Holding Register dari address 1, 3 register panjangnya
                modbusClient2.UnitIdentifier = 2;
                //int[] registers = modbusClient.ReadHoldingRegisters(1, 3);
                int[] registersArduino = modbusClient2.ReadInputRegisters(0, 3);
                int ADCValue = registersArduino[0];
                textBoxAnalog.Text = ADCValue.ToString();
                double VoltageValue = registersArduino[1] * 1.00;
                textBoxV.Text = VoltageValue.ToString();
                int NTUValue = registersArduino[2];
                textBoxTurbidity.Text = NTUValue.ToString();

                // Baca Holding Register dari address 4, 1 register panjangnya
                modbusClient.UnitIdentifier = 1;                                            //pressure
                int[] registersPressure = modbusClient.ReadHoldingRegisters(4, 1);
                int BarValue = registersPressure[0];                    //actual data dari sensor satuan bar tp sbnrny Kbar
                textBoxSensorT.Text = BarValue.ToString();
                double RealTValue = BarValue / 1000.000;             //Kbar to bar
                textBoxTekanan.Text = RealTValue.ToString();
                double BedaTekanan = 3.2-RealTValue;                 //berkurang 1 bar
                textBoxDeltaP.Text = BedaTekanan.ToString();           //beda tekanan

                double currentValueT = NTUValue;
                double averageValueT = _processor.rerata(currentValueT);

                double currentValueP = NTUValue;
                double averageValueP = _processor.rerata(currentValueP);

                double filterCondition = _fuzhelper.InferFilterCondition(pressureDiff, clarity);
                string Kondisifix = (filterCondition >= 0.5 ? "BACKWASHTIME" : "NORMAL");

                string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string data = $"{timeStamp},{averageValueT},{averageValueP}";
                SaveData(data);
                rowCount++;

                if (radioButton1.Checked)
                {
                    Maintimer.Start();
                    MessageBox.Show("Mesin dalam Manual");
                    panelmanual.Visible = true;
                }
                else
                {
                    if(Kondisifix=="BACKWASHTIME")              //nilai fuz >0.5
                    {
                        BackwashON();
                        Thread.Sleep(1000);       //  1 detik
                        PompaON();

                    }
                    else
                    {
                        FilteringON();
                        Thread.Sleep(1000);
                        PompaON();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void SaveData(string data)
        {
            string folderPath = @"C:\Users\USER\Documents\0 KULIAHH\MATKUL\Sem 8\skripsi\Programming";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Cari file yang ada di direktori
            var files = Directory.GetFiles(folderPath, "*.csv").OrderBy(f => f).ToList();

            // Jika tidak ada file, buat file baru
            string currentFilePath;
            if (files.Count == 0)
            {
                currentFilePath = Path.Combine(folderPath, "data_1.csv");
                using (StreamWriter writer = new StreamWriter(currentFilePath, true))
                {
                    writer.WriteLine("Waktu, NTU Arduino, Bar Tekanan");
                }
            }
            else                    //klo ada file disitu
            {
                currentFilePath = files.Last();
                if (File.ReadAllLines(currentFilePath).Length >= MaxRows + 1) // +1 untuk header
                {
                    CalculateAverages(currentFilePath);
                    int newFileNumber = files.Count + 1;
                    currentFilePath = Path.Combine(folderPath, $"data_{newFileNumber}.csv");

                    if (files.Count >= MaxFiles)
                    {
                        File.Delete(files.First());
                    }

                    using (StreamWriter writer = new StreamWriter(currentFilePath, true))
                    {
                        writer.WriteLine("registersArduino, registersPressure");
                    }
                }
            }

            // Append data ke file
            using (StreamWriter writer = new StreamWriter(currentFilePath, true))
            {
                writer.WriteLine(data);
            }
        }

        double pressureDiff = 0;
        double clarity = 0;

        public void CalculateAverages(string filePath)
        {
            var lines = File.ReadAllLines(filePath).Skip(1); // Skip header
            var registersArduinoValues = lines.Select(line => int.Parse(line.Split(',')[1])).ToList();
            var registersPressureValues = lines.Select(line => int.Parse(line.Split(',')[2])).ToList();

            double averageSensor1 = registersArduinoValues.Average();
            double averageSensor2 = registersPressureValues.Average();

            pressureDiff = averageSensor1;
            clarity = averageSensor2;

            //MessageBox.Show($"File: {Path.GetFileName(filePath)}\n" + $"Rata-rata Sensor Turbidity: {averageSensor1}\n" + $"Rata-rata Sensor Pressure: {averageSensor2}", "Rata-rata Sensor");
        }

        private void button1_Click(object sender, EventArgs e)                             //button connect
        {
            isOn = !isOn; // Toggle the state
            if (isOn)
            {
                if (buttonconnect.Text == "Connect")
                {
                    modbusClient.Connect();
                    modbusClient2.Connect();
                    //Maintimer.Start();

                    if (rowCount < MaxRows)
                    {
                        Maintimer.Start();
                    }
                    //currentFilePath = GetNewFilePath();

                    panelstatus.Visible = true;
                    lblstatans.Text = "Connected";

                    buttonconnect.Text = "EXIT";
                    buttonconnect.BackColor = Color.Red;
                }
            }
            else
            {
                modbusClient.Disconnect();
                modbusClient2.Disconnect();

                buttonconnect.BackColor = Color.Yellow;
                Application.Exit();
            }
        }
        //datalogger code

        public void ResetValveStates()
        {
            Write(1, false); textBoxOff1.BackColor = Color.Red; textBoxOff1.Text = "OFF";
            Write(2, false); textBoxOff3.BackColor = Color.Red; textBoxOff3.Text = "OFF";
            Write(3, false); textBoxOff2.BackColor = Color.Red; textBoxOff2.Text = "OFF";
            Write(4, false); textBoxOff4.BackColor = Color.Red; textBoxOff4.Text = "OFF";
            Write(5, false); textBoxOff6.BackColor = Color.Red; textBoxOff6.Text = "OFF";
            Write(6, false); textBoxOff5.BackColor = Color.Red; textBoxOff5.Text = "OFF";
        }
        private void CekKondisiValve()
        {
            if (textBoxStatus.Text == "TANGKI BERSIH")
            {
                Write(1, true); textBoxOff1.BackColor = Color.Green; textBoxOff1.Text = "ON";
                Write(4, true); textBoxOff4.BackColor = Color.Green; textBoxOff4.Text = "ON";
                Write(5, true); textBoxOff5.BackColor = Color.Green; textBoxOff5.Text = "ON";
            }
            else if (textBoxStatus.Text == "TANGKI KOTOR")
            {
                Write(2, true); textBoxOff2.BackColor = Color.Green; textBoxOff2.Text = "ON";
                Write(3, true); textBoxOff3.BackColor = Color.Green; textBoxOff3.Text = "ON";
                Write(6, true); textBoxOff6.BackColor = Color.Green; textBoxOff6.Text = "ON";
            }
            else if (textBoxStatus.Text == "SEDANG MEMBILAS")
            {
                Write(1, true); textBoxOff1.BackColor = Color.Green; textBoxOff1.Text = "ON";
                Write(4, true); textBoxOff4.BackColor = Color.Green; textBoxOff4.Text = "ON";
                Write(6, true); textBoxOff6.BackColor = Color.Green; textBoxOff6.Text = "ON";
            }
        }
        private void PompaON()
        {
            Write(7, true); buttonPOMPA.BackColor = Color.Green;
        }
        private void FilteringON()
        {
            ResetValveStates();
            textBoxStatus.Text = "TANGKI BERSIH";
            CekKondisiValve();
            Thread.Sleep(1000);       //  1 detik
            PompaON();
        }
        private void BackwashON()
        {
            ResetValveStates();
            textBoxStatus.Text = "TANGKI KOTOR";
            CekKondisiValve();
            Thread.Sleep(1000);       //  1 detik
            PompaON();
        }
        private void RinseON()
        {
            ResetValveStates();
            textBoxStatus.Text = "TANGKI MEMBILAS";
            CekKondisiValve();
            Thread.Sleep(1000);       //  1 detik
            PompaON();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string kondisi = "FILTERING";
            if (kondisi == "FILTERING")
            {
                // nyala 145, mati 236
                ResetValveStates();
                textBoxStatus.Text = "TANGKI BERSIH";
                CekKondisiValve();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string kondisi = "BACKWASH";
            if (kondisi == "BACKWASH")
            {
                // nyala 236, mati 145
                ResetValveStates();
                textBoxStatus.Text = "TANGKI KOTOR";
                CekKondisiValve();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string kondisi = "RINSE";
            if (kondisi == "RINSE")
            {
                //145 nyala , 235 mati
                ResetValveStates();
                textBoxStatus.Text = "SEDANG MEMBILAS";
                CekKondisiValve();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string kondisi = "OFF";
            if (kondisi == "OFF")
            {
                // 1234567 mati
                ResetValveStates();
                Write(7, false);
                textBoxStatus.Text = "TIDAK BERFUNGSI";
            }
        }
        private bool isOn = false;
        private void button5_Click(object sender, EventArgs e)
        {
            isOn = !isOn; // Toggle the state
            if (isOn)
            {
                string kondisi = "POMPA MENYALA";
                if (kondisi == "POMPA MENYALA")
                {
                    Write(7, true);
                    textBoxStatus.Text = "POMPA ON ";
                    buttonPOMPA.BackColor = Color.Green;
                }
            }
            else
            {
                buttonPOMPA.BackColor = Color.Red;
                Write(7, false);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Maintimer.Start();
                MessageBox.Show("Mesin dalam keadaan Otomatis");
                panelmanual.Visible = true;
                buttonFILTERING.Enabled = false; buttonBACKWASH.Enabled = false; buttonRINSE.Enabled = false; buttonPOMPA.Enabled = false;
                //buttonFILTERING.BackColor = Color.AliceBlue;
            }
        }
        private void textBoxTekanan_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOff1_TextChanged(object sender, EventArgs e)
        {
        }

        private void JamBerapa()
        {
            labelJam.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void timerclock_Tick(object sender, EventArgs e)
        {
            JamBerapa();
        }

        private void textBoxTurbidity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSensorT_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    public class SensorDataProcessor
    {
        private double[] data;
        private int dataSize;
        private int currentIndex = 0;
        private int count = 0;

        public SensorDataProcessor(int size)
        {
            dataSize = size;
            data = new double[dataSize];
        }

        public double rerata(double newValue)
        {
            if (count < dataSize)
            {
                data[currentIndex] = newValue;
                currentIndex = (currentIndex + 1) % dataSize;
                count++;
                return newValue;
            }
            else
            {
                data[currentIndex] = newValue;
                currentIndex = (currentIndex + 1) % dataSize;

                double sum = 0;
                for (int i = 0; i < dataSize; i++)
                {
                    sum += data[i];
                }
                return sum / dataSize;
            }
        }
    }
    public class FuzzyHelper
    {
        // Fungsi untuk inferensi kondisi filter berdasarkan input tekanan dan kejernihan
        public double InferFilterCondition(double pressureDiff, double clarity)
        {
            // Fuzzifikasi
            double lowPressure = LowPressure(pressureDiff);
            double highPressure = HighPressure(pressureDiff);

            double clearWater = ClearWater(clarity);
            double slightlyClearWater = SlightlyClearWater(clarity);
            double murkyWater = MurkyWater(clarity);

            // Aturan fuzzy dan inferensi
            List<(double, double)> rules = new List<(double, double)>
        {
            (Math.Min(lowPressure, clearWater), 0.6), //  Perlu Dicuci 0.7 
            (Math.Min(lowPressure, slightlyClearWater), 0.8), // Perlu Dicuci
            (Math.Min(lowPressure, murkyWater), 0.9),
            (Math.Min(highPressure, clearWater), 0.1),
            (Math.Min(highPressure, slightlyClearWater), 0.4), //G Perlu Dicuci
            (Math.Min(highPressure, murkyWater), 0.7) //Perlu Dicuci
        };

            // Agregasi
            double numerator = 0;
            double denominator = 0;

            foreach (var rule in rules)
            {
                numerator += rule.Item1 * rule.Item2;
                denominator += rule.Item1;
            }
            // Cegah pembagian dengan nol
            if (denominator == 0)
            {
                return 0; // Atau nilai default yang sesuai
            }

            return numerator / denominator;
        }

        // Fungsi keanggotaan input
        static double LowPressure(double x)
        {
            if (x <= 2.2) return 1;
            else if (x >= 2.2) return 0;
            else return (2.2 - x) / 1;
        }

        static double HighPressure(double x)
        {
            if (x <= 3.4) return 0;
            else if (x > 2.2) return 1;
            else return (x - 50) / 1.2;
        }
        // 20, 40, 20
        static double ClearWater(double x)
        {
            if (x <= 25) return 1;
            else if (x >= 100) return 0;
            else return (100 - x) / 75;
        }

        static double SlightlyClearWater(double x)
        {
            if (x <= 25 || x >= 100) return 0;
            else if (x == 50) return 1;
            else if (x > 25 && x < 50) return (x - 25) / 25;
            else return (100 - x) / 50;
        }

        static double MurkyWater(double x)
        {
            if (x <= 100) return 0;
            else if (x >= 25) return 1;
            else return (x - 100) / 75;
        }
    }
}