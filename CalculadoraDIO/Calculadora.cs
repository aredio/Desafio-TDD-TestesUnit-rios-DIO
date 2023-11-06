using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CalculadoraDIO
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;
        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int somar(int n1, int n2)
        {
            int soma = n1 + n2;
            listaHistorico.Insert(0, "Res: " + soma + " - Data: "+data);
            return soma;
        }
        public int subtrair(int n1, int n2)
        {
            int subtracao = n1 - n2;
            listaHistorico.Insert(0, "Res: " + subtracao + " - Data: " + data);
            return subtracao;
        }
        public int dividir(int n1, int n2)
        {
            int divisao = n1 / n2;
            listaHistorico.Insert(0, "Res: " + divisao + " - Data: " + data);
            return divisao;
        }
        public int multiplicar(int n1, int n2)
        {
            int multiplicacao = n1 * n2;
            listaHistorico.Insert(0, "Res: " + multiplicacao + " - Data: " + data);
            return multiplicacao;
        }
        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
