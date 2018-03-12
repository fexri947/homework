using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Red;
            reserve.Text += b.Text;
           
            

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void reserve_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            reserve.Text = name.Text  + "seat reserved";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
