using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Utilidades
{
    public static class Utilidades
    {
        public static void Mensaje(string msj, bool IsError = false, string Titulo="Universidad Anunciata")
        {
            

                if (IsError)
                {
                MessageBox.Show(msj, Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);

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
            dt.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Beige;
            // dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(163, 166, 180);
            //DtListado.BorderStyle = BorderStyle.None;
            // dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 255);
            //dataGridView1.DefaultCellStyle.Padding = new Padding(5);
            // dataGridView1.RowsDefaultCellStyle.Padding = new Padding(15);
          dt.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
          dt.BackgroundColor = Color.White;
            dt.CellBorderStyle = DataGridViewCellBorderStyle.None;
            // dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Roboto"), 12, FontStyle.Regular);
            dt.DefaultCellStyle.SelectionForeColor = Color.Azure;
            //dataGridView1.GridColor = Color.FromArgb(238, 242, 245);
            // dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

        }


    }
}
