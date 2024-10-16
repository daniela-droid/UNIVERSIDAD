using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVERSIDAD
{
  public static class Utilidades
  {


        public static void Mensaje(string msj, bool IsError = false, string Titulo = "Universidad Anunciata")
        {


            if (IsError)
            {
                MessageBox.Show(msj, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(msj, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public static void Personalizareldatagriedvied(DataGridView dt)
        {
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt.EnableHeadersVisualStyles = false;
            dt.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8);
            dt.RowHeadersVisible = false;
            
            dt.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dt.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Pink;
            // dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(163, 166, 180);
            dt.BorderStyle = BorderStyle.Fixed3D;
            // dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 255);
            //dataGridView1.DefaultCellStyle.Padding = new Padding(5);
            // dataGridView1.RowsDefaultCellStyle.Padding = new Padding(15);
            dt.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dt.BackgroundColor = Color.White;
            dt.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dt.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 10, FontStyle.Regular);
            dt.DefaultCellStyle.SelectionForeColor = Color.Azure;
            //dataGridView1.GridColor = Color.FromArgb(238, 242, 245);
            // dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            foreach (DataGridViewRow Row in dt.Rows)
            {
                Row.DividerHeight = 1;
                Row.Height = 30;
            }
            foreach (DataGridViewColumn col in dt.Columns)
            {

                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        public static string GetIp()
        {
            string ip;
            System.Net.IPHostEntry dirIp;

            try
            {
                dirIp = System.Net.Dns.GetHostEntry(GetComputerName());
                ip = dirIp.AddressList[1].ToString();
            }
            catch (Exception)
            {
                throw;
            }
            return ip;

        }

        public static string GetComputerName()
        {
            return  System.Net.Dns.GetHostName();

        }





    }



}

