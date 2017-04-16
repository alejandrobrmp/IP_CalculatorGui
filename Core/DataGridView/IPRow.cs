using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    class IPRow : DataGridViewRow
    {
        public IPRow(DataGridView dgv, params string[] values)
        {
            CreateCells(dgv);
            if (values.Length != Cells.Count)
                MessageBox.Show("Insercción de datos inconsistente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            for (int i = 0; i < values.Length; i++)
            {
                base.Cells[i].Value = values[i];
            }
        }
    }
}
