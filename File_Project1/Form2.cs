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
using System.Xml;

namespace File_Project1
{
    public partial class Form2 : Form
    {
        string[][] arr_values;
        string xmlfile;
           
        public Form2(String[][] values,string fileName)
        {
            InitializeComponent();
            arr_values = values;
            xmlfile = fileName;
          for (int i=0;i<arr_values[0].Length;i++)
            {
                string varaible = arr_values[0][i];
                columns_names_cmb.Items.Add(varaible);


            }
        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(xmlfile +".xml"))
            {
                XmlWriter writer = XmlWriter.Create(xmlfile + ".xml");
                writer.WriteStartDocument();
                writer.WriteStartElement(xmlfile + "s");

                for (int i = 1; i < arr_values.Length; i++)
                {

                    if (arr_values[i][0] != "-1")
                    {
                        writer.WriteStartElement(xmlfile);
                        for (int j = 0; j < arr_values[i].Length; j++)
                        {

                            writer.WriteStartElement(arr_values[0][j]);
                            writer.WriteString(arr_values[i][j]);
                            writer.WriteEndElement();

                        }
                        writer.WriteEndElement();
                    }



                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

            }else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlfile + ".xml");
                doc.DocumentElement.RemoveAll();
                doc.Save(xmlfile + ".xml");
               
                for (int i = 1; i < arr_values.Length; i++)
                {
                    XmlElement parent = doc.CreateElement(xmlfile);
                    if (arr_values[i][0] != "-1")
                    {
                        for (int j = 0; j < arr_values[i].Length; j++)
                        {
                            XmlElement node = doc.CreateElement(arr_values[0][j]);
                            node.InnerText = arr_values[i][j];
                            parent.AppendChild(node);
                        }
                        doc.Load(xmlfile + ".xml");
                        XmlElement root = doc.DocumentElement;
                        root.AppendChild(parent);
                        doc.Save(xmlfile + ".xml");
                    }
                }

            }

            MessageBox.Show("Done Load Data to XML");
           
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {


            int columnNUM = -1;
            for (int i = 0; i < arr_values[0].Length; i++) //col
            {
                if (arr_values[0][i] == columns_names_cmb.SelectedItem)
                {
                    columnNUM = i;
                }
            }
            /////////////////////////////////////////////////////////
            if (defaul_radiobtn.Checked)
            {
                MessageBox.Show("Any value is null will be have default value");

                if (default_value_txt.Text == "")
                {
                    MessageBox.Show("Enter Defult Value");
                }
                else
                {

                    for (int i = 0; i < arr_values.Length; i++)
                    {
                        if (arr_values[i][columnNUM] == " ")
                        {
                            arr_values[i][columnNUM] = default_value_txt.Text;
                        }

                    }

                }


            }
            /////////////////////////////////////////////////////////
            else if (not_null_radiobtn.Checked)
            {
                MessageBox.Show("if find null will be delete the record");


                for (int j = 0; j < arr_values.Length; j++) //rows
                {
                    if (arr_values[j][columnNUM] == " ")
                    {
                        for (int k = 0; k < arr_values[j].Length; k++) //col
                        {
                            arr_values[j][k] = "-1";
                        }
                    }

                }
            }
            /////////////////////////////////////////////////////////
            else if (uniqe_radiobtn.Checked)
            {
                MessageBox.Show("if find Repeated value will delete record for one");

                for (int i = 0; i < (arr_values.Length) - 1; i++) //row
                {
                    for (int j = i + 1; j < arr_values.Length; j++)
                    {
                        if (arr_values[i][columnNUM] == arr_values[j][columnNUM] && arr_values[i][columnNUM] != " ")
                        {

                            for (int k = 0; k < arr_values[j].Length; k++) //col
                            {
                                arr_values[j][k] = "-1";
                            }

                        }
                    }
                }
            }
            ////////////////////////////////////////////////////////////////
            else if (check_radiobtn.Checked)
            {
                MessageBox.Show("if any value have this condition will delete his record");

                int compare;
                int Column_Number = -1;
                if (value_txt.Text == "")
                {
                    MessageBox.Show("Enter Value");
                }
                else if (sign_cmb.SelectedItem == "")
                {
                    MessageBox.Show("Choose the sign");
                }

                else
                {
                    for (int j = 1; j < arr_values.Length; j++)
                    {
                        // test.Text = arr_values[j][Column_Number];
                        try
                        {
                            int arr_val = Int32.Parse(arr_values[j][columnNUM]);
                            int txt_val = Int32.Parse(value_txt.Text);


                            if ((sign_cmb.SelectedItem == ">"))
                            {
                                compare = arr_val.CompareTo(txt_val);
                                if (compare == 1)
                                {

                                    for (int k = 0; k < arr_values[j].Length; k++)
                                    {
                                        arr_values[j][k] = "-1";
                                    }

                                }

                            }

                            else if ((sign_cmb.SelectedItem == "<"))
                            {
                                compare = arr_val.CompareTo(txt_val);
                                if (compare == -1)
                                {
                                    for (int k = 0; k < arr_values[j].Length; k++)
                                    {
                                        arr_values[j][k] = "-1";
                                    }
                                }

                            }

                            else if ((sign_cmb.SelectedItem == "="))
                            {
                                compare = arr_val.CompareTo(txt_val);
                                if (compare == 0)
                                {
                                    for (int k = 0; k < arr_values[j].Length; k++)
                                    {
                                        arr_values[j][k] = "-1";
                                    }
                                }

                            }
                            else if ((sign_cmb.SelectedItem == "!="))
                            {
                                compare = arr_val.CompareTo(txt_val);
                                if (compare != 0)
                                {

                                    for (int k = 0; k < arr_values[j].Length; k++)
                                    {
                                        arr_values[j][k] = "-1";
                                    }
                                }

                            }
                        }
                        catch (System.FormatException ex)
                        {

                            for (int i = 0; i < arr_values[0].Length; i++)
                            {
                                if (arr_values[0][i] == columns_names_cmb.SelectedItem)
                                {
                                    Column_Number = i;
                                }
                            }
                            for (int s = 1; s < arr_values.Length; s++)
                            {
                                

                                 if ((sign_cmb.SelectedItem == "="))
                                {
                                    compare = arr_values[s][Column_Number].CompareTo(value_txt.Text);
                                    if (compare == 0)
                                    {
                                        for (int b = 0; b < arr_values[s].Length; b++)
                                        {
                                            arr_values[s][b] = "-1";
                                        }
                                    }

                                }
                                else if ((sign_cmb.SelectedItem == "!="))
                                {
                                    compare = arr_values[s][Column_Number].CompareTo(value_txt.Text);
                                    if (compare != 0)
                                    {
                                        // MessageBox.Show(value_txt.Text);



                                        for (int b = 0; b < arr_values[s].Length; b++)
                                        {
                                            arr_values[s][b] = "-1";
                                        }
                                    }

                                }


                            }
                            sign_cmb.Text = "";
                            value_txt.Text = "";
                            columns_names_cmb.Text = "";
                            check_radiobtn.Checked = false;
                            break;
                        }

                    }

                }
            }
        
            MessageBox.Show("Donnnnnnnnnne");
            
           
        }
        private void columns_names_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void uniqe_radiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void value_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sign_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void value_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(arr_values);
            f3.Show();
        }
    }
}
