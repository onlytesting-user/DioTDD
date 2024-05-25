using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraConsole.Services
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;

        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        private string TextoExibido(int resultado)
        {
            return $"Res: {resultado} - Data: {data}";
        }

        public int Somar(int num1, int num2)
        {
            int operacao = num1 + num2;

            historico.Insert(0, TextoExibido(operacao));
            return operacao;
        }

        public int Subtrair(int num1, int num2)
        {
            int operacao = num1 - num2;

            historico.Insert(0, TextoExibido(operacao));
            return operacao;
        }

        public int Multiplicar(int num1, int num2)
        {
            int operacao = num1 * num2;

            historico.Insert(0, TextoExibido(operacao));
            return operacao;
        }

        public int Dividir(int num1, int num2)
        {
            int operacao = num1 / num2;

            historico.Insert(0, TextoExibido(operacao));
            return operacao;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}