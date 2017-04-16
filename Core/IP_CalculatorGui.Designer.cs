namespace Core
{
    partial class IP_Calculator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CleanInputs_Button = new System.Windows.Forms.Button();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.Netmask_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CalculatingInfo_Label = new System.Windows.Forms.Label();
            this.Deselect_Button = new System.Windows.Forms.Button();
            this.CleanGrid_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Output_GridView = new System.Windows.Forms.DataGridView();
            this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Máscara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rango = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broadcast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Output_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CleanInputs_Button);
            this.groupBox1.Controls.Add(this.Calculate_Button);
            this.groupBox1.Controls.Add(this.Netmask_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IP_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ip a calcular";
            // 
            // CleanInputs_Button
            // 
            this.CleanInputs_Button.Location = new System.Drawing.Point(322, 67);
            this.CleanInputs_Button.Name = "CleanInputs_Button";
            this.CleanInputs_Button.Size = new System.Drawing.Size(75, 23);
            this.CleanInputs_Button.TabIndex = 6;
            this.CleanInputs_Button.Text = "Limpiar";
            this.CleanInputs_Button.UseVisualStyleBackColor = true;
            this.CleanInputs_Button.Click += new System.EventHandler(this.CleanInputs_Button_Click);
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Location = new System.Drawing.Point(322, 96);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(75, 23);
            this.Calculate_Button.TabIndex = 5;
            this.Calculate_Button.Text = "Calcular";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // Netmask_TextBox
            // 
            this.Netmask_TextBox.Location = new System.Drawing.Point(61, 46);
            this.Netmask_TextBox.Name = "Netmask_TextBox";
            this.Netmask_TextBox.Size = new System.Drawing.Size(231, 22);
            this.Netmask_TextBox.TabIndex = 4;
            this.Netmask_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Netmask_TextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Máscara";
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.Location = new System.Drawing.Point(61, 18);
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(231, 22);
            this.IP_TextBox.TabIndex = 2;
            this.IP_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IP_TextBox_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CalculatingInfo_Label);
            this.groupBox2.Controls.Add(this.Deselect_Button);
            this.groupBox2.Controls.Add(this.CleanGrid_Button);
            this.groupBox2.Controls.Add(this.Save_Button);
            this.groupBox2.Controls.Add(this.Output_GridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 302);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // CalculatingInfo_Label
            // 
            this.CalculatingInfo_Label.AutoSize = true;
            this.CalculatingInfo_Label.Location = new System.Drawing.Point(6, 18);
            this.CalculatingInfo_Label.Name = "CalculatingInfo_Label";
            this.CalculatingInfo_Label.Size = new System.Drawing.Size(0, 13);
            this.CalculatingInfo_Label.TabIndex = 13;
            // 
            // Deselect_Button
            // 
            this.Deselect_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Deselect_Button.Location = new System.Drawing.Point(337, 14);
            this.Deselect_Button.Name = "Deselect_Button";
            this.Deselect_Button.Size = new System.Drawing.Size(94, 23);
            this.Deselect_Button.TabIndex = 12;
            this.Deselect_Button.Text = "Deseleccionar";
            this.Deselect_Button.UseVisualStyleBackColor = true;
            this.Deselect_Button.Click += new System.EventHandler(this.Deselect_Button_Click);
            // 
            // CleanGrid_Button
            // 
            this.CleanGrid_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanGrid_Button.Location = new System.Drawing.Point(518, 14);
            this.CleanGrid_Button.Name = "CleanGrid_Button";
            this.CleanGrid_Button.Size = new System.Drawing.Size(75, 23);
            this.CleanGrid_Button.TabIndex = 11;
            this.CleanGrid_Button.Text = "Limpiar";
            this.CleanGrid_Button.UseVisualStyleBackColor = true;
            this.CleanGrid_Button.Click += new System.EventHandler(this.CleanGrid_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(437, 14);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 10;
            this.Save_Button.Text = "Guardar";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Output_GridView
            // 
            this.Output_GridView.AllowUserToAddRows = false;
            this.Output_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Output_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clase,
            this.Red,
            this.Máscara,
            this.Rango,
            this.Broadcast});
            this.Output_GridView.Location = new System.Drawing.Point(0, 43);
            this.Output_GridView.Name = "Output_GridView";
            this.Output_GridView.ReadOnly = true;
            this.Output_GridView.Size = new System.Drawing.Size(593, 253);
            this.Output_GridView.TabIndex = 9;
            // 
            // Clase
            // 
            this.Clase.HeaderText = "Clase";
            this.Clase.Name = "Clase";
            this.Clase.ReadOnly = true;
            // 
            // Red
            // 
            this.Red.HeaderText = "Red";
            this.Red.Name = "Red";
            this.Red.ReadOnly = true;
            // 
            // Máscara
            // 
            this.Máscara.HeaderText = "Máscara";
            this.Máscara.Name = "Máscara";
            this.Máscara.ReadOnly = true;
            // 
            // Rango
            // 
            this.Rango.HeaderText = "Rango";
            this.Rango.Name = "Rango";
            this.Rango.ReadOnly = true;
            this.Rango.Width = 150;
            // 
            // Broadcast
            // 
            this.Broadcast.HeaderText = "Broadcast";
            this.Broadcast.Name = "Broadcast";
            this.Broadcast.ReadOnly = true;
            // 
            // IP_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IP_Calculator";
            this.Text = "IP_Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Output_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Netmask_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP_TextBox;
        private System.Windows.Forms.Button CleanInputs_Button;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CleanGrid_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.DataGridView Output_GridView;
        private System.Windows.Forms.Button Deselect_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Máscara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rango;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broadcast;
        private System.Windows.Forms.Label CalculatingInfo_Label;
    }
}

