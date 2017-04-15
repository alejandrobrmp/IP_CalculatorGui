using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Core
{
    class OutputDataGridViewManager
    {
        private DataGridView dgv;

        public OutputDataGridViewManager(DataGridView dgv){
            this.dgv = dgv;
        }

        public void addRow(IPRow row)
        {
            this.dgv.Rows.Add(row);
        }

        public List<string> getRows()
        {
            List<string> rows = new List<string>();

            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    string rowData = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        rowData += $" {cell.Value?.ToString()}";
                    }
                    rows.Add(rowData.TrimStart());
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    string rowData = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        rowData += $" {cell.Value?.ToString()}";
                    }
                    rows.Add(rowData.TrimStart());
                }
            }

            return rows;
        }

        public void clearAllRows()
        {
            dgv.Rows.Clear();
        }

        public void deselectAll()
        {
            dgv.ClearSelection();
        }
    }
}
