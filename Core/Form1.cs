using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Core
{
    public partial class IP_Calculator : Form
    {
        private OutputDataGridViewManager outputDataGridViewManager;

        public IP_Calculator()
        {
            initComponents();
        }

        private void initComponents()
        {
            InitializeComponent();
            outputDataGridViewManager = new OutputDataGridViewManager(this.Output_GridView);
        }

        private void saveFile()
        {
            List<string> lines = outputDataGridViewManager.getRows();

            if (lines.Count > 0)
            {
                SaveFileDialog save = FileDialogs.saveFileDialog("IPs.txt", "Archivo de texto | *.txt");

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    foreach (var item in lines)
                    {
                        writer.WriteLine(item);
                    }
                    writer.Dispose();
                    writer.Close();
                }
            }
            else
            {
                MessageBox.Show("No hay filas que guardar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }





        private void CleanGrid_Button_Click(object sender, EventArgs e)
        {
            outputDataGridViewManager.clearAllRows();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            this.saveFile();
        }

        private void CleanInputs_Button_Click(object sender, EventArgs e)
        {
            this.IP_TextBox.Text = "";
            this.Netmask_TextBox.Text = "";
        }

        private void Deselect_Button_Click(object sender, EventArgs e)
        {
            outputDataGridViewManager.deselectAll();
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            AddressInfo a = new AddressInfo(AddressInfo.parse(IP_TextBox.Text, IP_TextBox.Name), AddressInfo.parse(Netmask_TextBox.Text, Netmask_TextBox.Name));
        }

        private void IP_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Calculate_Button_Click(this, new EventArgs());
        }

        private void Netmask_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Calculate_Button_Click(this, new EventArgs());
        }
    }
}
