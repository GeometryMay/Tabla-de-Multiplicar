namespace TablaMultiplicar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtNumeroTabla = new Guna.UI.WinForms.GunaTextBox();
            this.btnMostrarTabla = new Guna.UI.WinForms.GunaButton();
            this.dgvTablaMultiplicar = new Guna.UI.WinForms.GunaDataGridView();
            this.btnSalir = new Guna.UI.WinForms.GunaButton();
            this.btnLimpiar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaMultiplicar)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // txtNumeroTabla
            // 
            this.txtNumeroTabla.BackColor = System.Drawing.Color.Transparent;
            this.txtNumeroTabla.BaseColor = System.Drawing.Color.White;
            this.txtNumeroTabla.BorderColor = System.Drawing.Color.Silver;
            this.txtNumeroTabla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroTabla.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumeroTabla.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNumeroTabla.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumeroTabla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumeroTabla.Location = new System.Drawing.Point(321, 340);
            this.txtNumeroTabla.Name = "txtNumeroTabla";
            this.txtNumeroTabla.PasswordChar = '\0';
            this.txtNumeroTabla.Radius = 5;
            this.txtNumeroTabla.Size = new System.Drawing.Size(160, 30);
            this.txtNumeroTabla.TabIndex = 0;
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.AnimationHoverSpeed = 0.07F;
            this.btnMostrarTabla.AnimationSpeed = 0.03F;
            this.btnMostrarTabla.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarTabla.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMostrarTabla.BorderColor = System.Drawing.Color.Black;
            this.btnMostrarTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTabla.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMostrarTabla.FocusedColor = System.Drawing.Color.Empty;
            this.btnMostrarTabla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarTabla.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTabla.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTabla.Image")));
            this.btnMostrarTabla.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMostrarTabla.Location = new System.Drawing.Point(321, 385);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMostrarTabla.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMostrarTabla.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMostrarTabla.OnHoverImage = null;
            this.btnMostrarTabla.OnPressedColor = System.Drawing.Color.Black;
            this.btnMostrarTabla.Radius = 5;
            this.btnMostrarTabla.Size = new System.Drawing.Size(160, 42);
            this.btnMostrarTabla.TabIndex = 1;
            this.btnMostrarTabla.Text = "Mostrar Tabla";
            this.btnMostrarTabla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click);
            // 
            // dgvTablaMultiplicar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTablaMultiplicar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaMultiplicar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaMultiplicar.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaMultiplicar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablaMultiplicar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTablaMultiplicar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaMultiplicar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaMultiplicar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaMultiplicar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaMultiplicar.EnableHeadersVisualStyles = false;
            this.dgvTablaMultiplicar.GridColor = System.Drawing.Color.White;
            this.dgvTablaMultiplicar.Location = new System.Drawing.Point(-2, 64);
            this.dgvTablaMultiplicar.Name = "dgvTablaMultiplicar";
            this.dgvTablaMultiplicar.RowHeadersVisible = false;
            this.dgvTablaMultiplicar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaMultiplicar.Size = new System.Drawing.Size(801, 247);
            this.dgvTablaMultiplicar.TabIndex = 2;
            this.dgvTablaMultiplicar.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvTablaMultiplicar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaMultiplicar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTablaMultiplicar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTablaMultiplicar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTablaMultiplicar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTablaMultiplicar.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaMultiplicar.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvTablaMultiplicar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTablaMultiplicar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTablaMultiplicar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTablaMultiplicar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTablaMultiplicar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaMultiplicar.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTablaMultiplicar.ThemeStyle.ReadOnly = false;
            this.dgvTablaMultiplicar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTablaMultiplicar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTablaMultiplicar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTablaMultiplicar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTablaMultiplicar.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTablaMultiplicar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTablaMultiplicar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnSalir
            // 
            this.btnSalir.AnimationHoverSpeed = 0.07F;
            this.btnSalir.AnimationSpeed = 0.03F;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSalir.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalir.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSalir.Location = new System.Drawing.Point(535, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSalir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalir.OnHoverImage = null;
            this.btnSalir.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalir.Radius = 5;
            this.btnSalir.Size = new System.Drawing.Size(160, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AnimationHoverSpeed = 0.07F;
            this.btnLimpiar.AnimationSpeed = 0.03F;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiar.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiar.Location = new System.Drawing.Point(107, 385);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLimpiar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiar.OnHoverImage = null;
            this.btnLimpiar.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiar.Radius = 5;
            this.btnLimpiar.Size = new System.Drawing.Size(160, 42);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(297, 315);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(218, 15);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Ingrese la tabla de multiplicar que desea";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(314, 432);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(174, 13);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Create by: Yael Moises May Caamal";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(253, 9);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(301, 32);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "TABLAS DE MULTIPLICAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTablaMultiplicar);
            this.Controls.Add(this.btnMostrarTabla);
            this.Controls.Add(this.txtNumeroTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaMultiplicar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView dgvTablaMultiplicar;
        private Guna.UI.WinForms.GunaButton btnMostrarTabla;
        private Guna.UI.WinForms.GunaTextBox txtNumeroTabla;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnLimpiar;
        private Guna.UI.WinForms.GunaButton btnSalir;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}

