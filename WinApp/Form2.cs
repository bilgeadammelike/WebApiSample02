using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form2 : Form
    {
        private const string URL = "http://localhost:15647/api/Shipper";
        private string urlParameters = "/api/Shipper/Post";        
        private const string DATA = "{\"ShipperID\" : 0, \"CompanyName\" : \"BBBB\", \"Phone\" : \"1111111\" }";
        public Form2()
        {
            InitializeComponent();
        }

        private static async void SendPost()
        {
            HttpClient client = new HttpClient();
            var hedE= await    client.PostAsJsonAsync(URL, new ShipperVM()
            {
                ShipperID = 0,
                CompanyName = "KKK",
                Phone = "123466"
            });            
        }

        private static async void SendGet()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(URL);

            //will throw an exception if not successful
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            ShipperVM deserializedProduct = JsonConvert.DeserializeObject<ShipperVM>(content);
            content = content.ToString();
        }



        private void btnPost_Click(object sender, EventArgs e)
        {
            SendPost();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            SendGet();
        }
    }
}
