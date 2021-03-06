﻿namespace TP4
{
    partial class Principal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.txt_cant_iteraciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_costo_falt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_costo_alm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stock_inicial = new System.Windows.Forms.TextBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.tb_simulaciones = new System.Windows.Forms.DataGridView();
            this.col_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stock_rem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_costo_alm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_costo_falt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_costo_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_costo_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_costo_acum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_costo_prom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dias_prox_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dias_demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mostrar_desde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mostrar_cant = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_res_C = new System.Windows.Forms.TextBox();
            this.txt_res_B = new System.Windows.Forms.TextBox();
            this.txt_res_A = new System.Windows.Forms.TextBox();
            this.rad_C = new System.Windows.Forms.RadioButton();
            this.rad_B = new System.Windows.Forms.RadioButton();
            this.rad_A = new System.Windows.Forms.RadioButton();
            this.lnk_C = new System.Windows.Forms.LinkLabel();
            this.lnk_B = new System.Windows.Forms.LinkLabel();
            this.lnk_A = new System.Windows.Forms.LinkLabel();
            this.btn_comparar = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tb_simulaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cant_iteraciones
            // 
            this.txt_cant_iteraciones.Location = new System.Drawing.Point(133, 20);
            this.txt_cant_iteraciones.Name = "txt_cant_iteraciones";
            this.txt_cant_iteraciones.Size = new System.Drawing.Size(36, 20);
            this.txt_cant_iteraciones.TabIndex = 0;
            this.txt_cant_iteraciones.Text = "120";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de iteraciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Costo faltante:";
            // 
            // txt_costo_falt
            // 
            this.txt_costo_falt.Location = new System.Drawing.Point(129, 72);
            this.txt_costo_falt.Name = "txt_costo_falt";
            this.txt_costo_falt.Size = new System.Drawing.Size(36, 20);
            this.txt_costo_falt.TabIndex = 2;
            this.txt_costo_falt.Text = "-10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Costo almacenamiento:";
            // 
            // txt_costo_alm
            // 
            this.txt_costo_alm.Location = new System.Drawing.Point(129, 46);
            this.txt_costo_alm.Name = "txt_costo_alm";
            this.txt_costo_alm.Size = new System.Drawing.Size(36, 20);
            this.txt_costo_alm.TabIndex = 4;
            this.txt_costo_alm.Text = "-3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock inicial:";
            // 
            // txt_stock_inicial
            // 
            this.txt_stock_inicial.Location = new System.Drawing.Point(129, 20);
            this.txt_stock_inicial.Name = "txt_stock_inicial";
            this.txt_stock_inicial.Size = new System.Drawing.Size(36, 20);
            this.txt_stock_inicial.TabIndex = 6;
            this.txt_stock_inicial.Text = "20";
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(661, 30);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(75, 23);
            this.btn_simular.TabIndex = 8;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // tb_simulaciones
            // 
            this.tb_simulaciones.AllowUserToAddRows = false;
            this.tb_simulaciones.AllowUserToDeleteRows = false;
            this.tb_simulaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_simulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_simulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dia,
            this.col_demanda,
            this.col_ventas,
            this.col_stock_rem,
            this.col_costo_alm,
            this.col_costo_falt,
            this.col_costo_pedido,
            this.col_costo_total,
            this.col_costo_acum,
            this.col_costo_prom,
            this.col_dias_prox_pedido,
            this.col_dias_demora,
            this.col_pedido});
            this.tb_simulaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_simulaciones.Location = new System.Drawing.Point(0, 129);
            this.tb_simulaciones.Name = "tb_simulaciones";
            this.tb_simulaciones.ReadOnly = true;
            this.tb_simulaciones.Size = new System.Drawing.Size(1354, 270);
            this.tb_simulaciones.TabIndex = 9;
            // 
            // col_dia
            // 
            this.col_dia.HeaderText = "Día";
            this.col_dia.Name = "col_dia";
            this.col_dia.ReadOnly = true;
            // 
            // col_demanda
            // 
            this.col_demanda.HeaderText = "Demanda";
            this.col_demanda.Name = "col_demanda";
            this.col_demanda.ReadOnly = true;
            // 
            // col_ventas
            // 
            this.col_ventas.HeaderText = "Ventas";
            this.col_ventas.Name = "col_ventas";
            this.col_ventas.ReadOnly = true;
            // 
            // col_stock_rem
            // 
            this.col_stock_rem.HeaderText = "Stock Remanente";
            this.col_stock_rem.Name = "col_stock_rem";
            this.col_stock_rem.ReadOnly = true;
            // 
            // col_costo_alm
            // 
            this.col_costo_alm.HeaderText = "Costo Almacenamiento";
            this.col_costo_alm.Name = "col_costo_alm";
            this.col_costo_alm.ReadOnly = true;
            // 
            // col_costo_falt
            // 
            this.col_costo_falt.HeaderText = "Costo Faltante";
            this.col_costo_falt.Name = "col_costo_falt";
            this.col_costo_falt.ReadOnly = true;
            // 
            // col_costo_pedido
            // 
            this.col_costo_pedido.HeaderText = "Costo Pedido";
            this.col_costo_pedido.Name = "col_costo_pedido";
            this.col_costo_pedido.ReadOnly = true;
            // 
            // col_costo_total
            // 
            this.col_costo_total.HeaderText = "Costo Total";
            this.col_costo_total.Name = "col_costo_total";
            this.col_costo_total.ReadOnly = true;
            // 
            // col_costo_acum
            // 
            this.col_costo_acum.HeaderText = "Costo Acumulado";
            this.col_costo_acum.Name = "col_costo_acum";
            this.col_costo_acum.ReadOnly = true;
            // 
            // col_costo_prom
            // 
            this.col_costo_prom.HeaderText = "Costo Promedio";
            this.col_costo_prom.Name = "col_costo_prom";
            this.col_costo_prom.ReadOnly = true;
            // 
            // col_dias_prox_pedido
            // 
            this.col_dias_prox_pedido.HeaderText = "Días hasta el próximo pedido";
            this.col_dias_prox_pedido.Name = "col_dias_prox_pedido";
            this.col_dias_prox_pedido.ReadOnly = true;
            // 
            // col_dias_demora
            // 
            this.col_dias_demora.HeaderText = "Demora";
            this.col_dias_demora.Name = "col_dias_demora";
            this.col_dias_demora.ReadOnly = true;
            // 
            // col_pedido
            // 
            this.col_pedido.HeaderText = "Pedido";
            this.col_pedido.Name = "col_pedido";
            this.col_pedido.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_stock_inicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_costo_alm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_costo_falt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 107);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros iniciales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_mostrar_desde);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_mostrar_cant);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_cant_iteraciones);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 107);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Iteraciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mostrar desde:";
            // 
            // txt_mostrar_desde
            // 
            this.txt_mostrar_desde.Location = new System.Drawing.Point(133, 46);
            this.txt_mostrar_desde.Name = "txt_mostrar_desde";
            this.txt_mostrar_desde.Size = new System.Drawing.Size(36, 20);
            this.txt_mostrar_desde.TabIndex = 4;
            this.txt_mostrar_desde.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cantidad a mostrar:";
            // 
            // txt_mostrar_cant
            // 
            this.txt_mostrar_cant.Location = new System.Drawing.Point(133, 72);
            this.txt_mostrar_cant.Name = "txt_mostrar_cant";
            this.txt_mostrar_cant.Size = new System.Drawing.Size(36, 20);
            this.txt_mostrar_cant.TabIndex = 2;
            this.txt_mostrar_cant.Text = "10";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_res_C);
            this.groupBox3.Controls.Add(this.txt_res_B);
            this.groupBox3.Controls.Add(this.txt_res_A);
            this.groupBox3.Controls.Add(this.rad_C);
            this.groupBox3.Controls.Add(this.rad_B);
            this.groupBox3.Controls.Add(this.rad_A);
            this.groupBox3.Controls.Add(this.lnk_C);
            this.groupBox3.Controls.Add(this.lnk_B);
            this.groupBox3.Controls.Add(this.lnk_A);
            this.groupBox3.Location = new System.Drawing.Point(435, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 107);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estrategias";
            // 
            // txt_res_C
            // 
            this.txt_res_C.Enabled = false;
            this.txt_res_C.Location = new System.Drawing.Point(114, 72);
            this.txt_res_C.Name = "txt_res_C";
            this.txt_res_C.Size = new System.Drawing.Size(80, 20);
            this.txt_res_C.TabIndex = 8;
            // 
            // txt_res_B
            // 
            this.txt_res_B.Enabled = false;
            this.txt_res_B.Location = new System.Drawing.Point(114, 46);
            this.txt_res_B.Name = "txt_res_B";
            this.txt_res_B.Size = new System.Drawing.Size(80, 20);
            this.txt_res_B.TabIndex = 7;
            // 
            // txt_res_A
            // 
            this.txt_res_A.Enabled = false;
            this.txt_res_A.Location = new System.Drawing.Point(114, 20);
            this.txt_res_A.Name = "txt_res_A";
            this.txt_res_A.Size = new System.Drawing.Size(80, 20);
            this.txt_res_A.TabIndex = 6;
            // 
            // rad_C
            // 
            this.rad_C.AutoSize = true;
            this.rad_C.Location = new System.Drawing.Point(94, 75);
            this.rad_C.Name = "rad_C";
            this.rad_C.Size = new System.Drawing.Size(14, 13);
            this.rad_C.TabIndex = 5;
            this.rad_C.TabStop = true;
            this.rad_C.UseVisualStyleBackColor = true;
            // 
            // rad_B
            // 
            this.rad_B.AutoSize = true;
            this.rad_B.Location = new System.Drawing.Point(94, 49);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(14, 13);
            this.rad_B.TabIndex = 4;
            this.rad_B.TabStop = true;
            this.rad_B.UseVisualStyleBackColor = true;
            // 
            // rad_A
            // 
            this.rad_A.AutoSize = true;
            this.rad_A.Location = new System.Drawing.Point(94, 23);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(14, 13);
            this.rad_A.TabIndex = 3;
            this.rad_A.TabStop = true;
            this.rad_A.UseVisualStyleBackColor = true;
            // 
            // lnk_C
            // 
            this.lnk_C.AutoSize = true;
            this.lnk_C.Location = new System.Drawing.Point(20, 75);
            this.lnk_C.Name = "lnk_C";
            this.lnk_C.Size = new System.Drawing.Size(67, 13);
            this.lnk_C.TabIndex = 2;
            this.lnk_C.TabStop = true;
            this.lnk_C.Text = "Estrategia C:";
            this.lnk_C.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_C_LinkClicked);
            // 
            // lnk_B
            // 
            this.lnk_B.AutoSize = true;
            this.lnk_B.Location = new System.Drawing.Point(20, 49);
            this.lnk_B.Name = "lnk_B";
            this.lnk_B.Size = new System.Drawing.Size(67, 13);
            this.lnk_B.TabIndex = 1;
            this.lnk_B.TabStop = true;
            this.lnk_B.Text = "Estrategia B:";
            this.lnk_B.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_B_LinkClicked);
            // 
            // lnk_A
            // 
            this.lnk_A.AutoSize = true;
            this.lnk_A.Location = new System.Drawing.Point(20, 23);
            this.lnk_A.Name = "lnk_A";
            this.lnk_A.Size = new System.Drawing.Size(67, 13);
            this.lnk_A.TabIndex = 0;
            this.lnk_A.TabStop = true;
            this.lnk_A.Text = "Estrategia A:";
            this.lnk_A.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_A_LinkClicked);
            // 
            // btn_comparar
            // 
            this.btn_comparar.Location = new System.Drawing.Point(661, 82);
            this.btn_comparar.Name = "btn_comparar";
            this.btn_comparar.Size = new System.Drawing.Size(75, 23);
            this.btn_comparar.TabIndex = 14;
            this.btn_comparar.Text = "Comparar";
            this.btn_comparar.UseVisualStyleBackColor = true;
            this.btn_comparar.Click += new System.EventHandler(this.btn_comparar_Click);
            // 
            // graph
            // 
            chartArea4.Name = "CostoPromedio";
            this.graph.ChartAreas.Add(chartArea4);
            this.graph.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend4.Name = "Legend1";
            this.graph.Legends.Add(legend4);
            this.graph.Location = new System.Drawing.Point(0, 399);
            this.graph.Name = "graph";
            series10.BorderWidth = 2;
            series10.ChartArea = "CostoPromedio";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Legend = "Legend1";
            series10.Name = "Estrategia A";
            series11.BorderWidth = 2;
            series11.ChartArea = "CostoPromedio";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Legend = "Legend1";
            series11.Name = "Estrategia B";
            series12.BorderWidth = 2;
            series12.ChartArea = "CostoPromedio";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Legend = "Legend1";
            series12.Name = "Estrategia C";
            this.graph.Series.Add(series10);
            this.graph.Series.Add(series11);
            this.graph.Series.Add(series12);
            this.graph.Size = new System.Drawing.Size(1354, 268);
            this.graph.TabIndex = 15;
            this.graph.Text = "chart1";
            title4.Name = "Costo Diario Promedio";
            this.graph.Titles.Add(title4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1354, 129);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 667);
            this.Controls.Add(this.tb_simulaciones);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.btn_comparar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Principal";
            this.Text = "De Franceschi Andrea 62127 - García Majorel Álvaro 61856 - García Reyna Facundo 6" +
    "3583 - Oliveda Claudio 49594 - Varela Sofía 65126";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tb_simulaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cant_iteraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_costo_falt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_costo_alm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stock_inicial;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.DataGridView tb_simulaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stock_rem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_costo_alm;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_costo_falt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_costo_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_costo_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_costo_acum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_costo_prom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dias_prox_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dias_demora;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mostrar_desde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mostrar_cant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_res_C;
        private System.Windows.Forms.TextBox txt_res_B;
        private System.Windows.Forms.TextBox txt_res_A;
        private System.Windows.Forms.RadioButton rad_C;
        private System.Windows.Forms.RadioButton rad_B;
        private System.Windows.Forms.RadioButton rad_A;
        private System.Windows.Forms.LinkLabel lnk_C;
        private System.Windows.Forms.LinkLabel lnk_B;
        private System.Windows.Forms.LinkLabel lnk_A;
        private System.Windows.Forms.Button btn_comparar;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

