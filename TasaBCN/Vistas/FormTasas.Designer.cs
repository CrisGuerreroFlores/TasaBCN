
namespace TasaBCN.Vistas
{
    partial class FormTasas
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_tasasCambio = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.panelMes = new System.Windows.Forms.Panel();
            this.cb_mes = new System.Windows.Forms.ComboBox();
            this.cb_anio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_RangoF = new System.Windows.Forms.RadioButton();
            this.rb_Mes = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tasasCambio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_tasasCambio);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(771, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Mes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_tasasCambio
            // 
            this.dgv_tasasCambio.AllowUserToAddRows = false;
            this.dgv_tasasCambio.AllowUserToDeleteRows = false;
            this.dgv_tasasCambio.AllowUserToOrderColumns = true;
            this.dgv_tasasCambio.AllowUserToResizeRows = false;
            this.dgv_tasasCambio.AutoGenerateColumns = false;
            this.dgv_tasasCambio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tasasCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tasasCambio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn});
            this.dgv_tasasCambio.DataSource = this.tasaBindingSource;
            this.dgv_tasasCambio.Location = new System.Drawing.Point(96, 242);
            this.dgv_tasasCambio.Name = "dgv_tasasCambio";
            this.dgv_tasasCambio.Size = new System.Drawing.Size(507, 231);
            this.dgv_tasasCambio.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Generar);
            this.groupBox1.Controls.Add(this.panelMes);
            this.groupBox1.Controls.Add(this.rb_RangoF);
            this.groupBox1.Controls.Add(this.rb_Mes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Por:";
            // 
            // btn_Generar
            // 
            this.btn_Generar.Location = new System.Drawing.Point(646, 25);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(75, 62);
            this.btn_Generar.TabIndex = 3;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Visible = false;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // panelMes
            // 
            this.panelMes.Controls.Add(this.cb_mes);
            this.panelMes.Controls.Add(this.cb_anio);
            this.panelMes.Controls.Add(this.label2);
            this.panelMes.Controls.Add(this.label1);
            this.panelMes.Location = new System.Drawing.Point(232, 11);
            this.panelMes.Name = "panelMes";
            this.panelMes.Size = new System.Drawing.Size(367, 90);
            this.panelMes.TabIndex = 2;
            // 
            // cb_mes
            // 
            this.cb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mes.FormattingEnabled = true;
            this.cb_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cb_mes.Location = new System.Drawing.Point(116, 49);
            this.cb_mes.Name = "cb_mes";
            this.cb_mes.Size = new System.Drawing.Size(210, 27);
            this.cb_mes.TabIndex = 3;
            // 
            // cb_anio
            // 
            this.cb_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_anio.FormattingEnabled = true;
            this.cb_anio.Location = new System.Drawing.Point(116, 13);
            this.cb_anio.Name = "cb_anio";
            this.cb_anio.Size = new System.Drawing.Size(210, 27);
            this.cb_anio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // rb_RangoF
            // 
            this.rb_RangoF.AutoSize = true;
            this.rb_RangoF.Location = new System.Drawing.Point(59, 66);
            this.rb_RangoF.Name = "rb_RangoF";
            this.rb_RangoF.Size = new System.Drawing.Size(131, 23);
            this.rb_RangoF.TabIndex = 1;
            this.rb_RangoF.Text = "Por Rango Fecha";
            this.rb_RangoF.UseVisualStyleBackColor = true;
            // 
            // rb_Mes
            // 
            this.rb_Mes.AutoSize = true;
            this.rb_Mes.Checked = true;
            this.rb_Mes.Location = new System.Drawing.Point(59, 37);
            this.rb_Mes.Name = "rb_Mes";
            this.rb_Mes.Size = new System.Drawing.Size(78, 23);
            this.rb_Mes.TabIndex = 0;
            this.rb_Mes.TabStop = true;
            this.rb_Mes.Text = "Por Mes";
            this.rb_Mes.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::TasaBCN.Properties.Resources.bcn;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(771, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Año";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Visible = false;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Visible = false;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Día";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Visible = false;
            // 
            // tasaBindingSource
            // 
            this.tasaBindingSource.DataSource = typeof(TasaBCN.Model.Tasa);
            // 
            // FormTasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 539);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTasas";
            this.Text = "Tasas de Cambio del BCN";
            this.Load += new System.EventHandler(this.FormTasas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tasasCambio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMes.ResumeLayout(false);
            this.panelMes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_tasasCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tasaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Panel panelMes;
        private System.Windows.Forms.ComboBox cb_mes;
        private System.Windows.Forms.ComboBox cb_anio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_RangoF;
        private System.Windows.Forms.RadioButton rb_Mes;
    }
}