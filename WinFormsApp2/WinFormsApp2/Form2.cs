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
    public partial class Form2 : Form
    {
        Thread t2;

        public Form2()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(voltarJanela);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void voltarJanela(object obj)
        {
            Application.Run(new Form1());
        }

        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
