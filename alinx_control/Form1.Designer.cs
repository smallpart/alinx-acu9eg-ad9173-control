namespace alinx_control
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxConect = new System.Windows.Forms.GroupBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxNamePort = new System.Windows.Forms.ComboBox();
            this.groupBoxDac = new System.Windows.Forms.GroupBox();
            this.groupBoxChannel2 = new System.Windows.Forms.GroupBox();
            this.checkBoxChannel2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmp2 = new System.Windows.Forms.TextBox();
            this.labelAmp2 = new System.Windows.Forms.Label();
            this.textBoxFreq2 = new System.Windows.Forms.TextBox();
            this.labelFreq2 = new System.Windows.Forms.Label();
            this.groupBoxChannel1 = new System.Windows.Forms.GroupBox();
            this.checkBoxChannel1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmp1 = new System.Windows.Forms.TextBox();
            this.labelAmp1 = new System.Windows.Forms.Label();
            this.textBoxFreq1 = new System.Windows.Forms.TextBox();
            this.labelFreq1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxRefOut = new System.Windows.Forms.ComboBox();
            this.labelRefOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRefFreq = new System.Windows.Forms.TextBox();
            this.labelRefFreq = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.checkBoxModCh2 = new System.Windows.Forms.CheckBox();
            this.checkBoxModCh1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModDeviationCh1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxModTimeCh1 = new System.Windows.Forms.TextBox();
            this.labelModDeviationCh1 = new System.Windows.Forms.Label();
            this.labelModTimeCh1 = new System.Windows.Forms.Label();
            this.labelOffsetCh1 = new System.Windows.Forms.Label();
            this.textBoxOffsetCh1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelModDeviationCh2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOffsetCh2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxModDeviationCh2 = new System.Windows.Forms.TextBox();
            this.labelOffsetCh2 = new System.Windows.Forms.Label();
            this.textBoxModTimeCh2 = new System.Windows.Forms.TextBox();
            this.labelModTimeCh2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxConect.SuspendLayout();
            this.groupBoxDac.SuspendLayout();
            this.groupBoxChannel2.SuspendLayout();
            this.groupBoxChannel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConect
            // 
            this.groupBoxConect.Controls.Add(this.buttonConnect);
            this.groupBoxConect.Controls.Add(this.labelPort);
            this.groupBoxConect.Controls.Add(this.comboBoxNamePort);
            this.groupBoxConect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConect.Name = "groupBoxConect";
            this.groupBoxConect.Size = new System.Drawing.Size(437, 52);
            this.groupBoxConect.TabIndex = 0;
            this.groupBoxConect.TabStop = false;
            this.groupBoxConect.Text = "Подключение";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.Location = new System.Drawing.Point(317, 18);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(110, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Подключить";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelPort
            // 
            this.labelPort.Location = new System.Drawing.Point(7, 19);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(105, 21);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Порт подключения:";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxNamePort
            // 
            this.comboBoxNamePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamePort.FormattingEnabled = true;
            this.comboBoxNamePort.Location = new System.Drawing.Point(118, 19);
            this.comboBoxNamePort.Name = "comboBoxNamePort";
            this.comboBoxNamePort.Size = new System.Drawing.Size(105, 21);
            this.comboBoxNamePort.TabIndex = 0;
            this.comboBoxNamePort.DropDown += new System.EventHandler(this.comboBoxNamePort_DropDown);
            this.comboBoxNamePort.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamePort_SelectedIndexChanged);
            // 
            // groupBoxDac
            // 
            this.groupBoxDac.Controls.Add(this.groupBoxChannel2);
            this.groupBoxDac.Controls.Add(this.groupBoxChannel1);
            this.groupBoxDac.Controls.Add(this.buttonReset);
            this.groupBoxDac.Controls.Add(this.comboBoxRefOut);
            this.groupBoxDac.Controls.Add(this.labelRefOut);
            this.groupBoxDac.Controls.Add(this.label1);
            this.groupBoxDac.Controls.Add(this.textBoxRefFreq);
            this.groupBoxDac.Controls.Add(this.labelRefFreq);
            this.groupBoxDac.Location = new System.Drawing.Point(12, 70);
            this.groupBoxDac.Name = "groupBoxDac";
            this.groupBoxDac.Size = new System.Drawing.Size(437, 264);
            this.groupBoxDac.TabIndex = 1;
            this.groupBoxDac.TabStop = false;
            this.groupBoxDac.Text = "AD9173";
            // 
            // groupBoxChannel2
            // 
            this.groupBoxChannel2.Controls.Add(this.labelModDeviationCh2);
            this.groupBoxChannel2.Controls.Add(this.label8);
            this.groupBoxChannel2.Controls.Add(this.textBoxOffsetCh2);
            this.groupBoxChannel2.Controls.Add(this.label9);
            this.groupBoxChannel2.Controls.Add(this.textBoxModDeviationCh2);
            this.groupBoxChannel2.Controls.Add(this.labelOffsetCh2);
            this.groupBoxChannel2.Controls.Add(this.textBoxModTimeCh2);
            this.groupBoxChannel2.Controls.Add(this.labelModTimeCh2);
            this.groupBoxChannel2.Controls.Add(this.label12);
            this.groupBoxChannel2.Controls.Add(this.checkBoxModCh2);
            this.groupBoxChannel2.Controls.Add(this.checkBoxChannel2);
            this.groupBoxChannel2.Controls.Add(this.label3);
            this.groupBoxChannel2.Controls.Add(this.textBoxAmp2);
            this.groupBoxChannel2.Controls.Add(this.labelAmp2);
            this.groupBoxChannel2.Controls.Add(this.textBoxFreq2);
            this.groupBoxChannel2.Controls.Add(this.labelFreq2);
            this.groupBoxChannel2.Location = new System.Drawing.Point(222, 75);
            this.groupBoxChannel2.Name = "groupBoxChannel2";
            this.groupBoxChannel2.Size = new System.Drawing.Size(206, 177);
            this.groupBoxChannel2.TabIndex = 7;
            this.groupBoxChannel2.TabStop = false;
            this.groupBoxChannel2.Text = "Канал 2";
            // 
            // checkBoxChannel2
            // 
            this.checkBoxChannel2.AutoSize = true;
            this.checkBoxChannel2.Checked = true;
            this.checkBoxChannel2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChannel2.Location = new System.Drawing.Point(6, 19);
            this.checkBoxChannel2.Name = "checkBoxChannel2";
            this.checkBoxChannel2.Size = new System.Drawing.Size(58, 17);
            this.checkBoxChannel2.TabIndex = 5;
            this.checkBoxChannel2.Text = "Выход";
            this.checkBoxChannel2.UseVisualStyleBackColor = true;
            this.checkBoxChannel2.CheckedChanged += new System.EventHandler(this.checkBoxChannel2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(169, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "МГц";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAmp2
            // 
            this.textBoxAmp2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAmp2.Location = new System.Drawing.Point(95, 72);
            this.textBoxAmp2.MaxLength = 4;
            this.textBoxAmp2.Name = "textBoxAmp2";
            this.textBoxAmp2.Size = new System.Drawing.Size(71, 20);
            this.textBoxAmp2.TabIndex = 3;
            this.textBoxAmp2.Text = "0";
            this.textBoxAmp2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAmp2_KeyUp);
            // 
            // labelAmp2
            // 
            this.labelAmp2.Location = new System.Drawing.Point(6, 70);
            this.labelAmp2.Name = "labelAmp2";
            this.labelAmp2.Size = new System.Drawing.Size(65, 20);
            this.labelAmp2.TabIndex = 2;
            this.labelAmp2.Text = "Амплитуда:";
            this.labelAmp2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFreq2
            // 
            this.textBoxFreq2.Location = new System.Drawing.Point(95, 46);
            this.textBoxFreq2.Name = "textBoxFreq2";
            this.textBoxFreq2.Size = new System.Drawing.Size(71, 20);
            this.textBoxFreq2.TabIndex = 1;
            this.textBoxFreq2.Text = "0";
            this.textBoxFreq2.TextChanged += new System.EventHandler(this.textBoxFreq2_TextChanged);
            this.textBoxFreq2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFreq2_KeyUp);
            // 
            // labelFreq2
            // 
            this.labelFreq2.Location = new System.Drawing.Point(6, 44);
            this.labelFreq2.Name = "labelFreq2";
            this.labelFreq2.Size = new System.Drawing.Size(52, 20);
            this.labelFreq2.TabIndex = 0;
            this.labelFreq2.Text = "Частота:";
            this.labelFreq2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxChannel1
            // 
            this.groupBoxChannel1.Controls.Add(this.labelModDeviationCh1);
            this.groupBoxChannel1.Controls.Add(this.label5);
            this.groupBoxChannel1.Controls.Add(this.textBoxOffsetCh1);
            this.groupBoxChannel1.Controls.Add(this.label4);
            this.groupBoxChannel1.Controls.Add(this.textBoxModDeviationCh1);
            this.groupBoxChannel1.Controls.Add(this.labelOffsetCh1);
            this.groupBoxChannel1.Controls.Add(this.checkBoxChannel1);
            this.groupBoxChannel1.Controls.Add(this.textBoxModTimeCh1);
            this.groupBoxChannel1.Controls.Add(this.labelModTimeCh1);
            this.groupBoxChannel1.Controls.Add(this.checkBoxModCh1);
            this.groupBoxChannel1.Controls.Add(this.label6);
            this.groupBoxChannel1.Controls.Add(this.label2);
            this.groupBoxChannel1.Controls.Add(this.textBoxAmp1);
            this.groupBoxChannel1.Controls.Add(this.labelAmp1);
            this.groupBoxChannel1.Controls.Add(this.textBoxFreq1);
            this.groupBoxChannel1.Controls.Add(this.labelFreq1);
            this.groupBoxChannel1.Location = new System.Drawing.Point(10, 75);
            this.groupBoxChannel1.Name = "groupBoxChannel1";
            this.groupBoxChannel1.Size = new System.Drawing.Size(206, 177);
            this.groupBoxChannel1.TabIndex = 6;
            this.groupBoxChannel1.TabStop = false;
            this.groupBoxChannel1.Text = "Канал 1";
            // 
            // checkBoxChannel1
            // 
            this.checkBoxChannel1.AutoSize = true;
            this.checkBoxChannel1.Checked = true;
            this.checkBoxChannel1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChannel1.Location = new System.Drawing.Point(6, 19);
            this.checkBoxChannel1.Name = "checkBoxChannel1";
            this.checkBoxChannel1.Size = new System.Drawing.Size(58, 17);
            this.checkBoxChannel1.TabIndex = 5;
            this.checkBoxChannel1.Text = "Выход";
            this.checkBoxChannel1.UseVisualStyleBackColor = true;
            this.checkBoxChannel1.CheckedChanged += new System.EventHandler(this.checkBoxChannel1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(169, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "МГц";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAmp1
            // 
            this.textBoxAmp1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAmp1.Location = new System.Drawing.Point(95, 72);
            this.textBoxAmp1.MaxLength = 4;
            this.textBoxAmp1.Name = "textBoxAmp1";
            this.textBoxAmp1.Size = new System.Drawing.Size(71, 20);
            this.textBoxAmp1.TabIndex = 3;
            this.textBoxAmp1.Text = "0";
            this.textBoxAmp1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAmp1_KeyUp);
            // 
            // labelAmp1
            // 
            this.labelAmp1.Location = new System.Drawing.Point(6, 71);
            this.labelAmp1.Name = "labelAmp1";
            this.labelAmp1.Size = new System.Drawing.Size(65, 20);
            this.labelAmp1.TabIndex = 2;
            this.labelAmp1.Text = "Амплитуда:";
            this.labelAmp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFreq1
            // 
            this.textBoxFreq1.Location = new System.Drawing.Point(95, 46);
            this.textBoxFreq1.Name = "textBoxFreq1";
            this.textBoxFreq1.Size = new System.Drawing.Size(71, 20);
            this.textBoxFreq1.TabIndex = 1;
            this.textBoxFreq1.Text = "0";
            this.textBoxFreq1.TextChanged += new System.EventHandler(this.textBoxFreq1_TextChanged);
            this.textBoxFreq1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxFreq1_KeyUp);
            // 
            // labelFreq1
            // 
            this.labelFreq1.Location = new System.Drawing.Point(6, 45);
            this.labelFreq1.Name = "labelFreq1";
            this.labelFreq1.Size = new System.Drawing.Size(52, 20);
            this.labelFreq1.TabIndex = 0;
            this.labelFreq1.Text = "Частота:";
            this.labelFreq1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(317, 19);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(114, 53);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxRefOut
            // 
            this.comboBoxRefOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRefOut.FormattingEnabled = true;
            this.comboBoxRefOut.Items.AddRange(new object[] {
            "Отключен",
            "/ 1",
            "/ 2",
            "/ 3",
            "/ 4"});
            this.comboBoxRefOut.Location = new System.Drawing.Point(113, 48);
            this.comboBoxRefOut.Name = "comboBoxRefOut";
            this.comboBoxRefOut.Size = new System.Drawing.Size(110, 21);
            this.comboBoxRefOut.TabIndex = 4;
            this.comboBoxRefOut.SelectedIndexChanged += new System.EventHandler(this.comboBoxRefOut_SelectedIndexChanged);
            // 
            // labelRefOut
            // 
            this.labelRefOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRefOut.Location = new System.Drawing.Point(10, 48);
            this.labelRefOut.Name = "labelRefOut";
            this.labelRefOut.Size = new System.Drawing.Size(47, 21);
            this.labelRefOut.TabIndex = 3;
            this.labelRefOut.Text = "Ref Out:";
            this.labelRefOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(195, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "МГц";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRefFreq
            // 
            this.textBoxRefFreq.Location = new System.Drawing.Point(113, 20);
            this.textBoxRefFreq.Name = "textBoxRefFreq";
            this.textBoxRefFreq.Size = new System.Drawing.Size(76, 20);
            this.textBoxRefFreq.TabIndex = 1;
            this.textBoxRefFreq.Text = "1000";
            this.textBoxRefFreq.TextChanged += new System.EventHandler(this.textBoxRefFreq_TextChanged);
            this.textBoxRefFreq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRefFreq_KeyUp);
            // 
            // labelRefFreq
            // 
            this.labelRefFreq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRefFreq.Location = new System.Drawing.Point(10, 20);
            this.labelRefFreq.Name = "labelRefFreq";
            this.labelRefFreq.Size = new System.Drawing.Size(96, 20);
            this.labelRefFreq.TabIndex = 0;
            this.labelRefFreq.Text = "Опорная частота:";
            this.labelRefFreq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // checkBoxModCh2
            // 
            this.checkBoxModCh2.AutoSize = true;
            this.checkBoxModCh2.Location = new System.Drawing.Point(118, 19);
            this.checkBoxModCh2.Name = "checkBoxModCh2";
            this.checkBoxModCh2.Size = new System.Drawing.Size(82, 17);
            this.checkBoxModCh2.TabIndex = 7;
            this.checkBoxModCh2.Text = "Модуляция";
            this.checkBoxModCh2.UseVisualStyleBackColor = true;
            this.checkBoxModCh2.CheckedChanged += new System.EventHandler(this.checkBoxModCh2_CheckedChanged);
            // 
            // checkBoxModCh1
            // 
            this.checkBoxModCh1.AutoSize = true;
            this.checkBoxModCh1.Location = new System.Drawing.Point(118, 19);
            this.checkBoxModCh1.Name = "checkBoxModCh1";
            this.checkBoxModCh1.Size = new System.Drawing.Size(82, 17);
            this.checkBoxModCh1.TabIndex = 6;
            this.checkBoxModCh1.Text = "Модуляция";
            this.checkBoxModCh1.UseVisualStyleBackColor = true;
            this.checkBoxModCh1.CheckedChanged += new System.EventHandler(this.checkBoxModCh1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "МГц";
            // 
            // textBoxModDeviationCh1
            // 
            this.textBoxModDeviationCh1.Location = new System.Drawing.Point(95, 150);
            this.textBoxModDeviationCh1.Name = "textBoxModDeviationCh1";
            this.textBoxModDeviationCh1.Size = new System.Drawing.Size(71, 20);
            this.textBoxModDeviationCh1.TabIndex = 4;
            this.textBoxModDeviationCh1.TextChanged += new System.EventHandler(this.textBoxModRate_TextChanged);
            this.textBoxModDeviationCh1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxModRate_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "мкс";
            // 
            // textBoxModTimeCh1
            // 
            this.textBoxModTimeCh1.Location = new System.Drawing.Point(95, 124);
            this.textBoxModTimeCh1.Name = "textBoxModTimeCh1";
            this.textBoxModTimeCh1.Size = new System.Drawing.Size(71, 20);
            this.textBoxModTimeCh1.TabIndex = 2;
            this.textBoxModTimeCh1.TextChanged += new System.EventHandler(this.textBoxModeTime_TextChanged);
            this.textBoxModTimeCh1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxModeTime_KeyUp);
            // 
            // labelModDeviationCh1
            // 
            this.labelModDeviationCh1.AutoSize = true;
            this.labelModDeviationCh1.Location = new System.Drawing.Point(6, 153);
            this.labelModDeviationCh1.Name = "labelModDeviationCh1";
            this.labelModDeviationCh1.Size = new System.Drawing.Size(61, 13);
            this.labelModDeviationCh1.TabIndex = 1;
            this.labelModDeviationCh1.Text = "Девиация:";
            // 
            // labelModTimeCh1
            // 
            this.labelModTimeCh1.AutoSize = true;
            this.labelModTimeCh1.Location = new System.Drawing.Point(6, 127);
            this.labelModTimeCh1.Name = "labelModTimeCh1";
            this.labelModTimeCh1.Size = new System.Drawing.Size(83, 13);
            this.labelModTimeCh1.TabIndex = 0;
            this.labelModTimeCh1.Text = "Длительность:";
            // 
            // labelOffsetCh1
            // 
            this.labelOffsetCh1.AutoSize = true;
            this.labelOffsetCh1.Location = new System.Drawing.Point(6, 101);
            this.labelOffsetCh1.Name = "labelOffsetCh1";
            this.labelOffsetCh1.Size = new System.Drawing.Size(64, 13);
            this.labelOffsetCh1.TabIndex = 7;
            this.labelOffsetCh1.Text = "Смещение:";
            // 
            // textBoxOffsetCh1
            // 
            this.textBoxOffsetCh1.Location = new System.Drawing.Point(95, 98);
            this.textBoxOffsetCh1.Name = "textBoxOffsetCh1";
            this.textBoxOffsetCh1.Size = new System.Drawing.Size(71, 20);
            this.textBoxOffsetCh1.TabIndex = 8;
            this.textBoxOffsetCh1.TextChanged += new System.EventHandler(this.textBoxOffsetCh1_TextChanged);
            this.textBoxOffsetCh1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxOffsetCh1_KeyUp);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(169, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "МГц";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModDeviationCh2
            // 
            this.labelModDeviationCh2.AutoSize = true;
            this.labelModDeviationCh2.Location = new System.Drawing.Point(6, 153);
            this.labelModDeviationCh2.Name = "labelModDeviationCh2";
            this.labelModDeviationCh2.Size = new System.Drawing.Size(61, 13);
            this.labelModDeviationCh2.TabIndex = 10;
            this.labelModDeviationCh2.Text = "Девиация:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "МГц";
            // 
            // textBoxOffsetCh2
            // 
            this.textBoxOffsetCh2.Location = new System.Drawing.Point(95, 98);
            this.textBoxOffsetCh2.Name = "textBoxOffsetCh2";
            this.textBoxOffsetCh2.Size = new System.Drawing.Size(71, 20);
            this.textBoxOffsetCh2.TabIndex = 17;
            this.textBoxOffsetCh2.TextChanged += new System.EventHandler(this.textBoxOffsetCh2_TextChanged);
            this.textBoxOffsetCh2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxOffsetCh2_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "мкс";
            // 
            // textBoxModDeviationCh2
            // 
            this.textBoxModDeviationCh2.Location = new System.Drawing.Point(95, 150);
            this.textBoxModDeviationCh2.Name = "textBoxModDeviationCh2";
            this.textBoxModDeviationCh2.Size = new System.Drawing.Size(71, 20);
            this.textBoxModDeviationCh2.TabIndex = 13;
            this.textBoxModDeviationCh2.TextChanged += new System.EventHandler(this.textBoxModDeviationCh2_TextChanged);
            this.textBoxModDeviationCh2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxModDeviationCh2_KeyUp);
            // 
            // labelOffsetCh2
            // 
            this.labelOffsetCh2.AutoSize = true;
            this.labelOffsetCh2.Location = new System.Drawing.Point(6, 101);
            this.labelOffsetCh2.Name = "labelOffsetCh2";
            this.labelOffsetCh2.Size = new System.Drawing.Size(64, 13);
            this.labelOffsetCh2.TabIndex = 16;
            this.labelOffsetCh2.Text = "Смещение:";
            // 
            // textBoxModTimeCh2
            // 
            this.textBoxModTimeCh2.Location = new System.Drawing.Point(95, 124);
            this.textBoxModTimeCh2.Name = "textBoxModTimeCh2";
            this.textBoxModTimeCh2.Size = new System.Drawing.Size(71, 20);
            this.textBoxModTimeCh2.TabIndex = 11;
            this.textBoxModTimeCh2.TextChanged += new System.EventHandler(this.textBoxModTimeCh2_TextChanged);
            this.textBoxModTimeCh2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxModTimeCh2_KeyUp);
            // 
            // labelModTimeCh2
            // 
            this.labelModTimeCh2.AutoSize = true;
            this.labelModTimeCh2.Location = new System.Drawing.Point(6, 127);
            this.labelModTimeCh2.Name = "labelModTimeCh2";
            this.labelModTimeCh2.Size = new System.Drawing.Size(83, 13);
            this.labelModTimeCh2.TabIndex = 9;
            this.labelModTimeCh2.Text = "Длительность:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(169, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "МГц";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 342);
            this.Controls.Add(this.groupBoxDac);
            this.Controls.Add(this.groupBoxConect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DAC9173 Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxConect.ResumeLayout(false);
            this.groupBoxDac.ResumeLayout(false);
            this.groupBoxDac.PerformLayout();
            this.groupBoxChannel2.ResumeLayout(false);
            this.groupBoxChannel2.PerformLayout();
            this.groupBoxChannel1.ResumeLayout(false);
            this.groupBoxChannel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxNamePort;
        private System.Windows.Forms.GroupBox groupBoxDac;
        private System.Windows.Forms.GroupBox groupBoxChannel1;
        private System.Windows.Forms.CheckBox checkBoxChannel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmp1;
        private System.Windows.Forms.Label labelAmp1;
        private System.Windows.Forms.TextBox textBoxFreq1;
        private System.Windows.Forms.Label labelFreq1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBoxRefOut;
        private System.Windows.Forms.Label labelRefOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRefFreq;
        private System.Windows.Forms.Label labelRefFreq;
        private System.Windows.Forms.GroupBox groupBoxChannel2;
        private System.Windows.Forms.CheckBox checkBoxChannel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAmp2;
        private System.Windows.Forms.Label labelAmp2;
        private System.Windows.Forms.TextBox textBoxFreq2;
        private System.Windows.Forms.Label labelFreq2;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxModDeviationCh1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxModTimeCh1;
        private System.Windows.Forms.Label labelModDeviationCh1;
        private System.Windows.Forms.Label labelModTimeCh1;
        private System.Windows.Forms.CheckBox checkBoxModCh2;
        private System.Windows.Forms.CheckBox checkBoxModCh1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOffsetCh1;
        private System.Windows.Forms.Label labelOffsetCh1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelModDeviationCh2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOffsetCh2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxModDeviationCh2;
        private System.Windows.Forms.Label labelOffsetCh2;
        private System.Windows.Forms.TextBox textBoxModTimeCh2;
        private System.Windows.Forms.Label labelModTimeCh2;
        private System.Windows.Forms.Label label12;
    }
}

