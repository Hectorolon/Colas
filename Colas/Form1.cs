using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        Cola fifo = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            Proceso nuevo = null;
            int p;
            int cv = 0;
            int pa = 0;
            int cp = 0;
            int pp = 0;

            for (int i = 1; i <= 300; i++)
            {
                p = aleatorio.Next(1, 101);
                if (p <= 35)
                {
                    nuevo = new Proceso();
                    fifo.encolar(nuevo);
                }
                if (fifo.ver() != null && fifo.ver().ciclos > 0)
                {
                    fifo.ver().ciclos--;
                    if (fifo.ver().ciclos == 0)
                    {
                        fifo.desencolar();
                        pa++;
                    }
                }
                else
                    cv++;
            }

            while (fifo.ver() != null && fifo.ver().ciclos > 0)
            {
                fifo.ver().ciclos--;
                cp++;
                if (fifo.ver().ciclos == 0)
                {
                    fifo.desencolar();
                    pp++;
                }
            }
            //Proceso ultimo = fifo.ver();
            //ultimo = null;

            txtCV.Text = cv.ToString();
            txtPA.Text = pa.ToString();
            txtPP.Text = pp.ToString();
            txtCP.Text = cp.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
