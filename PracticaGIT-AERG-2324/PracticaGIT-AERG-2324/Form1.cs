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
            //!? AERG-2324.Añadimos el caracter 'o' a la variable tipotelegrama como valor de origen.
            //!? AERG-2324.Si se marca el boton urgente,el valor de telegrama pasa a ser 'u'.

            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste ;

            //! AERG-2324.Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';

            //! AERG-2324.Obtengo el número de palabras que forma el telegrama
            //!? AERG-2324.Se añade esta funcion para que nos cuente las palabras y nos discrimine los caracteres y espacios.

            numPalabras = textoTelegrama.Split(' ','.',':',';').Length;

            //! AERG-2324.Si el telegrama es ordinario
            //!? AERG-2324.Añadimos llaves a los if para que se pueda ir paso a paso por todas las lineas
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                    coste = 2.5;//!? AERG-2324.Corregimos el coste del telegrama ordinario de 25 a 2.5€
                else
                    //!? AERG-2324.Cambiamos la formula del coste con el enunciado dado.
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            }
            else
            //! AERG-2324.Si el telegrama es urgente
            //!? AERG-2324.Añadimos llaves a los if para que pueda ir paso a paso por todas las lineas
            if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            }
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
