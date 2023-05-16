using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Parchis
{
    public partial class Demo : Form
    {
        public class Rojo
        {
            int X;
            int Y;

        }

        public class Posiciones
        {
            
        }

        public Demo()
        {
            InitializeComponent();
            
        }

        int dad;
        private void Demo_Load(object sender, EventArgs e)
        {
            
        }

        private void dado_Click(object sender, EventArgs e)
        {
            int dado; //Creamos la variable dado con la cual cambiaremos los valores de nuestro dado 
            Random rand = new Random(); //Creamos un objeto de numeros aleatorios 
            dado = rand.Next(1, 7);
            MessageBox.Show("Dado=" + dado);

            //Definimos los valores graficos que tendra el dado del parchis
            if (dado == 1)
            {
                Dado.Image = Image.FromFile("Cara1.png");
            }
            if (dado == 2)
            {
              // Dado.Image = Image.FromFile("Cara2.png");
            }
            if (dado == 3)
            {
                Dado.Image = Image.FromFile("Cara3.png");
            }
            if (dado == 4)
            {
                Dado.Image = Image.FromFile("Cara4.png");
            }
            if (dado == 5)
            {
                Dado.Image = Image.FromFile("Cara5.png");
            }
            if (dado == 6)
            {
                Dado.Image = Image.FromFile("Cara6.png");
            }

            int p = Inicializar(dado);

            if (p==0)
            {
               
                MessageBox.Show("Vuelva a tirar el dado para avanzar");
                int dad = dado;
                Mover(dado);


            }

        }

        public int Inicializar(int dado)
        {
            if (dado == 5)
            {
                MessageBox.Show("Ya puede mover ficha");
                rojo.Location = new Point(359, 100);

                return 0;
            }

            else 
            {
                return (-1);
            }
        }

        public void Mover(int dado)
        {
            int X = rojo.Location.X;
            int Y = rojo.Location.Y;
            rojo.Location = new Point(X,Y);

        }

        public void DamePosicion(int x, int y)
        {
            x = rojo.Location.X;
            y = rojo.Location.Y;
            string a = Convert.ToString(x);
            string b = Convert.ToString(y);
            MessageBox.Show(a +","+ b);
        }
        private void tablero_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rojo_Load(object sender, EventArgs e)
        {
            


        }

        private void rojo_Click(object sender, EventArgs e)
        {

        }
    }
}
