using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {

        new Thread t1;
        public Form3()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, EventArgs e)
        {
                     
                this.Close();
                t1 = new Thread(voltarJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            
        }
        private void voltarJanela(object obj)
        {
            Application.Run(new Form1());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comoBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comoBox1.SelectedItem == "BRASIL")
            {
                string a = "Xacarajé";

                cb.SelectedItem = a;
            }
        }
    }
}
