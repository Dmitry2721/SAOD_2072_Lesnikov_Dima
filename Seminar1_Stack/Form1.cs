using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar1_Stack
{
    public partial class Form1 : Form
    {
        Stack<int> stack;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Push(int.Parse(textBoxValue.Text));
                UpdateListBox();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxValue.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateListBox()
        {
            int[] array = stack.ToArray();
            listBox1.Items.Clear();
            foreach (int value in array)
            {
                listBox1.Items.Add(value);
            }
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOut.Text = stack.Top().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOut.Text = stack.Pop().ToString();
                UpdateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonShape_Click(object sender, EventArgs e)
        {
            try
            {
                stack = new Stack<int>(int.Parse(textBoxShape.Text));
                textBoxValue.Enabled = true;
                buttonPop.Enabled = true;
                buttonPush.Enabled = true;
                buttonTop.Enabled = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxValue.Clear();
            }

        }
    }
}
