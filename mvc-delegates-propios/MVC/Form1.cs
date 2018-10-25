using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace MVC
{
    public delegate void AgregarComidaDelegate(string pNombre, int pProteinas, int pCarbohidratos, int pGrasas);

    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (OnAgregarComida != null)
            {
                
                OnAgregarComida.Invoke(nombreTextBox.Text, Int32.Parse(proteinasTextBox.Text), Int32.Parse(carbohidratosTextBox.Text), Int32.Parse(grasasTextBox.Text));
            }
        }

        public void AgregarComida(Comida comida)
        {
            comidasList.Items.Add(comida);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void contactosList_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
