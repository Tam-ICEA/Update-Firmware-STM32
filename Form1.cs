using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using EasyModbus;

namespace Update_Firmware_STM32
{
    public partial class Form1 : Form
    {
        ModbusClient ModClient;
        string[] arr_str;
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnOpenHexFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "hex files (*.hex)|*.hex";
            ofd.FilterIndex = 1;
            ofd.ShowDialog();
            Console.WriteLine(ofd.FileName);
            if (ofd.FileName != "")
            {
                BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));
                tBoxFilename.Text = ofd.FileName;
                int str_index = 0;
                int arr_str_length = 0;
                for (int i = 0; i < (int)br.BaseStream.Length - 1; i++)
                {
                    br.BaseStream.Position = i;
                    string c = br.ReadChar().ToString();
                    if (c == "\n")
                    {
                        arr_str_length++;
                    }
                }
                arr_str_length = arr_str_length + 1;
                //Console.WriteLine($"arr_str_length: {arr_str_length}");
                arr_str = new string[arr_str_length];
                for (int i = 0; i < (int)br.BaseStream.Length - 1; i++)
                {
                    br.BaseStream.Position = i;
                    string c = br.ReadChar().ToString();
                    if (c == "\n")
                    {
                        str_index++;
                    }
                    if ((c != ":") & (c != "\r") & (c != "\n"))
                    {
                        arr_str[str_index] += c;
                    }
                }
                for (int j = 0; j < arr_str.Length; j++)
                {
                    Console.WriteLine(arr_str[j]);
                }
                //Console.WriteLine(str_index);
                br.Close();
            }
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ModClient = new ModbusClient(cBoxComPort.Text);
            ModClient.Baudrate = int.Parse(cboBaudrate.Text);
            if (cboParity.Text == "None")
            {
                ModClient.Parity = System.IO.Ports.Parity.None;
            }
            else if (cboParity.Text == "Even")
            {
                ModClient.Parity = System.IO.Ports.Parity.Even;
            }
            else if (cboParity.Text == "Odd")
            {
                ModClient.Parity = System.IO.Ports.Parity.Odd;
            }
            ModClient.UnitIdentifier = 1; //Slave address
            try
            {
                ModClient.Connect();
                lblStatus.Text = "Connected";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnUpdateFirmware.Enabled = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error! " + ex.ToString();
            }

        }

        private void btnWriteFirmware_Click(object sender, EventArgs e)
        {
            //if (lblStatus.Text == "Connected")
            //{
            //    try
            //    {
            //        int startingAddress = 0;
            //        int[] data = { 0x0001, 0x0203, 0x0405, 0x0607, 0x0809, 0x0A0B, 0x0C0D, 0x0E0F };
            //        ModClient.WriteMultipleRegisters(startingAddress, data); //Function code 16 {01}{10}{00}{00}{00}{08}{10}{00}{01}{02}{03}{04}{05}{06}{07}{08}{09}{0A}{0B}{0C}{0D}{0E}{0F}{13}{DA}
            //    }
            //    catch (Exception ex)
            //    {
            //        lblStatus.Text = "Error! " + ex.ToString();
            //    }
            //}
            //
            /*
             * Modbus RTU Function code 16:
             * Request: 
             * - Slave address: 1 byte
             * - Function code: 1 byte (0x10)
             * - Starting address: 2 bytes
             * - Quantity of registers: 2 bytes
             * - Byte count: 1 byte (2*n)
             * - Registers value: n * 2 bytes 
             * - CRC16: 2 bytes
             * Ex: 01 10 0000 0008 10 7806002091010008B90D0008B10D0008 DED5
             * Response:
             * - Slave address: 1 byte
             * - Function code: 1 byte (0x10)
             * - Starting address: 2 bytes
             * - Quantity of registers: 2 bytes
             * - CRC16: 2 bytes
             * Ex: 01 10 0000 0008 C1CF
            */
            //
            if (ofd.FileName == "")
            {
                MessageBox.Show("Please open the .hex file before updating the firmware!");
            }
            else
            {
                if (lblStatus.Text == "Connected")
                {
                    int j = 0;
                    while (true)
                    {
                        string input_string = arr_str[j];
                        //
                        int byte_count = Convert.ToByte(input_string.Substring(0, 2), 16);
                        //Console.WriteLine($"Byte count: {byte_count}");
                        int starting_address = (Convert.ToByte(input_string.Substring(2, 2), 16) << 8) | Convert.ToByte(input_string.Substring(4, 2), 16);
                        //Console.WriteLine($"Address: {starting_address}");
                        int record_type = Convert.ToByte(input_string.Substring(6, 2), 16);
                        //Console.WriteLine($"Record type: {record_type}");//00: Data, 01: End of File, 02: Extended segment address, 03: Start segment address, 04: Extended linear address, 05: Start linear address
                        if (record_type == 5)
                        {
                            //ModClient.WriteSingleCoil(0xFC00, true);
                            break;
                        }
                        if (record_type == 0)
                        {
                            string data_str = input_string.Substring(8, byte_count * 2);
                            //Console.WriteLine($"Data: {data_str}");
                            byte[] data_byte = new byte[byte_count];
                            for (int i = 0; i < (byte_count * 2); i += 2)
                            {
                                data_byte[i / 2] = Convert.ToByte(data_str.Substring(i, 2), 16);
                                //Console.WriteLine(data_byte[i / 2]);
                            }
                            var data_int = new int[byte_count / 2];
                            for (int i = 0; i < (byte_count / 2); i++)
                            {
                                data_int[i] = (data_byte[i * 2] << 8) | (data_byte[i * 2 + 1]);
                                //Console.WriteLine($"data_int[{i}]: {data_int[i]} ");
                            }

                            //
                            try
                            {
                                ModClient.WriteMultipleRegisters(starting_address, data_int);
                            }
                            catch (Exception ex)
                            {
                                lblStatus.Text = "Error! " + ex.ToString();
                            }
                        }
                        j++;
                        progressBar_WriteFirmware.Value = (100*j) / (arr_str.Length-2);
                        if ((100 * j) / (arr_str.Length - 2)==100)
                        {
                            DialogResult result = MessageBox.Show("Update firmware is complete!", "" , MessageBoxButtons.OK);
                            
                            if (result == DialogResult.OK)
                            {
                                progressBar_WriteFirmware.Value = 0;
                                if (lblStatus.Text == "Connected")
                                {
                                    try
                                    {
                                        ModClient.WriteSingleRegister(0xFC00, 1);
                                    }
                                    catch (Exception ex)
                                    {
                                        lblStatus.Text = "Error! " + ex.ToString();
                                    }
                                }
                            }
                        }
                    }

                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnUpdateFirmware.Enabled = false;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ModClient.Disconnect();
            lblStatus.Text = "Disconnected";
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnUpdateFirmware.Enabled = false;
        }

        private void btnEraseFlash_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Connected")
            {
                try
                { 
                    ModClient.WriteSingleRegister(100, 1);
                    MessageBox.Show("OK!");
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error! " + ex.ToString();
                    MessageBox.Show("Failed!");
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Connected")
            {
                try
                {
                    int startingAddress = 0;
                    int quantity = 16;
                    var dataReadFromFlashMemory = new int[quantity];
                    dataReadFromFlashMemory = ModClient.ReadInputRegisters(startingAddress, quantity);//Fuction code 04
                    for (int i = 0; i < quantity; i++)
                    {
                        Console.Write(dataReadFromFlashMemory[i]);
                        Console.Write("\t");
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error! " + ex.ToString();
                }
            }
        }

        private void btnSetFlag_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Connected")
            {
                try
                {
                    ModClient.WriteSingleRegister(0xFC00, 1);
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error! " + ex.ToString();
                }
            }
        }
    }
}
