using System;
using System.IO.Ports;
using System.Text;

namespace SensorsRS485
{
    public partial class Form1 : Form
    {

        byte[] buffer = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        float[] temperature = { 0, 0, 0 };
        float[] humidity = { 0, 0, 0 };
        ushort conductivity = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void formmatter(bool tx_or_rx, string val)
        {
            string date = DateTime.Now.ToString("HH:mm:ss.fffffff ->");
            if (tx_or_rx)
                textBox1.Text += $"{date} TX:  {val}\r\n";
            else
                textBox1.Text += $"{date} RX:  {val}\r\n";
        }

        private byte[] CRC16(byte[] bytes, byte len)
        {
            ushort crc = 0xFFFF;
            for (byte i = 0; i < len; ++i)
            {
                crc = (ushort)((crc & 0xFF00) | (crc & 0x00FF) ^ (bytes[i] & 0xFF));
                for (byte j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) > 0)
                    {
                        crc = (ushort)(crc >> 1);
                        crc = (ushort)(crc ^ 0xA001);
                    }
                    else
                        crc = (ushort)(crc >> 1);
                }
            }
            return new byte[2] { (byte)(crc % 0x100), (byte)(crc / 0x100) };
        }

        private void sendCommand(byte id, byte cmd)
        {
            SerialPort rs485 = new SerialPort();
            rs485.PortName = "COM14";
            rs485.BaudRate = 4800;
            rs485.Parity = Parity.None;
            rs485.StopBits = StopBits.One;
            rs485.DataBits = 8;

            // humidade:    04 03 00 00 00 01 84 5f      03 03 00 00 00 01 85 e8      02 03 00 00 00 01 84 39      01 03 00 00 00 01 84 0a
            // temperatura: 04 03 00 01 00 01 d5 9f      03 03 00 01 00 01 d4 28      02 03 00 01 00 01 d5 f9      01 03 00 01 00 01 d5 ca 
            // conduti:     04 03 00 02 00 01 25 9f      03 03 00 02 00 01 24 28      02 03 00 02 00 01 25 f9      01 03 00 02 00 01 25 ca

            byte[] packet = { id, 0x03, 0x00, cmd, 0x00, 0x01, 0x00, 0x00 };

            byte[] CRC = { 0x00, 0x00 };
            CRC = CRC16(packet, (byte)(packet.Length - 2));
            packet[5 + 1] = CRC[0];
            packet[5 + 2] = CRC[1];
            try
            {
                if (!rs485.IsOpen)
                {
                    rs485.Open();

                    rs485.Write(packet, 0, packet.Length);

                    string buf = "";
                    for (int i = 0; i < packet.Length; ++i)
                        buf += packet[i].ToString("X2") + " ";
                    formmatter(true, buf);


                    Thread.Sleep(100);
                    rs485.Read(buffer, 0, buffer.Length);

                    buf = "";
                    for (int i = 0; i < packet.Length - 1; ++i)
                        buf += buffer[i].ToString("X2") + " ";
                    formmatter(false, buf);

                    rs485.Close();
                }
            }
            catch (Exception err)
            {
                textBox1.Text = err.Message;
            }
            textBox1.SelectionStart = textBox1.Text.Length - 1;
            textBox1.ScrollToCaret();
        }

        private void getValues()
        {
            sendCommand(1, 0);
            ushort buff = (ushort)((buffer[3] << 8) & 0xFF00);
            buff |= buffer[4];
            humidity[0] = (float)buff / 10;

            sendCommand(2, 0);
            buff = (ushort)((buffer[3] << 8) & 0xFF00);
            buff |= buffer[4];
            humidity[1] = (float)buff / 10;

            sendCommand(3, 0);
            buff = (ushort)((buffer[3] << 8) & 0xFF00);
            buff |= buffer[4];
            humidity[2] = (float)buff / 10;

            sendCommand(1, 1);
            buff = (ushort)((buffer[3] << 8) & 0xFF00);
            buff |= buffer[4];
            temperature[0] = (float)buff / 10;
            temperature[0] = (buff & 0x1000) == 1 ? ((float)6553.5 - temperature[0]) * -1 : temperature[0];

            sendCommand(2, 1);
            buff = (ushort)((buffer[3] << 8) & 0xFF00);
            buff |= buffer[4];
            temperature[1] = (float)buff / 10;
            temperature[1] = (buff & 0x1000) == 1 ? ((float)6553.5 - temperature[1]) * -1 : temperature[1];

            sendCommand(3, 1);
            buff = (ushort)((buffer[3] << 8) & 0xFF00);
            buff |= buffer[4];
            temperature[2] = (float)buff / 10;
            temperature[2] = (buff & 0x1000) == 1 ? ((float)6553.5 - temperature[1]) * -1 : temperature[1];

            sendCommand(1, 2);
            conductivity = (ushort)((buffer[3] << 8) & 0xFF00);
            conductivity |= buffer[4];


            id1_humidityLabel.Text = humidity[0] == 0 ? $"  {humidity[0]}%" : $"{humidity[0]}%";
            id2_humidityLabel.Text = humidity[1] == 0 ? $"  {humidity[1]}%" : $"{humidity[1]}%";
            id3_humidityLabel.Text = humidity[2] == 0 ? $"  {humidity[2]}%" : $"{humidity[2]}%";

            id1_temperatureLabel.Text = temperature[0] == 0 ? $"  {temperature[0]}ºC" : $"{temperature[0]}ºC";
            id2_temperatureLabel.Text = temperature[1] == 0 ? $"  {temperature[1]}ºC" : $"{temperature[1]}ºC";

            id1_conductivityLabel.Text = $"{conductivity}us";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getValues();
        }

        async private void TagoIO(byte id) {
            string deviceToken = id == 1 ? "token1" : "token2";
            string tagoIOUrl = $"https://api.tago.io/data?token={deviceToken}";

            string json = id == 1 ? $"[ {{\"variable\":\"temperature\", \"value\":{Convert.ToString(temperature[0]).Replace(",", ".")}, \"unit\":\"ºC\"}}," +
                                    $"{{\"variable\":\"humidity\", \"value\":{Convert.ToString(humidity[0]).Replace(",", ".")}, \"unit\":\"%\"}}," +
                                    $"{{\"variable\":\"conductivity\", \"value\":{conductivity}, \"unit\":\"us/cm\" }}]" :
                                    $"[ {{\"variable\":\"temperature\", \"value\":{Convert.ToString(temperature[1]).Replace(",", ".")}, \"unit\":\"ºC\"}}," +
                                    $"{{\"variable\":\"humidity\", \"value\":{Convert.ToString(humidity[1]).Replace(",", ".")}, \"unit\":\"%\"}} ]";
            //textBox1.Text += json;
            using (var client = new HttpClient())
            {
                //var json = Newtonsoft.Json.JsonConvert.SerializeObject(dataToSend);
                
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(tagoIOUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    //textBox1.Text += "Sucesso no envio";
                }
                else
                {
                    //textBox1.Text += $"Erro: {response.StatusCode}";
                    var responseContent = await response.Content.ReadAsStringAsync();
                    //textBox1.Text += responseContent;
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //TagoIO(1);
            Thread.Sleep(1000);
            //TagoIO(2);
        }
    }
}
