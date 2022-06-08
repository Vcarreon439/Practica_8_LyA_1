using Fare;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8_LyA_1
{
    public partial class frmPrograma : Form
    {
        Xeger obj;

        public frmPrograma()
        {
            InitializeComponent();
        }

        private void rdbtnEjer1_Click(object sender, EventArgs e)
        {
            this.txtRegex.Text = @"^[1-9]+[02468]$";
            this.obj = new Xeger(@"^[1-9]+[02468]$");
        }

        private void rdbtnEjer2_Click(object sender, EventArgs e)
        {
            this.txtRegex.Text = @"^[aeiuoAEIOU][1-9]+[A]$";
            this.obj = new Xeger(@"^[aeiuoAEIOU][1-9]+[A]$");
        }

        private string[] GenerarTextos(Xeger expresion, int cantidad) 
        {
            string[] textos = new string[cantidad];

            for (int i = 0; i < cantidad; i++)
                textos[i] = expresion.Generate();

            return textos;
        }

        private void RellenarLista(string[] arreglo) 
        {
            for (int i = 0; i < arreglo.Length; i++)
                this.lstResultados.Items.Add(arreglo[i]);

        }

        private void rdbtnEjer3_Click(object sender, EventArgs e)
        {
            this.txtRegex.Text = @"^[AB]{2,3}[CD]{3,4}[DE]{4,5}$";
            this.obj = new Xeger(@"^[AB]{2,3}[CD]{3,4}[DE]{4,5}$");
        }

        private void rdbtnEjer4_Click(object sender, EventArgs e)
        {
            this.txtRegex.Text = @"^[a-zA-Z]+[a-zA-Z\w_-]+@[a-zA-Z0-9]+(\.(com){1})(\.(mx)){0,1}$";
            this.obj = new Xeger(@"^[a-zA-Z]+[a-zA-Z\w_-]+@[a-zA-Z0-9]+(\.(com){1})(\.(mx)){0,1}$");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtRegex.Text!="")
            {
                this.obj = new Xeger(txtRegex.Text);
                RellenarLista(GenerarTextos(this.obj, (int)numericUpDown1.Value));
            }

            if (obj == null)
            {
                MessageBox.Show("Porfavor ingrese una expresion", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstResultados.Items.Clear();
            RellenarLista(GenerarTextos(this.obj, (int)numericUpDown1.Value));
            Console.WriteLine("Generado");
        }

        private void rdbtnNA_Click(object sender, EventArgs e)
        {
            this.txtRegex.Text = "";
            this.obj = null;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            foreach (string item in txtContenedorPruebas.Lines)
            {
                if (!Regex.IsMatch(item, $@"{txtERComprobar.Text}$"))
                {
                    MessageBox.Show($"La cadena {item} no comple con el formato");
                }
            }
        }

        private void rdbtnCmp1_Click(object sender, EventArgs e)
        {
            this.txtERComprobar.Text = @"^[1-9]+[02468]$";
        }

        private void rdbtnCmp2_Click(object sender, EventArgs e)
        {
            this.txtERComprobar.Text = @"^[aeiuoAEIOU][1-9]+[A]$";
        }

        private void rdbtnCmp3_Click(object sender, EventArgs e)
        {
            this.txtERComprobar.Text = @"^[AB]{2,3}[CD]{3,4}[DE]{4,5}$";
        }

        private void rdbtnCmp4_Click(object sender, EventArgs e)
        {
            this.txtERComprobar.Text = @"^[a-zA-Z]+[a-zA-Z\w_-]+@[a-zA-Z0-9]+(\.(com){1})(\.(mx)){0,1}$";
        }

        private void rdbtnNA2_Click(object sender, EventArgs e)
        {
            this.txtERComprobar.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Vcarreon439");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Edgar-Arguijo");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mejiaandiem3");
        }
    }
}
