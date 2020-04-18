using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Project1
{
    public partial class Form3 : Form
    {
        string[][] arr_val;

        public Form3(string[][] arr)
        {
            InitializeComponent();
            arr_val = arr;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {


            int remove = -1;



            for (int i = 0; i < arr_val[0].Length; i++)
            {
                dataGridView1.Columns.Add(arr_val[0][i], arr_val[0][i]);
            }



            for (int j = 0; j < arr_val.Length; j++)
            {
                if (arr_val[j][0] != "-1")
                    dataGridView1.Rows.Add();
            }


            int r = 0;

            for (int i = 0; i < arr_val.Length; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (arr_val[i][j] != "-1")
                    {

                        dataGridView1.Rows[r].Cells[j].Value = arr_val[i][j];
                    }



                }
                if (arr_val[i][0] != "-1")
                {
                    r++;

                }

            }

            dataGridView1.Rows.RemoveAt(0);
              
              

        }
    }
}

