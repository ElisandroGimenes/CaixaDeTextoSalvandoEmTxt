using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaDeTextoSalvandoEmTxt
{
    public partial class Form1 : Form
    {
        String path = @"C:\Users\Elisandro\Documents\Elisandro\ArquivoSalvos\Arquivo" + DateTime.Now.ToString("dd_MM_yy_HH_mm_ss") + ".txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                using (FileStream fs = File.Create(path))
                {

                    fs.Close();
                }

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(txtTexto.Text);
                }

                txtTexto.Text = "";
                
                MessageBox.Show("Arquivo salvo com sucesso!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado! \n\n" + ex.Message);
            }

            Application.Exit();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

