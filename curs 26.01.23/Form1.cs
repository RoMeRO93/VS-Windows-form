using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace curs_26._01._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(@"C:\\Users\\JohnSmith\\source\\repos\\curs 26.01.23\\curs 26.01.23\\input.txt");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    textBox1.AppendText(line);
                    textBox1.AppendText("\r\n");
                    textBox1.AppendText("\r\n");

                }

                reader.Close();

            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(String.Format("Fisierul cautat nu a putut fi citit pentru ca nu a fost gasit" ,  ex.Message));
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Fisierul nu a putut fi citit din motive nestiute"));
            }
        }

       
         private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("output.txt");
            string[] linii = textBox1.Lines;
            {
                foreach (var linie in linii)
                {
                    writer.WriteLine(linie);
                }
                writer.Close();

                MessageBox.Show("Fisierul a fost scris cu succes");
            }
        }
    
    }
}
