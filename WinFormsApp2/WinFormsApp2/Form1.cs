using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Thread t1;

        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {

            this.Close();
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void abrirJanela(object obj)
        {
            Application.Run(new Form2());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comoBox1.SelectedItem == "BRASIL")
            {
                BRASIL.Visible = true;
            }
            else
            {
                BRASIL.Visible = false;
            }


            if (comoBox1.SelectedItem == "ARGENTINA ")
            {
                ARGENTINA.Visible = true;
            }
            else
            {
                ARGENTINA.Visible = false;
            }


            if (comoBox1.SelectedItem == "ESTADOS UNIDOS")
            {
                ESTADOSUNIDOS.Visible = true;
            }
            else
            {
                ESTADOSUNIDOS.Visible = false;
            }


            if (comoBox1.SelectedItem == "JAPÃO")
            {
                JAPAO.Visible = true;
            }
            else
            {
                JAPAO.Visible = false;
            }


        }

        private void JAPAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanela2);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }
        private void abrirJanela2(object obj)
        {
            Application.Run(new Form3());
        }

    }
}
