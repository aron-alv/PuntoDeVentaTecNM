namespace PuntoDeVenta
{
    partial class FormNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.txtHorasTrabajadas = new System.Windows.Forms.Label();
            this.txtHorasTrabajadas1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPagoPorHora = new System.Windows.Forms.TextBox();
            this.BtnGenerarNomina = new System.Windows.Forms.Button();
            this.dgvtablaNominas = new System.Windows.Forms.DataGridView();
            this.ID_Nomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablaNominas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxEmpleados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpleados.ForeColor = System.Drawing.Color.White;
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(72, 136);
            this.comboBoxEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(209, 32);
            this.comboBoxEmpleados.TabIndex = 32;
            this.comboBoxEmpleados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleados_SelectedIndexChanged);
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.AutoSize = true;
            this.txtHorasTrabajadas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabajadas.ForeColor = System.Drawing.Color.White;
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(80, 208);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(176, 24);
            this.txtHorasTrabajadas.TabIndex = 51;
            this.txtHorasTrabajadas.Text = "Horas Trabajadas";
            // 
            // txtHorasTrabajadas1
            // 
            this.txtHorasTrabajadas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtHorasTrabajadas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorasTrabajadas1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabajadas1.ForeColor = System.Drawing.Color.White;
            this.txtHorasTrabajadas1.Location = new System.Drawing.Point(74, 234);
            this.txtHorasTrabajadas1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHorasTrabajadas1.Multiline = true;
            this.txtHorasTrabajadas1.Name = "txtHorasTrabajadas1";
            this.txtHorasTrabajadas1.Size = new System.Drawing.Size(221, 54);
            this.txtHorasTrabajadas1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Pago por Hora";
            // 
            // txtPagoPorHora
            // 
            this.txtPagoPorHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtPagoPorHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagoPorHora.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoPorHora.ForeColor = System.Drawing.Color.White;
            this.txtPagoPorHora.Location = new System.Drawing.Point(74, 345);
            this.txtPagoPorHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPagoPorHora.Multiline = true;
            this.txtPagoPorHora.Name = "txtPagoPorHora";
            this.txtPagoPorHora.Size = new System.Drawing.Size(221, 54);
            this.txtPagoPorHora.TabIndex = 53;
            // 
            // BtnGenerarNomina
            // 
            this.BtnGenerarNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnGenerarNomina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarNomina.ForeColor = System.Drawing.Color.White;
            this.BtnGenerarNomina.Location = new System.Drawing.Point(88, 503);
            this.BtnGenerarNomina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGenerarNomina.Name = "BtnGenerarNomina";
            this.BtnGenerarNomina.Size = new System.Drawing.Size(193, 84);
            this.BtnGenerarNomina.TabIndex = 55;
            this.BtnGenerarNomina.Text = "Generar Nomina ";
            this.BtnGenerarNomina.UseVisualStyleBackColor = false;
            this.BtnGenerarNomina.Click += new System.EventHandler(this.BtnGenerarNomina_Click);
            // 
            // dgvtablaNominas
            // 
            this.dgvtablaNominas.AllowUserToAddRows = false;
            this.dgvtablaNominas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtablaNominas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtablaNominas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtablaNominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtablaNominas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Nomina,
            this.NombreCompleto,
            this.FechaPago,
            this.HorasTrabajadas,
            this.TotalPagado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtablaNominas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtablaNominas.Location = new System.Drawing.Point(460, 136);
            this.dgvtablaNominas.Name = "dgvtablaNominas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtablaNominas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtablaNominas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvtablaNominas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtablaNominas.RowTemplate.Height = 24;
            this.dgvtablaNominas.Size = new System.Drawing.Size(889, 461);
            this.dgvtablaNominas.TabIndex = 56;
            // 
            // ID_Nomina
            // 
            this.ID_Nomina.HeaderText = "ID";
            this.ID_Nomina.MinimumWidth = 6;
            this.ID_Nomina.Name = "ID_Nomina";
            this.ID_Nomina.Visible = false;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            // 
            // FechaPago
            // 
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.MinimumWidth = 6;
            this.FechaPago.Name = "FechaPago";
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.HeaderText = "Horas Trabajadas";
            this.HorasTrabajadas.MinimumWidth = 6;
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            // 
            // TotalPagado
            // 
            this.TotalPagado.HeaderText = "Total Pagado";
            this.TotalPagado.MinimumWidth = 6;
            this.TotalPagado.Name = "TotalPagado";
            // 
            // FormNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(62)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1375, 655);
            this.Controls.Add(this.dgvtablaNominas);
            this.Controls.Add(this.BtnGenerarNomina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPagoPorHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.txtHorasTrabajadas1);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Name = "FormNomina";
            this.Text = "FormNomina";
            this.Load += new System.EventHandler(this.FormNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablaNominas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.Label txtHorasTrabajadas;
        private System.Windows.Forms.TextBox txtHorasTrabajadas1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPagoPorHora;
        private System.Windows.Forms.Button BtnGenerarNomina;
        private System.Windows.Forms.DataGridView dgvtablaNominas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Nomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabajadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagado;
    }
}