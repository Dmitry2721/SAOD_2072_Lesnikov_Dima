using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    
    public partial class Form1 : Form
    {
        MyQueue<int> myqueue;
        public Form1()
        {
            InitializeComponent();
        }

        private void install_button_Click(object sender, EventArgs e)
        {
            try
            {
                myqueue = new MyQueue<int>(int.Parse(textBox1.Text));
                textBox1.Enabled = true;
                pop_button.Enabled = true;
                push_button.Enabled = true;
                top_button.Enabled = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Clear();
            }
        }

        private void push_button_Click(object sender, EventArgs e)
        {
            try
            {
                myqueue.Push(int.Parse(textBox1.Text));
                UpdateListBox();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void top_button_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = myqueue.Top().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pop_button_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = myqueue.Pop().ToString();
                UpdateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateListBox()
        {
            int[] arr = myqueue.ToArray();
            listBox1.Items.Clear();
            foreach (int value in arr)
            {
                listBox1.Items.Add(value);
            }
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            myqueue.Clean();
           
        }
    }
}
