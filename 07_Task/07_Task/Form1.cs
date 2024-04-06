using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBaixar_Click(object sender, EventArgs e)
        {
            string endereco =  txtSite.Text;

            WebClient web = new WebClient();
            //string html = web.DownloadString(endereco);
            //use o https://www.dailymail.co.uk/home/index.html
            string html = await web.DownloadStringTaskAsync(new Uri(endereco));

            txtResultado.Text = html;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSite_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
