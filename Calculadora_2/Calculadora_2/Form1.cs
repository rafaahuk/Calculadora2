using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

        }


        float R;


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float A = int.Parse(txt_valor1.Text);
            float B = int.Parse(txt_valor2.Text);




            if (radioButton1.Checked)
            {
                R = A + B;
                txt_expressao.Text = txt_valor1.Text + " " + radioButton1.Text + " " + txt_valor2.Text;
            }

            if (radioButton2.Checked)
            {
                R = A - B;
                txt_expressao.Text = txt_valor1.Text + " " + radioButton2.Text + " " + txt_valor2.Text;
            }

            if (radioButton3.Checked)
            {
                R = A * B;
                txt_expressao.Text = txt_valor1.Text + " " + radioButton3.Text + " " + txt_valor2.Text;
            }

            if (radioButton4.Checked)
            {
                R = A / B;
                txt_expressao.Text = txt_valor1.Text + " " + radioButton4.Text + " " + txt_valor2.Text;
            }

            txt_resultado.Text = Convert.ToString(R);
            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
