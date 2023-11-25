using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGIT_AERG_2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//! AERG-2324.PROGRAMA DE TELEGRAMA
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            //? AERG-2324.Inicializamos la variable coste
            double coste = 0;

            //! Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            //? AERG-2324.cambiamos rl radio boton urgente
            if (rbUrgente.Checked)
                tipoTelegrama = 'u';

            //! Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            //? AERG-2324.Añadimos el boton ordinario.
            if(rbOrdinario.Checked)
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else
            //! Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
