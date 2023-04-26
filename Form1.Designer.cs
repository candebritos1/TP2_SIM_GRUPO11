
namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rd_Uniforme = new System.Windows.Forms.RadioButton();
            this.rd_Normal = new System.Windows.Forms.RadioButton();
            this.rd_ExponencialNegativa = new System.Windows.Forms.RadioButton();
            this.rd_Poisson = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UniformeMinimo = new System.Windows.Forms.TextBox();
            this.txt_UniformeMaximo = new System.Windows.Forms.TextBox();
            this.txt_NormalPromedio = new System.Windows.Forms.TextBox();
            this.txt_NormalDesviacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ExponencialLambda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PoissonLambda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_muestra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_intervalos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Lista_Randoms = new System.Windows.Forms.ListBox();
            this.dgv_Histograma = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_chiCuadrado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_boxMuller = new System.Windows.Forms.CheckBox();
            this.chk_convolucion = new System.Windows.Forms.CheckBox();
            this.lbl_chi = new System.Windows.Forms.Label();
            this.labelGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Histograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_Uniforme
            // 
            this.rd_Uniforme.AutoSize = true;
            this.rd_Uniforme.Location = new System.Drawing.Point(17, 16);
            this.rd_Uniforme.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Uniforme.Name = "rd_Uniforme";
            this.rd_Uniforme.Size = new System.Drawing.Size(86, 21);
            this.rd_Uniforme.TabIndex = 0;
            this.rd_Uniforme.Text = "Uniforme";
            this.rd_Uniforme.UseVisualStyleBackColor = true;
            this.rd_Uniforme.Click += new System.EventHandler(this.rd_Uniforme_Click);
            // 
            // rd_Normal
            // 
            this.rd_Normal.AutoSize = true;
            this.rd_Normal.Location = new System.Drawing.Point(139, 16);
            this.rd_Normal.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Normal.Name = "rd_Normal";
            this.rd_Normal.Size = new System.Drawing.Size(74, 21);
            this.rd_Normal.TabIndex = 1;
            this.rd_Normal.Text = "Normal";
            this.rd_Normal.UseVisualStyleBackColor = true;
            this.rd_Normal.Click += new System.EventHandler(this.rd_Normal_Click);
            // 
            // rd_ExponencialNegativa
            // 
            this.rd_ExponencialNegativa.AutoSize = true;
            this.rd_ExponencialNegativa.Location = new System.Drawing.Point(260, 16);
            this.rd_ExponencialNegativa.Margin = new System.Windows.Forms.Padding(4);
            this.rd_ExponencialNegativa.Name = "rd_ExponencialNegativa";
            this.rd_ExponencialNegativa.Size = new System.Drawing.Size(165, 21);
            this.rd_ExponencialNegativa.TabIndex = 2;
            this.rd_ExponencialNegativa.Text = "Exponencial Negativa";
            this.rd_ExponencialNegativa.UseVisualStyleBackColor = true;
            this.rd_ExponencialNegativa.Click += new System.EventHandler(this.rd_ExponencialNegativa_Click);
            // 
            // rd_Poisson
            // 
            this.rd_Poisson.AutoSize = true;
            this.rd_Poisson.Location = new System.Drawing.Point(440, 17);
            this.rd_Poisson.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Poisson.Name = "rd_Poisson";
            this.rd_Poisson.Size = new System.Drawing.Size(79, 21);
            this.rd_Poisson.TabIndex = 3;
            this.rd_Poisson.Text = "Poisson";
            this.rd_Poisson.UseVisualStyleBackColor = true;
            this.rd_Poisson.Click += new System.EventHandler(this.rd_Poisson_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maximo";
            // 
            // txt_UniformeMinimo
            // 
            this.txt_UniformeMinimo.Location = new System.Drawing.Point(156, 48);
            this.txt_UniformeMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UniformeMinimo.Name = "txt_UniformeMinimo";
            this.txt_UniformeMinimo.Size = new System.Drawing.Size(132, 22);
            this.txt_UniformeMinimo.TabIndex = 6;
            // 
            // txt_UniformeMaximo
            // 
            this.txt_UniformeMaximo.Location = new System.Drawing.Point(156, 81);
            this.txt_UniformeMaximo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UniformeMaximo.Name = "txt_UniformeMaximo";
            this.txt_UniformeMaximo.Size = new System.Drawing.Size(132, 22);
            this.txt_UniformeMaximo.TabIndex = 7;
            // 
            // txt_NormalPromedio
            // 
            this.txt_NormalPromedio.Location = new System.Drawing.Point(156, 81);
            this.txt_NormalPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NormalPromedio.Name = "txt_NormalPromedio";
            this.txt_NormalPromedio.Size = new System.Drawing.Size(132, 22);
            this.txt_NormalPromedio.TabIndex = 11;
            // 
            // txt_NormalDesviacion
            // 
            this.txt_NormalDesviacion.Location = new System.Drawing.Point(156, 48);
            this.txt_NormalDesviacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NormalDesviacion.Name = "txt_NormalDesviacion";
            this.txt_NormalDesviacion.Size = new System.Drawing.Size(132, 22);
            this.txt_NormalDesviacion.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Media";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desviacion";
            // 
            // txt_ExponencialLambda
            // 
            this.txt_ExponencialLambda.Location = new System.Drawing.Point(156, 48);
            this.txt_ExponencialLambda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ExponencialLambda.Name = "txt_ExponencialLambda";
            this.txt_ExponencialLambda.Size = new System.Drawing.Size(132, 22);
            this.txt_ExponencialLambda.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lambda";
            // 
            // txt_PoissonLambda
            // 
            this.txt_PoissonLambda.Location = new System.Drawing.Point(156, 48);
            this.txt_PoissonLambda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PoissonLambda.Name = "txt_PoissonLambda";
            this.txt_PoissonLambda.Size = new System.Drawing.Size(132, 22);
            this.txt_PoissonLambda.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lambda o Media";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(21, 187);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(100, 28);
            this.btn_generar.TabIndex = 19;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_muestra
            // 
            this.txt_muestra.Location = new System.Drawing.Point(83, 129);
            this.txt_muestra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_muestra.Name = "txt_muestra";
            this.txt_muestra.Size = new System.Drawing.Size(132, 22);
            this.txt_muestra.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Muestra";
            // 
            // cmb_intervalos
            // 
            this.cmb_intervalos.FormattingEnabled = true;
            this.cmb_intervalos.Items.AddRange(new object[] {
            "8",
            "10",
            "15",
            "20"});
            this.cmb_intervalos.Location = new System.Drawing.Point(321, 128);
            this.cmb_intervalos.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_intervalos.Name = "cmb_intervalos";
            this.cmb_intervalos.Size = new System.Drawing.Size(160, 24);
            this.cmb_intervalos.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Intervalos";
            // 
            // Lista_Randoms
            // 
            this.Lista_Randoms.FormattingEnabled = true;
            this.Lista_Randoms.ItemHeight = 16;
            this.Lista_Randoms.Location = new System.Drawing.Point(16, 240);
            this.Lista_Randoms.Margin = new System.Windows.Forms.Padding(4);
            this.Lista_Randoms.Name = "Lista_Randoms";
            this.Lista_Randoms.Size = new System.Drawing.Size(155, 372);
            this.Lista_Randoms.TabIndex = 24;
            // 
            // dgv_Histograma
            // 
            this.dgv_Histograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Histograma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgv_Histograma.Location = new System.Drawing.Point(222, 175);
            this.dgv_Histograma.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Histograma.Name = "dgv_Histograma";
            this.dgv_Histograma.RowHeadersWidth = 51;
            this.dgv_Histograma.Size = new System.Drawing.Size(708, 428);
            this.dgv_Histograma.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Limite Inferior";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Limite Superior";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca de Clase";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Frecuencia Observada";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Frecuencia Esperada";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Frecu Obs AC";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Frecu Esp AC";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Chi Cuad C";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "C ACUM";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // histograma
            // 
            chartArea1.Name = "ChartArea1";
            this.histograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histograma.Legends.Add(legend1);
            this.histograma.Location = new System.Drawing.Point(982, 133);
            this.histograma.Margin = new System.Windows.Forms.Padding(4);
            this.histograma.Name = "histograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histograma.Series.Add(series1);
            this.histograma.Size = new System.Drawing.Size(636, 482);
            this.histograma.TabIndex = 26;
            this.histograma.Text = "chart1";
            // 
            // txt_chiCuadrado
            // 
            this.txt_chiCuadrado.Enabled = false;
            this.txt_chiCuadrado.Location = new System.Drawing.Point(312, 640);
            this.txt_chiCuadrado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chiCuadrado.Name = "txt_chiCuadrado";
            this.txt_chiCuadrado.Size = new System.Drawing.Size(132, 22);
            this.txt_chiCuadrado.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 644);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Valor Chi Tabulado";
            // 
            // chk_boxMuller
            // 
            this.chk_boxMuller.AutoSize = true;
            this.chk_boxMuller.Checked = true;
            this.chk_boxMuller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_boxMuller.Location = new System.Drawing.Point(357, 52);
            this.chk_boxMuller.Margin = new System.Windows.Forms.Padding(4);
            this.chk_boxMuller.Name = "chk_boxMuller";
            this.chk_boxMuller.Size = new System.Drawing.Size(95, 21);
            this.chk_boxMuller.TabIndex = 32;
            this.chk_boxMuller.Text = "Box Muller";
            this.chk_boxMuller.UseVisualStyleBackColor = true;
            this.chk_boxMuller.Click += new System.EventHandler(this.chk_boxMuller_Click);
            // 
            // chk_convolucion
            // 
            this.chk_convolucion.AutoSize = true;
            this.chk_convolucion.Location = new System.Drawing.Point(357, 80);
            this.chk_convolucion.Margin = new System.Windows.Forms.Padding(4);
            this.chk_convolucion.Name = "chk_convolucion";
            this.chk_convolucion.Size = new System.Drawing.Size(107, 21);
            this.chk_convolucion.TabIndex = 33;
            this.chk_convolucion.Text = "Convolucion";
            this.chk_convolucion.UseVisualStyleBackColor = true;
            this.chk_convolucion.Click += new System.EventHandler(this.chk_convolucion_Click);
            // 
            // lbl_chi
            // 
            this.lbl_chi.AutoSize = true;
            this.lbl_chi.Location = new System.Drawing.Point(468, 644);
            this.lbl_chi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_chi.Name = "lbl_chi";
            this.lbl_chi.Size = new System.Drawing.Size(54, 17);
            this.lbl_chi.TabIndex = 34;
            this.lbl_chi.Text = "label10";
            this.lbl_chi.Visible = false;
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Location = new System.Drawing.Point(1405, 51);
            this.labelGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(75, 17);
            this.labelGrupo.TabIndex = 35;
            this.labelGrupo.Text = "Grupo Nro";
            this.labelGrupo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 777);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.lbl_chi);
            this.Controls.Add(this.chk_convolucion);
            this.Controls.Add(this.chk_boxMuller);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_chiCuadrado);
            this.Controls.Add(this.histograma);
            this.Controls.Add(this.dgv_Histograma);
            this.Controls.Add(this.Lista_Randoms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_intervalos);
            this.Controls.Add(this.txt_muestra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_PoissonLambda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ExponencialLambda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NormalPromedio);
            this.Controls.Add(this.txt_NormalDesviacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_UniformeMaximo);
            this.Controls.Add(this.txt_UniformeMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rd_Poisson);
            this.Controls.Add(this.rd_ExponencialNegativa);
            this.Controls.Add(this.rd_Normal);
            this.Controls.Add(this.rd_Uniforme);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Trabajo Practico 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Histograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_Uniforme;
        private System.Windows.Forms.RadioButton rd_Normal;
        private System.Windows.Forms.RadioButton rd_ExponencialNegativa;
        private System.Windows.Forms.RadioButton rd_Poisson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UniformeMinimo;
        private System.Windows.Forms.TextBox txt_UniformeMaximo;
        private System.Windows.Forms.TextBox txt_NormalPromedio;
        private System.Windows.Forms.TextBox txt_NormalDesviacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ExponencialLambda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PoissonLambda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_muestra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_intervalos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Lista_Randoms;
        private System.Windows.Forms.DataGridView dgv_Histograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart histograma;
        private System.Windows.Forms.TextBox txt_chiCuadrado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_boxMuller;
        private System.Windows.Forms.CheckBox chk_convolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Label lbl_chi;
        private System.Windows.Forms.Label labelGrupo;
    }
}

