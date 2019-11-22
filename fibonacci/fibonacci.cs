using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class fibonacci : Form
    {
        public fibonacci()
        {
            InitializeComponent();
        }

        //Funcion Recursiva 
        private void fibonacciResult(int number)
        {
            int n1 = 0, n2 = 1, n3 = 0;
            listBox1.Items.Add("Iteracion #" + n1 + ":  "+ n1);
            listBox1.Items.Add("Iteracion #" + n2 + ":  "+ n2);
            for (int i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                listBox1.Items.Add("Iteracion #" + i + ":  " + n3);
                
                n1 = n2;
                n2 = n3;

            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero=0;
            // Set the ListBox to display items in multiple columns.
            listBox1.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            // Shutdown the painting of the ListBox as items are added.
            listBox1.BeginUpdate();
                // Loop through and add 50 items to the ListBox.

                //Cantidad SET
            numero = Convert.ToInt32(textBox1.Text);
            fibonacciResult(numero);
            /*for (int x = 0; x <= Convert.ToInt32(textBox1.Text); x++)
            {
                listBox1.Items.Add( x + "! = " + fibonacciRecursiva(x)); 
            }*/


            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            factorial facto = new factorial();
            facto.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
    }
}
