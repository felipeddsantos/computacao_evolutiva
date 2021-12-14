/*

Computação Evolutiva - Algoritmo Genético Básico (Classe Genética)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

using System;
using System.Text;
using System.Collections.Generic;

namespace AlgoritmoGeneticoBasico{

    class Genetica{

        public int tam_populacao;
        public int tam_cromossomo;
        public double tx_cruzamento;
        public double tx_mutacao;
        public double lim_inferior;
        public double lim_superior;
        public double tx_conversao;

        public void setTamPopulacao(int _tam_populacao){

            tam_populacao = _tam_populacao;
        }

        public void setTamCromossomo(int _tam_cromossomo){

            tam_cromossomo = _tam_cromossomo;
        }

        public void setTxCruzamento(double _tx_cruzamento){

            tx_cruzamento = _tx_cruzamento;
        }

        public void setTxMutacao(double _tx_mutacao){

            tx_mutacao = _tx_mutacao;
        }

        public void setLimInferior(double _lim_inferior){

            lim_inferior = _lim_inferior;
        }

        public void setLimSuperior(double _lim_superior){

            lim_superior = _lim_superior;
        }

        public void setTxConversao(){

            tx_conversao = Math.Pow(2, tam_cromossomo) / Math.Abs(lim_superior - lim_inferior);
        }

        public double funcaoAptidao(double x){

            double f = 2 * lim_superior + (-Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))));

            return 1 / f;
        }

        public double obterValor(String individuo){

            double valor = 0;

            for(int i = 0; i < tam_cromossomo; i++){

                if(individuo[i] == '1')

                    valor += Math.Pow(2, i);
            }

            valor = valor / tx_conversao;

            if(valor > lim_superior)

                valor = lim_superior - valor;

            return valor;
        }

        public double aptidaoPopulacao(List<String> populacao){

            double aptidao = 0;

            for(int i = 0; i < populacao.Count; i++)

                aptidao += funcaoAptidao(obterValor(populacao[i]));

            return aptidao;
        }

        public List<double> frequenciaPopulacao(List<String> populacao){

            double aptidao = aptidaoPopulacao(populacao);
            List<double> frequencia = new List<double>();

            for(int i = 0; i < populacao.Count; i++)

                frequencia.Add(funcaoAptidao(obterValor(populacao[i])) / aptidao);

            return frequencia;
        }

        public List<double> obterRoleta(List<String> populacao){

            List<double> roleta = new List<double>();
            List<double> frequencia = frequenciaPopulacao(populacao);

            roleta.Add(frequencia[0]);

            for(int i = 1; i < populacao.Count; i++)

                roleta.Add(roleta[i - 1] + frequencia[i]);

            return roleta;
        }

        public String girarRoleta(List<String> populacao, List<double> roleta){

            Random random = new Random(Guid.NewGuid().GetHashCode());

            for(int i = 0; ; i++){

                if(random.NextDouble() <= roleta[i])

                    return populacao[i];
            }
        }

        public String melhorIndividuo(List<String> populacao){

            String melhor = populacao[0];

            for(int i = 1; i < populacao.Count; i++){

                if(funcaoAptidao(obterValor(populacao[i])) > funcaoAptidao(obterValor(melhor)))

                    melhor = populacao[i];
            }

            return melhor;
        }
               
        public List<String> gerarPopulacao(){

            Random random = new Random(Guid.NewGuid().GetHashCode());
            List<String> populacao = new List<String>();

            for(int i = 0; i < tam_populacao; i++){

                String individuo = "";

                for(int j = 0; j < tam_cromossomo; j++)

                    individuo += random.Next(2).ToString();

                populacao.Add(individuo);
            }

            return populacao;
        }

        public List<String> selecao(List<String> populacao){

            List<String> nova_populacao = new List<String>();
            List<double> roleta = obterRoleta(populacao);

            for(int i = 0; i < populacao.Count; i++)

                nova_populacao.Add(girarRoleta(populacao, roleta));

            return nova_populacao;
        }

        public List<String> cruzamento(List<String> populacao){

            Random random = new Random(Guid.NewGuid().GetHashCode());
            List<String> nova_populacao = new List<String>();

            for(int i = 0; i < populacao.Count / 2; i++){

                String pai = populacao[random.Next(tam_populacao)];
                String mae = populacao[random.Next(tam_populacao)];

                if(random.NextDouble() <= tx_cruzamento)
                
                    cruzamento(nova_populacao, pai, mae);
                
                else{

                    nova_populacao.Add(pai);
                    nova_populacao.Add(mae);
                }
            }

            return nova_populacao;
        }

        public void cruzamento(List<String> nova_populacao, String pai, String mae){

            Random random = new Random(Guid.NewGuid().GetHashCode());
            String filho1 = "";
            String filho2 = "";

            int corte = random.Next(1, tam_cromossomo);

            for(int i = 0; i < corte; i++){

                filho1 += pai[i];
                filho2 += mae[i];
            }

            for(int i = corte; i < tam_cromossomo; i++){

                filho1 += mae[i];
                filho2 += pai[i];
            }

            nova_populacao.Add(filho1);
            nova_populacao.Add(filho2);
        }

        public List<String> mutacao(List<String> populacao){

            Random random = new Random(Guid.NewGuid().GetHashCode());
            List<String> nova_populacao = new List<String>();

            for(int i = 0; i < populacao.Count; i++){

                if(random.NextDouble() <= tx_mutacao)

                    mutacao(populacao[i], nova_populacao);

                else

                    nova_populacao.Add(populacao[i]);
            }

            return nova_populacao;
        }

        public void mutacao(String individuo, List<String> nova_populacao){

            Random random = new Random(Guid.NewGuid().GetHashCode());
            StringBuilder novo_individuo = new StringBuilder(individuo);
            int posicao = random.Next(tam_cromossomo);
            
            if(individuo[posicao] == '1')

                novo_individuo[posicao] = '0';

            else

                novo_individuo[posicao] = '1';

            nova_populacao.Add(novo_individuo.ToString());
        }
    }
}