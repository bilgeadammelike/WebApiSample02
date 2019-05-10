using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProducts();
            
        }

        private async void GetProducts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:15647/");
                HttpResponseMessage response;
                response = await client.GetAsync("api/FakeProducts");
                if (response.IsSuccessStatusCode)
                {
                    ProductVM[] products = await response.Content.ReadAsAsync<ProductVM[]>();
        
                    foreach (var product in products)
                    {
                        listBox1.Items.Add(product);
                    }
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:15647/");

                HttpResponseMessage response = await client.PostAsJsonAsync("api/Test", new HedeClass()
                {
                    CategoryName = textBox1.Text,
                    Description = textBox2.Text,
                    ID = 1
                });

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.Content.ReadAsStringAsync().Result);

                }
                else
                {
                    MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                }
            }
        }
    }
}
