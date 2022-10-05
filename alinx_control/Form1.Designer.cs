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
            this.comboBoxNamePort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxDac = new System.Windows.Forms.GroupBox();
            this.labelRefFreq = new System.Windows.Forms.Label();
            this.textBoxRefFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRefOut = new System.Windows.Forms.Label();
            this.comboBoxRefOut = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxChannel1 = new System.Windows.Forms.GroupBox();
            this.labelFreq1 = new System.Windows.Forms.Label();
            this.textBoxFreq1 = new System.Windows.Forms.TextBox();
            this.labelAmp1 = new System.Windows.Forms.Label();
            this.textBoxAmp1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxChannel1 = new System.Windows.Forms.CheckBox();
            this.groupBoxChannel2 = new System.Windows.Forms.GroupBox();
            this.checkBoxChannel2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmp2 = new System.Windows.Forms.TextBox();
            this.labelAmp2 = new System.Windows.Forms.Label();
            this.textBoxFreq2 = new System.Windows.Forms.TextBox();
            this.labelFreq2 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxConect.SuspendLayout();
            this.groupBoxDac.SuspendLayout();
            this.groupBoxChannel1.SuspendLayout();
            this.groupBoxChannel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConect
            // 
            this.groupBoxConect.Controls.Add(this.buttonConnect);
            this.groupBoxConect.Controls.Add(this.labelPort);
            this.groupBoxConect.Controls.Add(this.comboBoxNamePort);
            this.groupBoxConect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConect.Name = "groupBoxConect";
            this.groupBoxConect.Size = new System.Drawing.Size(398, 52);
            this.groupBoxConect.TabIndex = 0;
            this.groupBoxConect.TabStop = false;
            this.groupBoxConect.Text = "Подключение";
            // 
            // comboBoxNamePort
            // 
            this.comboBoxNamePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamePort.FormattingEnabled = true;
            this.comboBoxNamePort.Location = new System.Drawing.Point(118, 19);
            this.comboBoxNamePort.Name = "comboBoxNamePort";
            this.comboBoxNamePort.Size = new System.Drawing.Size(78, 21);
            this.comboBoxNamePort.TabIndex = 0;
            this.comboBoxNamePort.DropDown += new System.EventHandler(this.comboBoxNamePort_DropDown);
            this.comboBoxNamePort.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamePort_SelectedIndexChanged);
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
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(260, 18);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(128, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Подключить";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
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
            this.groupBoxDac.Size = new System.Drawing.Size(398, 176);
            this.groupBoxDac.TabIndex = 1;
            this.groupBoxDac.TabStop = false;
            this.groupBoxDac.Text = "AD9173";
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
            // textBoxRefFreq
            // 
            this.textBoxRefFreq.Location = new System.Drawing.Point(113, 20);
            this.textBoxRefFreq.Name = "textBoxRefFreq";
            this.textBoxRefFreq.Size = new System.Drawing.Size(76, 20);
            this.textBoxRefFreq.TabIndex = 1;
            this.textBoxRefFreq.Text = "3000";
            this.textBoxRefFreq.TextChanged += new System.EventHandler(this.textBoxRefFreq_TextChanged);
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
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(260, 16);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(128, 53);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxChannel1
            // 
            this.groupBoxChannel1.Controls.Add(this.checkBoxChannel1);
            this.groupBoxChannel1.Controls.Add(this.label2);
            this.groupBoxChannel1.Controls.Add(this.textBoxAmp1);
            this.groupBoxChannel1.Controls.Add(this.labelAmp1);
            this.groupBoxChannel1.Controls.Add(this.textBoxFreq1);
            this.groupBoxChannel1.Controls.Add(this.labelFreq1);
            this.groupBoxChannel1.Location = new System.Drawing.Point(10, 75);
            this.groupBoxChannel1.Name = "groupBoxChannel1";
            this.groupBoxChannel1.Size = new System.Drawing.Size(186, 92);
            this.groupBoxChannel1.TabIndex = 6;
            this.groupBoxChannel1.TabStop = false;
            this.groupBoxChannel1.Text = "Канал 1";
            // 
            // labelFreq1
            // 
            this.labelFreq1.Location = new System.Drawing.Point(6, 16);
            this.labelFreq1.Name = "labelFreq1";
            this.labelFreq1.Size = new System.Drawing.Size(52, 20);
            this.labelFreq1.TabIndex = 0;
            this.labelFreq1.Text = "Частота:";
            this.labelFreq1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFreq1
            // 
            this.textBoxFreq1.Location = new System.Drawing.Point(77, 17);
            this.textBoxFreq1.Name = "textBoxFreq1";
            this.textBoxFreq1.Size = new System.Drawing.Size(71, 20);
            this.textBoxFreq1.TabIndex = 1;
            this.textBoxFreq1.Text = "1235.4";
            this.textBoxFreq1.TextChanged += new System.EventHandler(this.textBoxFreq1_TextChanged);
            // 
            // labelAmp1
            // 
            this.labelAmp1.Location = new System.Drawing.Point(6, 42);
            this.labelAmp1.Name = "labelAmp1";
            this.labelAmp1.Size = new System.Drawing.Size(65, 20);
            this.labelAmp1.TabIndex = 2;
            this.labelAmp1.Text = "Амплитуда:";
            this.labelAmp1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAmp1
            // 
            this.textBoxAmp1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAmp1.Location = new System.Drawing.Point(77, 43);
            this.textBoxAmp1.MaxLength = 4;
            this.textBoxAmp1.Name = "textBoxAmp1";
            this.textBoxAmp1.Size = new System.Drawing.Size(71, 20);
            this.textBoxAmp1.TabIndex = 3;
            this.textBoxAmp1.Text = "50FF";
            this.textBoxAmp1.TextChanged += new System.EventHandler(this.textBoxAmp1_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(151, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "МГц";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxChannel1
            // 
            this.checkBoxChannel1.AutoSize = true;
            this.checkBoxChannel1.Checked = true;
            this.checkBoxChannel1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChannel1.Location = new System.Drawing.Point(9, 68);
            this.checkBoxChannel1.Name = "checkBoxChannel1";
            this.checkBoxChannel1.Size = new System.Drawing.Size(75, 17);
            this.checkBoxChannel1.TabIndex = 5;
            this.checkBoxChannel1.Text = "Включить";
            this.checkBoxChannel1.UseVisualStyleBackColor = true;
            this.checkBoxChannel1.CheckedChanged += new System.EventHandler(this.checkBoxChannel1_CheckedChanged);
            // 
            // groupBoxChannel2
            // 
            this.groupBoxChannel2.Controls.Add(this.checkBoxChannel2);
            this.groupBoxChannel2.Controls.Add(this.label3);
            this.groupBoxChannel2.Controls.Add(this.textBoxAmp2);
            this.groupBoxChannel2.Controls.Add(this.labelAmp2);
            this.groupBoxChannel2.Controls.Add(this.textBoxFreq2);
            this.groupBoxChannel2.Controls.Add(this.labelFreq2);
            this.groupBoxChannel2.Location = new System.Drawing.Point(202, 75);
            this.groupBoxChannel2.Name = "groupBoxChannel2";
            this.groupBoxChannel2.Size = new System.Drawing.Size(186, 92);
            this.groupBoxChannel2.TabIndex = 7;
            this.groupBoxChannel2.TabStop = false;
            this.groupBoxChannel2.Text = "Канал 2";
            // 
            // checkBoxChannel2
            // 
            this.checkBoxChannel2.AutoSize = true;
            this.checkBoxChannel2.Checked = true;
            this.checkBoxChannel2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChannel2.Location = new System.Drawing.Point(9, 68);
            this.checkBoxChannel2.Name = "checkBoxChannel2";
            this.checkBoxChannel2.Size = new System.Drawing.Size(75, 17);
            this.checkBoxChannel2.TabIndex = 5;
            this.checkBoxChannel2.Text = "Включить";
            this.checkBoxChannel2.UseVisualStyleBackColor = true;
            this.checkBoxChannel2.CheckedChanged += new System.EventHandler(this.checkBoxChannel2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(151, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "МГц";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAmp2
            // 
            this.textBoxAmp2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAmp2.Location = new System.Drawing.Point(77, 43);
            this.textBoxAmp2.MaxLength = 4;
            this.textBoxAmp2.Name = "textBoxAmp2";
            this.textBoxAmp2.Size = new System.Drawing.Size(71, 20);
            this.textBoxAmp2.TabIndex = 3;
            this.textBoxAmp2.Text = "50FF";
            this.textBoxAmp2.TextChanged += new System.EventHandler(this.textBoxAmp2_TextChanged);
            // 
            // labelAmp2
            // 
            this.labelAmp2.Location = new System.Drawing.Point(6, 42);
            this.labelAmp2.Name = "labelAmp2";
            this.labelAmp2.Size = new System.Drawing.Size(65, 20);
            this.labelAmp2.TabIndex = 2;
            this.labelAmp2.Text = "Амплитуда:";
            this.labelAmp2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFreq2
            // 
            this.textBoxFreq2.Location = new System.Drawing.Point(77, 17);
            this.textBoxFreq2.Name = "textBoxFreq2";
            this.textBoxFreq2.Size = new System.Drawing.Size(71, 20);
            this.textBoxFreq2.TabIndex = 1;
            this.textBoxFreq2.Text = "100";
            this.textBoxFreq2.TextChanged += new System.EventHandler(this.textBoxFreq2_TextChanged);
            // 
            // labelFreq2
            // 
            this.labelFreq2.Location = new System.Drawing.Point(6, 16);
            this.labelFreq2.Name = "labelFreq2";
            this.labelFreq2.Size = new System.Drawing.Size(52, 20);
            this.labelFreq2.TabIndex = 0;
            this.labelFreq2.Text = "Частота:";
            this.labelFreq2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 255);
            this.Controls.Add(this.groupBoxDac);
            this.Controls.Add(this.groupBoxConect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DAC9173 Control";
            this.groupBoxConect.ResumeLayout(false);
            this.groupBoxDac.ResumeLayout(false);
            this.groupBoxDac.PerformLayout();
            this.groupBoxChannel1.ResumeLayout(false);
            this.groupBoxChannel1.PerformLayout();
            this.groupBoxChannel2.ResumeLayout(false);
            this.groupBoxChannel2.PerformLayout();
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
    }
}

