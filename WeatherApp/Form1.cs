using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        string city = "Saint Petersburg";
        string appId = "04a0a624f0486a756afcec98cc60509b";

        public Form1()
        {
            InitializeComponent();
        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create($"http://api.openweathermap.org/data/2.5/weather?q={city}&lang=ru&appid={appId}");
            request.Method = "GET";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                answer = await reader.ReadToEndAsync();
            }

            response.Close();

            OpenWeather.OpenWeather ow = JsonConvert.DeserializeObject<
                OpenWeather.OpenWeather>(answer);
            richTextBox1.Text = JsonConvert.SerializeObject(ow, Formatting.Indented).Replace(" ","\t");
        }
    }
}
