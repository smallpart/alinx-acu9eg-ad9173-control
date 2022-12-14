using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace alinx_control
{
    public partial class Form1 : Form
    {
        bool deviceIsConnect = false;
        const Double dataRate = 336; // MHz

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Вывод версии ПО
            int major = Assembly.GetExecutingAssembly().GetName().Version.Major;
            int minor = Assembly.GetExecutingAssembly().GetName().Version.Minor;
            int build = Assembly.GetExecutingAssembly().GetName().Version.Build;
            int revision = Assembly.GetExecutingAssembly().GetName().Version.Revision;
            this.Text += " (version " + major.ToString() + "." + minor.ToString() + "." + build.ToString() + ")";

            try
            {
                // Вывод только существующих COM-портов
                comboBoxNamePort.Items.Clear();
                RegistryKey regKey = Registry.LocalMachine.OpenSubKey("HARDWARE").OpenSubKey("DEVICEMAP").OpenSubKey("SERIALCOMM");
                string[] names = new string[regKey.ValueCount];
                names = regKey.GetValueNames();
                for (int i = 0; i < regKey.ValueCount; i++)
                {
                    comboBoxNamePort.Items.Add(regKey.GetValue(names[i]));
                }
                comboBoxNamePort.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

            // Set default values
            textBoxRefFreq.Text          = "6048";
            textBoxFreq1.Text            = "1235.4";
            textBoxFreq2.Text            = "100";
            textBoxAmp1.Text             = "50ff";
            textBoxAmp2.Text             = "50ff";
            comboBoxRefOut.SelectedIndex = 2;
            textBoxModeTime.Text         = "1";
            textBoxModDeviation.Text     = "10";
        }

        private void comboBoxNamePort_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = comboBoxNamePort.Text;
        }

        private void comboBoxNamePort_DropDown(object sender, EventArgs e)
        {
            // Обновление списка портов при разворачивании списка
            try
            {
                // Вывод только существующих COM-портов
                string currentPort = comboBoxNamePort.Text;
                comboBoxNamePort.Items.Clear();
                RegistryKey regKey = Registry.LocalMachine.OpenSubKey("HARDWARE").OpenSubKey("DEVICEMAP").OpenSubKey("SERIALCOMM");
                string[] names = new string[regKey.ValueCount];
                names = regKey.GetValueNames();
                for (int i = 0; i < regKey.ValueCount; i++)
                {
                    comboBoxNamePort.Items.Add(regKey.GetValue(names[i]));
                }
                comboBoxNamePort.Text = currentPort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Подключить")
            {
                try
                {
                    serialPort.Open();
                    buttonConnect.Text = "Отключить";
                    comboBoxNamePort.Enabled = false;
                    deviceIsConnect = true;

                    // Send parameters to device
                    KeyEventArgs ke = new KeyEventArgs(Keys.Enter);
                    textBoxRefFreq_KeyUp(sender, ke);
                    textBoxAmp1_KeyUp(sender, ke);
                    textBoxAmp2_KeyUp(sender, ke);
                    comboBoxRefOut_SelectedIndexChanged(sender, e);
                    checkBoxChannel1_CheckedChanged(sender, e);
                    checkBoxChannel2_CheckedChanged(sender, e);
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort.Close();
                    buttonConnect.Text = "Подключить";
                    comboBoxNamePort.Enabled = true;
                    deviceIsConnect = false;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Send parameters to device
                KeyEventArgs ke = new KeyEventArgs(Keys.Enter);
                textBoxRefFreq_KeyUp(sender, ke);
                textBoxAmp1_KeyUp(sender, ke);
                textBoxAmp2_KeyUp(sender, ke);
                comboBoxRefOut_SelectedIndexChanged(sender, e);
                checkBoxChannel1_CheckedChanged(sender, e);
                checkBoxChannel2_CheckedChanged(sender, e);

                // Send command "Reset"
                byte[] data = new byte[6];
                foreach (byte b in data)
                {
                    data[b] = 0x00;
                }
                data[0] = 0x02;

                if (deviceIsConnect)
                {
                    serialPort.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxChannel1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[6];
                foreach (byte b in data)
                {
                    data[b] = 0x00;
                }
                data[0] = 0x1a;
                data[2] = 0x00;
                if (checkBoxChannel1.Checked)
                {
                    data[4] = 0x01;
                }
                else
                {
                    data[4] = 0x00;
                }

                if (deviceIsConnect)
                {
                    serialPort.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxChannel2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[6];
                foreach (byte b in data)
                {
                    data[b] = 0x00;
                }
                data[0] = 0x1a;
                data[2] = 0x01;
                if (checkBoxChannel2.Checked)
                {
                    data[4] = 0x01;
                }
                else
                {
                    data[4] = 0x00;
                }

                if (deviceIsConnect)
                {
                    serialPort.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxRefOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[6];
                foreach (byte b in data)
                {
                    data[b] = 0x00;
                }
                data[0] = 0x17;
                data[2] = Convert.ToByte(comboBoxRefOut.SelectedIndex);

                if (deviceIsConnect)
                {
                    serialPort.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxFreq2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Double freq = Convert.ToDouble(textBoxFreq2.Text);
                    Double refFreq = Convert.ToDouble(textBoxRefFreq.Text);

                    UInt64 code = Convert.ToUInt64((freq / refFreq) * Math.Pow(2, 48));

                    byte[] data = new byte[12];
                    foreach (byte b in data)
                    {
                        data[b] = 0x00;
                    }
                    data[0] = 0x24;
                    data[2] = 0x01;
                    data[4] = Convert.ToByte((code >> 0) & 0xff);
                    data[5] = Convert.ToByte((code >> 8) & 0xff);
                    data[6] = Convert.ToByte((code >> 16) & 0xff);
                    data[7] = Convert.ToByte((code >> 24) & 0xff);
                    data[8] = Convert.ToByte((code >> 32) & 0xff);
                    data[9] = Convert.ToByte((code >> 40) & 0xff);

                    textBoxFreq2.Select(0, textBoxFreq2.Text.Length);

                    if (deviceIsConnect)
                    {
                        serialPort.Write(data, 0, data.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxFreq1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Double freq = Convert.ToDouble(textBoxFreq1.Text);
                    Double refFreq = Convert.ToDouble(textBoxRefFreq.Text);

                    UInt64 code = Convert.ToUInt64(Math.Round(Math.Pow(2, 48) * (freq / refFreq)));

                    byte[] data = new byte[12];
                    foreach (byte b in data)
                    {
                        data[b] = 0x00;
                    }
                    data[0] = 0x24;
                    data[2] = 0x00;
                    data[4] = Convert.ToByte((code >> 0) & 0xff);
                    data[5] = Convert.ToByte((code >> 8) & 0xff);
                    data[6] = Convert.ToByte((code >> 16) & 0xff);
                    data[7] = Convert.ToByte((code >> 24) & 0xff);
                    data[8] = Convert.ToByte((code >> 32) & 0xff);
                    data[9] = Convert.ToByte((code >> 40) & 0xff);

                    textBoxFreq1.Select(0, textBoxFreq1.Text.Length);

                    if (deviceIsConnect)
                    {
                        serialPort.Write(data, 0, data.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxRefFreq_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Double refFreq = Convert.ToDouble(textBoxRefFreq.Text);
                    Double freq1 = Convert.ToDouble(textBoxFreq1.Text);
                    Double freq2 = Convert.ToDouble(textBoxFreq2.Text);

                    UInt64 code1 = Convert.ToUInt64(Math.Round(Math.Pow(2, 48) * (freq1 / refFreq)));
                    UInt64 code2 = Convert.ToUInt64(Math.Round(Math.Pow(2, 48) * (freq2 / refFreq)));

                    byte[] data1 = new byte[12];
                    foreach (byte b in data1)
                    {
                        data1[b] = 0x00;
                    }
                    data1[0] = 0x24;
                    data1[2] = 0x00;
                    data1[4] = Convert.ToByte((code1 >> 0) & 0xff);
                    data1[5] = Convert.ToByte((code1 >> 8) & 0xff);
                    data1[6] = Convert.ToByte((code1 >> 16) & 0xff);
                    data1[7] = Convert.ToByte((code1 >> 24) & 0xff);
                    data1[8] = Convert.ToByte((code1 >> 32) & 0xff);
                    data1[9] = Convert.ToByte((code1 >> 40) & 0xff);

                    byte[] data2 = new byte[12];
                    foreach (byte b in data2)
                    {
                        data2[b] = 0x00;
                    }
                    data2[0] = 0x24;
                    data2[2] = 0x01;
                    data2[4] = Convert.ToByte((code2 >> 0) & 0xff);
                    data2[5] = Convert.ToByte((code2 >> 8) & 0xff);
                    data2[6] = Convert.ToByte((code2 >> 16) & 0xff);
                    data2[7] = Convert.ToByte((code2 >> 24) & 0xff);
                    data2[8] = Convert.ToByte((code2 >> 32) & 0xff);
                    data2[9] = Convert.ToByte((code2 >> 40) & 0xff);

                    textBoxRefFreq.Select(0, textBoxRefFreq.Text.Length);

                    if (deviceIsConnect)
                    {
                        serialPort.Write(data1, 0, data1.Length);
                        serialPort.Write(data2, 0, data2.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxAmp1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    UInt16 amp = Convert.ToUInt16(textBoxAmp1.Text, 16);

                    byte[] data = new byte[6];
                    foreach (byte b in data)
                    {
                        data[b] = 0x00;
                    }
                    data[0] = 0x25;
                    data[2] = 0x00;
                    data[4] = Convert.ToByte((amp >> 0) & 0xff);
                    data[5] = Convert.ToByte((amp >> 8) & 0xff);

                    textBoxAmp1.Select(0, textBoxAmp1.Text.Length);

                    if (deviceIsConnect)
                    {
                        serialPort.Write(data, 0, data.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxAmp2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    UInt16 amp = Convert.ToUInt16(textBoxAmp2.Text, 16);

                    byte[] data = new byte[6];
                    foreach (byte b in data)
                    {
                        data[b] = 0x00;
                    }
                    data[0] = 0x25;
                    data[2] = 0x01;
                    data[4] = Convert.ToByte((amp >> 0) & 0xff);
                    data[5] = Convert.ToByte((amp >> 8) & 0xff);

                    textBoxAmp2.Select(0, textBoxAmp2.Text.Length);

                    if (deviceIsConnect)
                    {
                        serialPort.Write(data, 0, data.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxRefFreq_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = textBoxRefFreq;

            if ((tb.Text.CompareTo(".") != -1) || (tb.Text.CompareTo(",") != -1))
            {
                int position = tb.SelectionStart;

                tb.Text = tb.Text.Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                tb.Text = tb.Text.Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                tb.SelectionStart = position;
                tb.SelectionLength = 0;
            }
        }

        private void textBoxFreq1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = textBoxFreq1;

            if ( (tb.Text.CompareTo(".") != -1) || (tb.Text.CompareTo(",") != -1) )
            {
                int position = tb.SelectionStart;

                tb.Text = tb.Text.Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                tb.Text = tb.Text.Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                tb.SelectionStart = position;
                tb.SelectionLength = 0;
            }
        }

        private void textBoxFreq2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = textBoxFreq2;

            if ((tb.Text.CompareTo(".") != -1) || (tb.Text.CompareTo(",") != -1))
            {
                int position = tb.SelectionStart;

                tb.Text = tb.Text.Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                tb.Text = tb.Text.Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                tb.SelectionStart = position;
                tb.SelectionLength = 0;
            }
        }

        private void textBoxModeTime_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = textBoxModeTime;

            if ((tb.Text.CompareTo(".") != -1) || (tb.Text.CompareTo(",") != -1))
            {
                int position = tb.SelectionStart;

                tb.Text = tb.Text.Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                tb.Text = tb.Text.Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                tb.SelectionStart = position;
                tb.SelectionLength = 0;
            }
        }

        private void textBoxModRate_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = textBoxModDeviation;

            if ((tb.Text.CompareTo(".") != -1) || (tb.Text.CompareTo(",") != -1))
            {
                int position = tb.SelectionStart;

                tb.Text = tb.Text.Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                tb.Text = tb.Text.Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                tb.SelectionStart = position;
                tb.SelectionLength = 0;
            }
        }

        private void textBoxModeTime_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Double modDevTime = Convert.ToDouble(textBoxModeTime.Text);

                    UInt32 code = Convert.ToUInt32(Math.Round(modDevTime * dataRate));

                    byte[] data = new byte[8];
                    foreach (byte b in data)
                    {
                        data[b] = 0x00;
                    }
                    data[0] = 0x2c;
                    data[2] = 0x00;
                    data[4] = Convert.ToByte((code >> 0) & 0xff);
                    data[5] = Convert.ToByte((code >> 8) & 0xff);
                    data[6] = Convert.ToByte((code >> 16) & 0xff);
                    data[7] = Convert.ToByte((code >> 24) & 0xff);

                    textBoxModeTime.Select(0, textBoxModeTime.Text.Length);

                    if (deviceIsConnect)
                    {
                        serialPort.Write(data, 0, data.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxModRate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Double modDev     = Convert.ToDouble(textBoxModDeviation.Text);
                    Double modDevTime = Convert.ToDouble(textBoxModeTime.Text);
                    Double modRate    = modDev / modDevTime / dataRate;

                    UInt64 code = Convert.ToUInt64(Math.Round(Math.Pow(2, 48) * (modRate / dataRate)));

                    byte[] data = new byte[12];
                    foreach (byte b in data)
                    {
                        data[b] = 0x00;
                    }
                    data[0] = 0x24;
                    data[2] = 0x02;
                    data[4] = Convert.ToByte((code >> 0) & 0xff);
                    data[5] = Convert.ToByte((code >> 8) & 0xff);
                    data[6] = Convert.ToByte((code >> 16) & 0xff);
                    data[7] = Convert.ToByte((code >> 24) & 0xff);
                    data[8] = Convert.ToByte((code >> 32) & 0xff);
                    data[9] = Convert.ToByte((code >> 40) & 0xff);

                    textBoxModDeviation.Select(0, textBoxModDeviation.Text.Length);

                    if (deviceIsConnect)
                    {
                        serialPort.Write(data, 0, data.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkBoxModCh1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[6];
                foreach (byte b in data)
                {
                    data[b] = 0x00;
                }
                data[0] = 0x29;
                data[2] = 0x00;
                if (checkBoxChannel1.Checked)
                {
                    data[4] = 0x01;
                }
                else
                {
                    data[4] = 0x00;
                }

                if (deviceIsConnect)
                {
                    serialPort.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBoxModCh2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[6];
                foreach (byte b in data)
                {
                    data[b] = 0x00;
                }
                data[0] = 0x29;
                data[2] = 0x01;
                if (checkBoxChannel1.Checked)
                {
                    data[4] = 0x01;
                }
                else
                {
                    data[4] = 0x00;
                }

                if (deviceIsConnect)
                {
                    serialPort.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
