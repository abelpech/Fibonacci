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
    public partial class factorial : Form
    {
        public factorial()
        {
            InitializeComponent();
        }

        //Funcion Recursiva 
        private int factorialResult(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return (n * factorialResult(n - 1));
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Set the ListBox to display items in multiple columns.
            listBox1.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            // Shutdown the painting of the ListBox as items are added.
            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            for (int x = 0; x <= Convert.ToInt32(textBox1.Text); x++)
            {
                listBox1.Items.Add(x + "! = " + factorialResult(x));
            }
            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
