using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace alinx_control
{
    public partial class Form1 : Form
    {
        bool deviceIsConnect = false;

        public Form1()
        {
            InitializeComponent();

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

            // Отключение Ref Out
            comboBoxRefOut.SelectedIndex = 3;
        }

        private void textBoxFreq1_TextChanged(object sender, EventArgs e)
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

                if (deviceIsConnect)
                {
                    serialPort.Write(data, 0, data.Length);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                } catch (Exception ex)
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

        private void textBoxFreq2_TextChanged(object sender, EventArgs e)
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

                if (deviceIsConnect)
                {
                    serialPort.Write(data, 0, data.Length);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxAmp1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAmp1.Text == String.Empty)
            {
                return;
            }

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

        private void textBoxAmp2_TextChanged(object sender, EventArgs e)
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void textBoxRefFreq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
