namespace SisCob.Presentation.Reportes.UserControls
{
    partial class AsistenciaGeneral
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPorGrado = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.btnHoyGeneral = new System.Windows.Forms.Button();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panelFiltradoGeneral = new System.Windows.Forms.Panel();
            this.dtffGeneral = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtfiGeneral = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkFiltradoGeneral = new System.Windows.Forms.CheckBox();
            this.panelPorGrado = new System.Windows.Forms.Panel();
            this.dtffGrado = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelFiltradoGeneral.SuspendLayout();
            this.panelPorGrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbPorGrado);
            this.panel1.Controls.Add(this.rbGeneral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modo de Reporte:";
            // 
            // rbPorGrado
            // 
            this.rbPorGrado.AutoSize = true;
            this.rbPorGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorGrado.Location = new System.Drawing.Point(275, 8);
            this.rbPorGrado.Name = "rbPorGrado";
            this.rbPorGrado.Size = new System.Drawing.Size(96, 24);
            this.rbPorGrado.TabIndex = 1;
            this.rbPorGrado.Text = "Por grado";
            this.rbPorGrado.UseVisualStyleBackColor = true;
            this.rbPorGrado.CheckedChanged += new System.EventHandler(this.rbPorGrado_CheckedChanged);
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGeneral.Location = new System.Drawing.Point(185, 8);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(84, 24);
            this.rbGeneral.TabIndex = 0;
            this.rbGeneral.Text = "General";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.CheckedChanged += new System.EventHandler(this.rbGeneral_CheckedChanged);
            // 
            // btnHoyGeneral
            // 
            this.btnHoyGeneral.BackColor = System.Drawing.Color.Navy;
            this.btnHoyGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoyGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoyGeneral.ForeColor = System.Drawing.Color.White;
            this.btnHoyGeneral.Location = new System.Drawing.Point(10, 14);
            this.btnHoyGeneral.Name = "btnHoyGeneral";
            this.btnHoyGeneral.Size = new System.Drawing.Size(127, 32);
            this.btnHoyGeneral.TabIndex = 0;
            this.btnHoyGeneral.Text = "Hasta Hoy";
            this.btnHoyGeneral.UseVisualStyleBackColor = false;
            this.btnHoyGeneral.Click += new System.EventHandler(this.btnHoyGeneral_Click);
            // 
            // cbGrado
            // 
            this.cbGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(10, 22);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(234, 28);
            this.cbGrado.TabIndex = 1;
            this.cbGrado.Text = "Selecciona Un Grado";
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.panelFiltradoGeneral);
            this.panelGeneral.Controls.Add(this.checkFiltradoGeneral);
            this.panelGeneral.Controls.Add(this.btnHoyGeneral);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(0, 38);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(884, 63);
            this.panelGeneral.TabIndex = 2;
            this.panelGeneral.Visible = false;
            this.panelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGeneral_Paint);
            // 
            // panelFiltradoGeneral
            // 
            this.panelFiltradoGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltradoGeneral.Controls.Add(this.dtffGeneral);
            this.panelFiltradoGeneral.Controls.Add(this.label3);
            this.panelFiltradoGeneral.Controls.Add(this.dtfiGeneral);
            this.panelFiltradoGeneral.Controls.Add(this.label2);
            this.panelFiltradoGeneral.Location = new System.Drawing.Point(234, 10);
            this.panelFiltradoGeneral.Name = "panelFiltradoGeneral";
            this.panelFiltradoGeneral.Size = new System.Drawing.Size(347, 37);
            this.panelFiltradoGeneral.TabIndex = 2;
            // 
            // dtffGeneral
            // 
            this.dtffGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtffGeneral.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtffGeneral.Location = new System.Drawing.Point(240, 6);
            this.dtffGeneral.Name = "dtffGeneral";
            this.dtffGeneral.Size = new System.Drawing.Size(101, 24);
            this.dtffGeneral.TabIndex = 3;
            this.dtffGeneral.ValueChanged += new System.EventHandler(this.dtffGeneral_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // dtfiGeneral
            // 
            this.dtfiGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfiGeneral.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfiGeneral.Location = new System.Drawing.Point(67, 7);
            this.dtfiGeneral.Name = "dtfiGeneral";
            this.dtfiGeneral.Size = new System.Drawing.Size(101, 24);
            this.dtfiGeneral.TabIndex = 1;
            this.dtfiGeneral.ValueChanged += new System.EventHandler(this.dtfiGeneral_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde:";
            // 
            // checkFiltradoGeneral
            // 
            this.checkFiltradoGeneral.AutoSize = true;
            this.checkFiltradoGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFiltradoGeneral.Location = new System.Drawing.Point(143, 19);
            this.checkFiltradoGeneral.Name = "checkFiltradoGeneral";
            this.checkFiltradoGeneral.Size = new System.Drawing.Size(89, 24);
            this.checkFiltradoGeneral.TabIndex = 1;
            this.checkFiltradoGeneral.Text = "Filtrado";
            this.checkFiltradoGeneral.UseVisualStyleBackColor = true;
            this.checkFiltradoGeneral.CheckedChanged += new System.EventHandler(this.checkFiltradoGeneral_CheckedChanged);
            // 
            // panelPorGrado
            // 
            this.panelPorGrado.Controls.Add(this.dtffGrado);
            this.panelPorGrado.Controls.Add(this.label4);
            this.panelPorGrado.Controls.Add(this.cbGrado);
            this.panelPorGrado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPorGrado.Location = new System.Drawing.Point(0, 101);
            this.panelPorGrado.Name = "panelPorGrado";
            this.panelPorGrado.Size = new System.Drawing.Size(884, 65);
            this.panelPorGrado.TabIndex = 3;
            this.panelPorGrado.Visible = false;
            // 
            // dtffGrado
            // 
            this.dtffGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtffGrado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtffGrado.Location = new System.Drawing.Point(323, 22);
            this.dtffGrado.Name = "dtffGrado";
            this.dtffGrado.Size = new System.Drawing.Size(125, 29);
            this.dtffGrado.TabIndex = 3;
            this.dtffGrado.ValueChanged += new System.EventHandler(this.dtffGrado_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 166);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(884, 323);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // AsistenciaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelPorGrado);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panel1);
            this.Name = "AsistenciaGeneral";
            this.Size = new System.Drawing.Size(884, 489);
            this.Load += new System.EventHandler(this.ConteoAcumulado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelFiltradoGeneral.ResumeLayout(false);
            this.panelFiltradoGeneral.PerformLayout();
            this.panelPorGrado.ResumeLayout(false);
            this.panelPorGrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPorGrado;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.Button btnHoyGeneral;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelFiltradoGeneral;
        private System.Windows.Forms.DateTimePicker dtfiGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkFiltradoGeneral;
        private System.Windows.Forms.DateTimePicker dtffGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPorGrado;
        private System.Windows.Forms.DateTimePicker dtffGrado;
        private System.Windows.Forms.Label label4;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}
