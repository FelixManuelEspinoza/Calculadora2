namespace Calculadora2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Selector = new System.Windows.Forms.NumericUpDown();
            this.Btn_calcular = new System.Windows.Forms.Button();
            this.Btn_suma = new System.Windows.Forms.Button();
            this.Btn_resta = new System.Windows.Forms.Button();
            this.Btn_multiplicacion = new System.Windows.Forms.Button();
            this.Btn_divicion = new System.Windows.Forms.Button();
            this.Matris1 = new System.Windows.Forms.DataGridView();
            this.MatrisResultado = new System.Windows.Forms.DataGridView();
            this.Matris2 = new System.Windows.Forms.DataGridView();
            this.Btn_Llenar = new System.Windows.Forms.Button();
            this.Llenar_resultado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matris1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrisResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matris2)).BeginInit();
            this.SuspendLayout();
            // 
            // Selector
            // 
            this.Selector.Location = new System.Drawing.Point(12, 12);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(120, 23);
            this.Selector.TabIndex = 1;
            this.Selector.ValueChanged += new System.EventHandler(this.Selector_ValueChanged);
            // 
            // Btn_calcular
            // 
            this.Btn_calcular.Location = new System.Drawing.Point(138, 12);
            this.Btn_calcular.Name = "Btn_calcular";
            this.Btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.Btn_calcular.TabIndex = 2;
            this.Btn_calcular.Text = "Calcular";
            this.Btn_calcular.UseVisualStyleBackColor = true;
            this.Btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            // 
            // Btn_suma
            // 
            this.Btn_suma.Location = new System.Drawing.Point(300, 12);
            this.Btn_suma.Name = "Btn_suma";
            this.Btn_suma.Size = new System.Drawing.Size(75, 23);
            this.Btn_suma.TabIndex = 4;
            this.Btn_suma.Text = "Suma";
            this.Btn_suma.UseVisualStyleBackColor = true;
            this.Btn_suma.Click += new System.EventHandler(this.Btn_suma_Click);
            // 
            // Btn_resta
            // 
            this.Btn_resta.Location = new System.Drawing.Point(381, 12);
            this.Btn_resta.Name = "Btn_resta";
            this.Btn_resta.Size = new System.Drawing.Size(75, 23);
            this.Btn_resta.TabIndex = 5;
            this.Btn_resta.Text = "Resta";
            this.Btn_resta.UseVisualStyleBackColor = true;
            this.Btn_resta.Click += new System.EventHandler(this.Btn_resta_Click);
            // 
            // Btn_multiplicacion
            // 
            this.Btn_multiplicacion.Location = new System.Drawing.Point(462, 12);
            this.Btn_multiplicacion.Name = "Btn_multiplicacion";
            this.Btn_multiplicacion.Size = new System.Drawing.Size(75, 23);
            this.Btn_multiplicacion.TabIndex = 6;
            this.Btn_multiplicacion.Text = "Multiplicacion";
            this.Btn_multiplicacion.UseVisualStyleBackColor = true;
            this.Btn_multiplicacion.Click += new System.EventHandler(this.Btn_multiplicacion_Click);
            // 
            // Btn_divicion
            // 
            this.Btn_divicion.Location = new System.Drawing.Point(543, 12);
            this.Btn_divicion.Name = "Btn_divicion";
            this.Btn_divicion.Size = new System.Drawing.Size(75, 23);
            this.Btn_divicion.TabIndex = 7;
            this.Btn_divicion.Text = "Division";
            this.Btn_divicion.UseVisualStyleBackColor = true;
            this.Btn_divicion.Click += new System.EventHandler(this.Btn_divicion_Click);
            // 
            // Matris1
            // 
            this.Matris1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matris1.Location = new System.Drawing.Point(12, 99);
            this.Matris1.Name = "Matris1";
            this.Matris1.Size = new System.Drawing.Size(240, 150);
            this.Matris1.TabIndex = 8;
            // 
            // MatrisResultado
            // 
            this.MatrisResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrisResultado.Location = new System.Drawing.Point(271, 288);
            this.MatrisResultado.Name = "MatrisResultado";
            this.MatrisResultado.Size = new System.Drawing.Size(240, 150);
            this.MatrisResultado.TabIndex = 10;
            this.MatrisResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatrisResultado_CellContentClick);
            // 
            // Matris2
            // 
            this.Matris2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matris2.Location = new System.Drawing.Point(533, 99);
            this.Matris2.Name = "Matris2";
            this.Matris2.Size = new System.Drawing.Size(240, 150);
            this.Matris2.TabIndex = 11;
            // 
            // Btn_Llenar
            // 
            this.Btn_Llenar.Location = new System.Drawing.Point(219, 10);
            this.Btn_Llenar.Name = "Btn_Llenar";
            this.Btn_Llenar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Llenar.TabIndex = 12;
            this.Btn_Llenar.Text = "Llenar";
            this.Btn_Llenar.UseVisualStyleBackColor = true;
            this.Btn_Llenar.Click += new System.EventHandler(this.Btn_Llenar_Click_1);
            // 
            // Llenar_resultado
            // 
            this.Llenar_resultado.Location = new System.Drawing.Point(517, 352);
            this.Llenar_resultado.Name = "Llenar_resultado";
            this.Llenar_resultado.Size = new System.Drawing.Size(136, 23);
            this.Llenar_resultado.TabIndex = 13;
            this.Llenar_resultado.Text = "Llenar Resultado";
            this.Llenar_resultado.UseVisualStyleBackColor = true;
            this.Llenar_resultado.Click += new System.EventHandler(this.Llenar_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Llenar_resultado);
            this.Controls.Add(this.Btn_Llenar);
            this.Controls.Add(this.Matris2);
            this.Controls.Add(this.MatrisResultado);
            this.Controls.Add(this.Matris1);
            this.Controls.Add(this.Btn_divicion);
            this.Controls.Add(this.Btn_multiplicacion);
            this.Controls.Add(this.Btn_resta);
            this.Controls.Add(this.Btn_suma);
            this.Controls.Add(this.Btn_calcular);
            this.Controls.Add(this.Selector);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matris1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrisResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matris2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown Selector;
        private Button Btn_calcular;
        private Button Btn_suma;
        private Button Btn_resta;
        private Button Btn_multiplicacion;
        private Button Btn_divicion;
        private DataGridView Matris1;
        private DataGridView MatrisResultado;
        private DataGridView Matris2;
        private Button Btn_Llenar;
        private Button Llenar_resultado;
    }
}