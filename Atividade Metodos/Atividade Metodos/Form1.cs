using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Metodos objCalculos = new Metodos();
        int n1, n2, n3, n4, n5;

        private void btn_maior_Click(object sender, EventArgs e)
        {

            n1 = int.Parse(txt1.Text);
            n2 = int.Parse(txt2.Text);
            n3 = int.Parse(txt3.Text);
            n4 = int.Parse(txt4.Text);
            n5 = int.Parse(txt5.Text);


            lbl_result.Text = objCalculos.Maior(n1, n2, n3, n4, n5).ToString();
        }

        private void btn_menor_Click(object sender, EventArgs e)
        {

            n1 = int.Parse(txt1.Text);
            n2 = int.Parse(txt2.Text);
            n3 = int.Parse(txt3.Text);
            n4 = int.Parse(txt4.Text);
            n5 = int.Parse(txt5.Text);


            lbl_result.Text = objCalculos.Menor(n1, n2, n3, n4, n5).ToString();
        }

        private void btn_elevado_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(txt2.Text);
            n3 = int.Parse(txt3.Text);

            lbl_result.Text = objCalculos.Elevado(n2, n3).ToString();
        }

        private void btn_media_Click(object sender, EventArgs e)
        {

            n1 = int.Parse(txt1.Text);
            n2 = int.Parse(txt2.Text);
            n3 = int.Parse(txt3.Text);
            n4 = int.Parse(txt4.Text);
            n5 = int.Parse(txt5.Text);


            lbl_result.Text = objCalculos.Media(n1, n2, n3, n4, n5).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            n1 = int.Parse(txt1.Text);
            n2 = int.Parse(txt2.Text);
            n3 = int.Parse(txt3.Text);
            n4 = int.Parse(txt4.Text);
            n5 = int.Parse(txt5.Text);
                
            lbl_result.Text = objCalculos.Soma(n1, n2, n3, n4, n5).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
