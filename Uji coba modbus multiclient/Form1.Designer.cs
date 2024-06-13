namespace Uji_coba_modbus_multiclient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonconnect = new System.Windows.Forms.Button();
            this.labelstat = new System.Windows.Forms.Label();
            this.lblstatans = new System.Windows.Forms.Label();
            this.buttonFILTERING = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTurbidity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDeltaP = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBACKWASH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRINSE = new System.Windows.Forms.Button();
            this.panelstatus = new System.Windows.Forms.Panel();
            this.panelmanual = new System.Windows.Forms.Panel();
            this.buttonPOMPA = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxOff2 = new System.Windows.Forms.TextBox();
            this.textBoxOff1 = new System.Windows.Forms.TextBox();
            this.textBoxOff3 = new System.Windows.Forms.TextBox();
            this.textBoxOff4 = new System.Windows.Forms.TextBox();
            this.textBoxOff5 = new System.Windows.Forms.TextBox();
            this.textBoxOff6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelJam = new System.Windows.Forms.Label();
            this.timerclock = new System.Windows.Forms.Timer(this.components);
            this.textBoxTekanan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSensorT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxAnalog = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Maintimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelstatus.SuspendLayout();
            this.panelmanual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonconnect
            // 
            this.buttonconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconnect.Location = new System.Drawing.Point(197, 10);
            this.buttonconnect.Name = "buttonconnect";
            this.buttonconnect.Size = new System.Drawing.Size(121, 45);
            this.buttonconnect.TabIndex = 5;
            this.buttonconnect.Text = "Connect";
            this.buttonconnect.UseVisualStyleBackColor = true;
            this.buttonconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelstat
            // 
            this.labelstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelstat.Location = new System.Drawing.Point(12, 23);
            this.labelstat.Name = "labelstat";
            this.labelstat.Size = new System.Drawing.Size(105, 21);
            this.labelstat.TabIndex = 6;
            this.labelstat.Text = "Status: ";
            // 
            // lblstatans
            // 
            this.lblstatans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatans.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblstatans.Location = new System.Drawing.Point(74, 23);
            this.lblstatans.Name = "lblstatans";
            this.lblstatans.Size = new System.Drawing.Size(151, 21);
            this.lblstatans.TabIndex = 7;
            this.lblstatans.Text = "Not Connected";
            // 
            // buttonFILTERING
            // 
            this.buttonFILTERING.Location = new System.Drawing.Point(4, 120);
            this.buttonFILTERING.Name = "buttonFILTERING";
            this.buttonFILTERING.Size = new System.Drawing.Size(134, 88);
            this.buttonFILTERING.TabIndex = 19;
            this.buttonFILTERING.Text = "FILTERING";
            this.buttonFILTERING.UseVisualStyleBackColor = true;
            this.buttonFILTERING.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 20);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MANUAL MODE";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(160, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 20);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AUTOMATIC MODE";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "NTU";
            // 
            // textBoxTurbidity
            // 
            this.textBoxTurbidity.Location = new System.Drawing.Point(145, 73);
            this.textBoxTurbidity.Name = "textBoxTurbidity";
            this.textBoxTurbidity.Size = new System.Drawing.Size(38, 22);
            this.textBoxTurbidity.TabIndex = 14;
            this.textBoxTurbidity.TextChanged += new System.EventHandler(this.textBoxTurbidity_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bar";
            // 
            // textBoxDeltaP
            // 
            this.textBoxDeltaP.Location = new System.Drawing.Point(145, 35);
            this.textBoxDeltaP.Name = "textBoxDeltaP";
            this.textBoxDeltaP.Size = new System.Drawing.Size(38, 22);
            this.textBoxDeltaP.TabIndex = 13;
            this.textBoxDeltaP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(146, 2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(151, 22);
            this.textBoxStatus.TabIndex = 12;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kejernihan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Beda Tekanan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status Tangki";
            // 
            // buttonBACKWASH
            // 
            this.buttonBACKWASH.Location = new System.Drawing.Point(4, 214);
            this.buttonBACKWASH.Name = "buttonBACKWASH";
            this.buttonBACKWASH.Size = new System.Drawing.Size(134, 88);
            this.buttonBACKWASH.TabIndex = 22;
            this.buttonBACKWASH.Text = "BACKWASH";
            this.buttonBACKWASH.UseVisualStyleBackColor = true;
            this.buttonBACKWASH.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(8, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 32);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonRINSE
            // 
            this.buttonRINSE.Location = new System.Drawing.Point(3, 308);
            this.buttonRINSE.Name = "buttonRINSE";
            this.buttonRINSE.Size = new System.Drawing.Size(134, 88);
            this.buttonRINSE.TabIndex = 24;
            this.buttonRINSE.Text = "RINSE";
            this.buttonRINSE.UseVisualStyleBackColor = true;
            this.buttonRINSE.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelstatus
            // 
            this.panelstatus.Controls.Add(this.label1);
            this.panelstatus.Controls.Add(this.label2);
            this.panelstatus.Controls.Add(this.label3);
            this.panelstatus.Controls.Add(this.textBoxStatus);
            this.panelstatus.Controls.Add(this.textBoxDeltaP);
            this.panelstatus.Controls.Add(this.label5);
            this.panelstatus.Controls.Add(this.textBoxTurbidity);
            this.panelstatus.Controls.Add(this.label4);
            this.panelstatus.Location = new System.Drawing.Point(371, 5);
            this.panelstatus.Name = "panelstatus";
            this.panelstatus.Size = new System.Drawing.Size(343, 105);
            this.panelstatus.TabIndex = 25;
            this.panelstatus.Visible = false;
            // 
            // panelmanual
            // 
            this.panelmanual.Controls.Add(this.buttonPOMPA);
            this.panelmanual.Controls.Add(this.buttonOFF);
            this.panelmanual.Controls.Add(this.buttonFILTERING);
            this.panelmanual.Controls.Add(this.buttonRINSE);
            this.panelmanual.Controls.Add(this.buttonBACKWASH);
            this.panelmanual.Location = new System.Drawing.Point(8, 91);
            this.panelmanual.Name = "panelmanual";
            this.panelmanual.Size = new System.Drawing.Size(154, 470);
            this.panelmanual.TabIndex = 26;
            this.panelmanual.Visible = false;
            // 
            // buttonPOMPA
            // 
            this.buttonPOMPA.Location = new System.Drawing.Point(3, 26);
            this.buttonPOMPA.Name = "buttonPOMPA";
            this.buttonPOMPA.Size = new System.Drawing.Size(134, 88);
            this.buttonPOMPA.TabIndex = 26;
            this.buttonPOMPA.Text = "POMPA";
            this.buttonPOMPA.UseVisualStyleBackColor = true;
            this.buttonPOMPA.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.Location = new System.Drawing.Point(3, 406);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(134, 61);
            this.buttonOFF.TabIndex = 25;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = true;
            this.buttonOFF.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBoxOff2
            // 
            this.textBoxOff2.BackColor = System.Drawing.Color.Red;
            this.textBoxOff2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOff2.Location = new System.Drawing.Point(394, 348);
            this.textBoxOff2.Name = "textBoxOff2";
            this.textBoxOff2.Size = new System.Drawing.Size(38, 22);
            this.textBoxOff2.TabIndex = 29;
            this.textBoxOff2.Text = "OFF";
            this.textBoxOff2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOff1
            // 
            this.textBoxOff1.BackColor = System.Drawing.Color.Red;
            this.textBoxOff1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOff1.Location = new System.Drawing.Point(388, 162);
            this.textBoxOff1.Name = "textBoxOff1";
            this.textBoxOff1.Size = new System.Drawing.Size(38, 22);
            this.textBoxOff1.TabIndex = 31;
            this.textBoxOff1.Text = "OFF";
            this.textBoxOff1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOff1.TextChanged += new System.EventHandler(this.textBoxOff1_TextChanged);
            // 
            // textBoxOff3
            // 
            this.textBoxOff3.BackColor = System.Drawing.Color.Red;
            this.textBoxOff3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOff3.Location = new System.Drawing.Point(519, 162);
            this.textBoxOff3.Name = "textBoxOff3";
            this.textBoxOff3.Size = new System.Drawing.Size(38, 22);
            this.textBoxOff3.TabIndex = 32;
            this.textBoxOff3.Text = "OFF";
            this.textBoxOff3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOff4
            // 
            this.textBoxOff4.BackColor = System.Drawing.Color.Red;
            this.textBoxOff4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOff4.Location = new System.Drawing.Point(519, 348);
            this.textBoxOff4.Name = "textBoxOff4";
            this.textBoxOff4.Size = new System.Drawing.Size(38, 22);
            this.textBoxOff4.TabIndex = 33;
            this.textBoxOff4.Text = "OFF";
            this.textBoxOff4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOff5
            // 
            this.textBoxOff5.BackColor = System.Drawing.Color.Red;
            this.textBoxOff5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOff5.Location = new System.Drawing.Point(791, 287);
            this.textBoxOff5.Name = "textBoxOff5";
            this.textBoxOff5.Size = new System.Drawing.Size(38, 22);
            this.textBoxOff5.TabIndex = 34;
            this.textBoxOff5.Text = "OFF";
            this.textBoxOff5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOff6
            // 
            this.textBoxOff6.BackColor = System.Drawing.Color.Red;
            this.textBoxOff6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOff6.Location = new System.Drawing.Point(715, 348);
            this.textBoxOff6.Name = "textBoxOff6";
            this.textBoxOff6.Size = new System.Drawing.Size(38, 22);
            this.textBoxOff6.TabIndex = 35;
            this.textBoxOff6.Text = "OFF";
            this.textBoxOff6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valve 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Valve 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Valve 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Valve 4";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(788, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Valve 5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(701, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Valve 6";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(611, 519);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 22);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelJam
            // 
            this.labelJam.AutoSize = true;
            this.labelJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJam.Location = new System.Drawing.Point(745, 477);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(35, 38);
            this.labelJam.TabIndex = 43;
            this.labelJam.Text = "0";
            // 
            // timerclock
            // 
            this.timerclock.Enabled = true;
            this.timerclock.Interval = 1000;
            this.timerclock.Tick += new System.EventHandler(this.timerclock_Tick);
            // 
            // textBoxTekanan
            // 
            this.textBoxTekanan.Location = new System.Drawing.Point(698, 67);
            this.textBoxTekanan.Name = "textBoxTekanan";
            this.textBoxTekanan.Size = new System.Drawing.Size(38, 22);
            this.textBoxTekanan.TabIndex = 17;
            this.textBoxTekanan.TextChanged += new System.EventHandler(this.textBoxTekanan_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(694, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Sensor Tekanan";
            // 
            // textBoxSensorT
            // 
            this.textBoxSensorT.Location = new System.Drawing.Point(698, 34);
            this.textBoxSensorT.Name = "textBoxSensorT";
            this.textBoxSensorT.Size = new System.Drawing.Size(38, 22);
            this.textBoxSensorT.TabIndex = 44;
            this.textBoxSensorT.TextChanged += new System.EventHandler(this.textBoxSensorT_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(742, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "KBar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(742, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 16);
            this.label14.TabIndex = 46;
            this.label14.Text = "Bar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(876, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "V";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(876, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 16);
            this.label16.TabIndex = 50;
            this.label16.Text = "ADC";
            // 
            // textBoxAnalog
            // 
            this.textBoxAnalog.Location = new System.Drawing.Point(832, 33);
            this.textBoxAnalog.Name = "textBoxAnalog";
            this.textBoxAnalog.Size = new System.Drawing.Size(38, 22);
            this.textBoxAnalog.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(818, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 16);
            this.label17.TabIndex = 47;
            this.label17.Text = "Sensor Turbidity";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(832, 66);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(38, 22);
            this.textBoxV.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(183, 298);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 16);
            this.label18.TabIndex = 52;
            this.label18.Text = "Inled";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(668, 413);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 16);
            this.label19.TabIndex = 53;
            this.label19.Text = "Pembuangan";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label20.Location = new System.Drawing.Point(831, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 16);
            this.label20.TabIndex = 54;
            this.label20.Text = "Reservoir";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 580);
            this.Controls.Add(this.buttonconnect);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxAnalog);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxSensorT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxTekanan);
            this.Controls.Add(this.labelJam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOff6);
            this.Controls.Add(this.textBoxOff5);
            this.Controls.Add(this.textBoxOff4);
            this.Controls.Add(this.textBoxOff3);
            this.Controls.Add(this.textBoxOff1);
            this.Controls.Add(this.textBoxOff2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelmanual);
            this.Controls.Add(this.panelstatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblstatans);
            this.Controls.Add(this.labelstat);
            this.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.Name = "Form1";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelstatus.ResumeLayout(false);
            this.panelstatus.PerformLayout();
            this.panelmanual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonconnect;
        private System.Windows.Forms.Label labelstat;
        private System.Windows.Forms.Label lblstatans;
        private System.Windows.Forms.Button buttonFILTERING;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTurbidity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDeltaP;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBACKWASH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRINSE;
        private System.Windows.Forms.Panel panelstatus;
        private System.Windows.Forms.Panel panelmanual;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBoxOff2;
        private System.Windows.Forms.TextBox textBoxOff1;
        private System.Windows.Forms.TextBox textBoxOff3;
        private System.Windows.Forms.TextBox textBoxOff4;
        private System.Windows.Forms.TextBox textBoxOff5;
        private System.Windows.Forms.TextBox textBoxOff6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonPOMPA;
        private System.Windows.Forms.Label labelJam;
        private System.Windows.Forms.Timer timerclock;
        private System.Windows.Forms.TextBox textBoxTekanan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSensorT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxAnalog;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer Maintimer;
    }
}

