using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace File_Project1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            label3.BackColor = TransparencyKey;           

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            string[][] values;
            if (checkBox1.Checked)
            {



                if (txt_names.Text == "")
                {
                    MessageBox.Show("please enter name of file ");

                }
                else if (delimiter_txt.Text == "")
                {
                    MessageBox.Show("please enter delimiter ");

                }
                else
                {
                    try
                    {
                        string f = txt_names.Text + ".txt";
                        var lines = File.ReadAllLines(f);

                         values = new string[lines.Length][];



                        for (int i = 0; i < lines.Length; i++)
                        {
                            var array = lines[i].Split(new string[] { delimiter_txt.Text }, StringSplitOptions.RemoveEmptyEntries);
                            values[i] = new string[array.Length];
                            for (int q = 0; q < array.Length; q++)
                            {

                                values[i][q] = array[q];
                            }
                        }
                        //label2.Text = values[5][0];

                        Form2 f2 = new Form2(values, txt_names.Text);
                        f2.Show();
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        MessageBox.Show("File is not Exist !!!");
                    }
                }
            }
            else if (checkBox2.Checked)
            {
                Class1 e1 = new Class1(@"C:\Users\Taher\Desktop\final\file_excel\File_Project1\bin\Debug\" + txt_names.Text + ".xlsx", 1);
                values = e1.Readcoll();
                Form2 f2 = new Form2(values, txt_names.Text);
                f2.Show();



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void delimiter_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Visible = true;
                label1.Text = "Name of Text File";
                txt_names.Visible = true;
                label2.Visible = true;
                delimiter_txt.Visible = true;
                go_btn.Visible = true;
            
            }
            else
            {
                label1.Visible = false;
                txt_names.Visible = false;
                label2.Visible = false;
                delimiter_txt.Visible = false;
                go_btn.Visible = false ;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label1.Visible = true;
                label1.Text = "Name of Excel File";
                txt_names.Visible = true;

                label2.Visible = false;
                delimiter_txt.Visible = false;

                go_btn.Visible = true;
            }
            else
            {
                label1.Visible = false;
                txt_names.Visible = false ;

                label2.Visible = false;
                delimiter_txt.Visible = false;
                go_btn.Visible = false;

            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
