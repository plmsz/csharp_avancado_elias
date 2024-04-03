using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_4_DelegateMethod
{
    public partial class Form1 : Form
    {
        static int count;
        public Form1()
        {
            InitializeComponent();
            btnClick.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Fui cliclado " + count + " vezes");
                count++;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
