/*

Computação Evolutiva - Algoritmo Genético Básico (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgoritmoGeneticoBasico{

    public partial class Form1 : Form{

        public Form1(){

            InitializeComponent();
        }

        public double funcao(double x){

            return 2 * double.Parse(tb_lim_superior.Text) - Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x))));
        }

        public void plotarFuncao(double lim_inferior, double lim_superior){

            double x = lim_inferior;

            while(x < lim_superior){

                chart_grafico.Series["Função"].Points.AddXY(x, funcao(x));
                x++;
            }
        }

        private void bt_executar_Click(object sender, EventArgs e){

            Genetica genetica = new Genetica();
            List<String> populacao = new List<String>();
            List<String> melhores = new List<String>();
            double melhor = 0;
            int qnt_geracoes = int.Parse(tb_qnt_geracoes.Text);

            chart_grafico.Series["Função"].Points.Clear();
            chart_grafico.Series["Melhores Pontos"].Points.Clear();

            genetica.setTamPopulacao(int.Parse(tb_tam_populacao.Text));
            genetica.setTamCromossomo(int.Parse(tb_tam_cromossomo.Text));
            genetica.setTxCruzamento(double.Parse(tb_tx_cruzamento.Text));
            genetica.setTxMutacao(double.Parse(tb_tx_mutacao.Text));
            genetica.setLimInferior(double.Parse(tb_lim_inferior.Text));
            genetica.setLimSuperior(double.Parse(tb_lim_superior.Text));
            genetica.setTxConversao();

            plotarFuncao(genetica.lim_inferior, genetica.lim_superior);

            populacao = genetica.gerarPopulacao();

            for(int i = 0; i < qnt_geracoes; i++){

                populacao = genetica.selecao(populacao);
                populacao = genetica.cruzamento(populacao);
                populacao = genetica.mutacao(populacao);

                melhores.Add(genetica.melhorIndividuo(populacao));
                melhor = genetica.obterValor(genetica.melhorIndividuo(populacao));

                chart_grafico.Series["Melhores Pontos"].Points.AddXY(melhor, funcao(melhor));
            }

            melhor = genetica.obterValor(genetica.melhorIndividuo(melhores));

            tb_melhor_x.Text = melhor.ToString();
            tb_melhor_f.Text = (funcao(melhor) - 2 * double.Parse(tb_lim_superior.Text)).ToString();
        }
    }
}