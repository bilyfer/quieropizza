namespace QuieroPizza.Win
{
    partial class Form2
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label productoLabel;
            System.Windows.Forms.Label totalLabel;
            this.listaReporteVentasPorProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaReporteVentasPorProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            cantidadLabel = new System.Windows.Forms.Label();
            productoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaReporteVentasPorProductoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaReporteVentasPorProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listaReporteVentasPorProductoDataGridView
            // 
            this.listaReporteVentasPorProductoDataGridView.AutoGenerateColumns = false;
            this.listaReporteVentasPorProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaReporteVentasPorProductoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.listaReporteVentasPorProductoDataGridView.DataSource = this.listaReporteVentasPorProductoBindingSource;
            this.listaReporteVentasPorProductoDataGridView.Location = new System.Drawing.Point(12, 133);
            this.listaReporteVentasPorProductoDataGridView.Name = "listaReporteVentasPorProductoDataGridView";
            this.listaReporteVentasPorProductoDataGridView.Size = new System.Drawing.Size(620, 286);
            this.listaReporteVentasPorProductoDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // listaReporteVentasPorProductoBindingSource
            // 
            this.listaReporteVentasPorProductoBindingSource.DataSource = typeof(QuieroPizza.BL.ReporteVentasPorProducto);
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(13, 31);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 2;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReporteVentasPorProductoBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(72, 28);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 3;
            // 
            // productoLabel
            // 
            productoLabel.AutoSize = true;
            productoLabel.Location = new System.Drawing.Point(13, 57);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new System.Drawing.Size(53, 13);
            productoLabel.TabIndex = 4;
            productoLabel.Text = "Producto:";
            // 
            // productoTextBox
            // 
            this.productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReporteVentasPorProductoBindingSource, "Producto", true));
            this.productoTextBox.Location = new System.Drawing.Point(72, 54);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(100, 20);
            this.productoTextBox.TabIndex = 5;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(13, 83);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 6;
            totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReporteVentasPorProductoBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(72, 80);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 439);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(productoLabel);
            this.Controls.Add(this.productoTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaReporteVentasPorProductoDataGridView);
            this.Name = "Form2";
            this.Text = "Ventas por Producto";
            ((System.ComponentModel.ISupportInitialize)(this.listaReporteVentasPorProductoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaReporteVentasPorProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaReporteVentasPorProductoBindingSource;
        private System.Windows.Forms.DataGridView listaReporteVentasPorProductoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}