/*

Computação Evolutiva - Algoritmo Genético Básico (Classe Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia
 
*/

using System;
using System.Windows.Forms;

namespace AlgoritmoGeneticoBasico{

    static class Program{

        [STAThread]
        static void Main(){

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
