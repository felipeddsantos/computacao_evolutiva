/*

Computação Evolutiva - Algoritmo Genético Básico (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

namespace AlgoritmoGeneticoBasico
{

    partial class Form1{

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent(){
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bt_executar = new System.Windows.Forms.Button();
            this.tb_qnt_geracoes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tam_populacao = new System.Windows.Forms.TextBox();
            this.tb_tx_cruzamento = new System.Windows.Forms.TextBox();
            this.tb_tx_mutacao = new System.Windows.Forms.TextBox();
            this.tb_tam_cromossomo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_lim_inferior = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_lim_superior = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chart_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_melhor_f = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_melhor_x = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_executar
            // 
            this.bt_executar.Location = new System.Drawing.Point(100, 311);
            this.bt_executar.Name = "bt_executar";
            this.bt_executar.Size = new System.Drawing.Size(110, 36);
            this.bt_executar.TabIndex = 0;
            this.bt_executar.Text = "Executar";
            this.bt_executar.UseVisualStyleBackColor = true;
            this.bt_executar.Click += new System.EventHandler(this.bt_executar_Click);
            // 
            // tb_qnt_geracoes
            // 
            this.tb_qnt_geracoes.Location = new System.Drawing.Point(195, 12);
            this.tb_qnt_geracoes.Name = "tb_qnt_geracoes";
            this.tb_qnt_geracoes.Size = new System.Drawing.Size(60, 20);
            this.tb_qnt_geracoes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taxa de cruzamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamanho da população:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade de gerações:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Taxa de mutação:";
            // 
            // tb_tam_populacao
            // 
            this.tb_tam_populacao.Location = new System.Drawing.Point(202, 54);
            this.tb_tam_populacao.Name = "tb_tam_populacao";
            this.tb_tam_populacao.Size = new System.Drawing.Size(60, 20);
            this.tb_tam_populacao.TabIndex = 6;
            // 
            // tb_tx_cruzamento
            // 
            this.tb_tx_cruzamento.Location = new System.Drawing.Point(170, 96);
            this.tb_tx_cruzamento.Name = "tb_tx_cruzamento";
            this.tb_tx_cruzamento.Size = new System.Drawing.Size(60, 20);
            this.tb_tx_cruzamento.TabIndex = 7;
            // 
            // tb_tx_mutacao
            // 
            this.tb_tx_mutacao.Location = new System.Drawing.Point(150, 138);
            this.tb_tx_mutacao.Name = "tb_tx_mutacao";
            this.tb_tx_mutacao.Size = new System.Drawing.Size(60, 20);
            this.tb_tx_mutacao.TabIndex = 8;
            // 
            // tb_tam_cromossomo
            // 
            this.tb_tam_cromossomo.Location = new System.Drawing.Point(210, 180);
            this.tb_tam_cromossomo.Name = "tb_tam_cromossomo";
            this.tb_tam_cromossomo.Size = new System.Drawing.Size(60, 20);
            this.tb_tam_cromossomo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tamanho do cromossomo:";
            // 
            // tb_lim_inferior
            // 
            this.tb_lim_inferior.Location = new System.Drawing.Point(187, 222);
            this.tb_lim_inferior.Name = "tb_lim_inferior";
            this.tb_lim_inferior.Size = new System.Drawing.Size(60, 20);
            this.tb_lim_inferior.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Limite inferior de busca:";
            // 
            // tb_lim_superior
            // 
            this.tb_lim_superior.Location = new System.Drawing.Point(200, 263);
            this.tb_lim_superior.Name = "tb_lim_superior";
            this.tb_lim_superior.Size = new System.Drawing.Size(60, 20);
            this.tb_lim_superior.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Limite superior de busca:";
            // 
            // chart_grafico
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_grafico.Legends.Add(legend2);
            this.chart_grafico.Location = new System.Drawing.Point(364, 12);
            this.chart_grafico.Name = "chart_grafico";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Função";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.LabelForeColor = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Melhores Pontos";
            this.chart_grafico.Series.Add(series3);
            this.chart_grafico.Series.Add(series4);
            this.chart_grafico.Size = new System.Drawing.Size(424, 300);
            this.chart_grafico.TabIndex = 15;
            this.chart_grafico.Text = "chart1";
            // 
            // tb_melhor_f
            // 
            this.tb_melhor_f.Location = new System.Drawing.Point(604, 382);
            this.tb_melhor_f.Name = "tb_melhor_f";
            this.tb_melhor_f.Size = new System.Drawing.Size(60, 20);
            this.tb_melhor_f.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "f(x) = ";
            // 
            // tb_melhor_x
            // 
            this.tb_melhor_x.Location = new System.Drawing.Point(590, 340);
            this.tb_melhor_x.Name = "tb_melhor_x";
            this.tb_melhor_x.Size = new System.Drawing.Size(74, 20);
            this.tb_melhor_x.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "x = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(404, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Melhor resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_melhor_f);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_melhor_x);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart_grafico);
            this.Controls.Add(this.tb_lim_superior);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_lim_inferior);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_tam_cromossomo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tx_mutacao);
            this.Controls.Add(this.tb_tx_cruzamento);
            this.Controls.Add(this.tb_tam_populacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_qnt_geracoes);
            this.Controls.Add(this.bt_executar);
            this.Name = "Form1";
            this.Text = "Algoritmo Genético Básico";
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_executar;
        private System.Windows.Forms.TextBox tb_qnt_geracoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tam_populacao;
        private System.Windows.Forms.TextBox tb_tx_cruzamento;
        private System.Windows.Forms.TextBox tb_tx_mutacao;
        private System.Windows.Forms.TextBox tb_tam_cromossomo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_lim_inferior;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_lim_superior;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafico;
        private System.Windows.Forms.TextBox tb_melhor_f;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_melhor_x;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}