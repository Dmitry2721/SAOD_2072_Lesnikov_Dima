using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIst_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List list = new List();
        private void ToList()
        {
            int[] array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i]);
            }
        }

        private void buttonPrepend_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                list.Prepend(Convert.ToInt32(textBox1.Text));
                ToList();
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Insert number");
            }
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                list.Append(int.Parse(textBox1.Text));
                ToList();
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Insert number");
            }
        }

        private void buttonRemoveByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                list.RemoveByIndex(int.Parse(textBox1.Text));
                listBox1.Items.Clear();
                ToList();
                textBox1.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");
            }
            catch
            {
                MessageBox.Show("Insert number");
            }
        }

        private void buttonRemoveKey_Click(object sender, EventArgs e)
        {
            try
            {
                list.RemoveByKey(int.Parse(textBox1.Text));
                listBox1.Items.Clear();
                ToList();
                textBox1.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");
            }
            catch
            {
                MessageBox.Show("Insert number");
            }
        }

        private void buttonAddMiddle_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(int.Parse(textBox1.Text));
                listBox1.Items.Clear();
                ToList();
                textBox1.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");
            }
            catch
            {
                MessageBox.Show("Insert number");
            }
        }

        private void buttonFindByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                int value = list.FindByIndex(int.Parse(textBox1.Text));
                MessageBox.Show(value.ToString());
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");
            }
            catch
            {
                MessageBox.Show("Insert number");

            }
        }

        private void buttonFindByKey_Click(object sender, EventArgs e)
        {
            try
            {
                int value = list.FindByKey(int.Parse(textBox1.Text));
                MessageBox.Show(value.ToString());
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index have not been found");

            }
            catch
            {
                MessageBox.Show("Insert number");

            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                list.DivideForMegre(list.ToArray());
                ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
