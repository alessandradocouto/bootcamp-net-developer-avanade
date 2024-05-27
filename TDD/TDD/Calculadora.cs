using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Calculadora
    {
        public int Value1;
        public int Value2;
        private List<string> _historic = new List<string>();
        public string Data;

        public Calculadora(string data, List<string> historic)
        {
            Data = data;
            _historic = historic;
        }

        public Calculadora(int value1, int value2, string data) {
            Value1 = value1;
            Value2 = value2;
            Data = data;
        }

        public Calculadora()
        {
        }


        // Para o TDD nao pode codificar antes de decodificar.
        public int Somar(int x, int y)
        {
            int result = x + y;

            _historic.Insert(0, $"Result: {result}");

            // Sempre retornar zerado ou vazio, seja um array, numero ou objeto.
            return result;
        }

        public int Subtrair(int x, int y)
        {
            int result = x - y;

            _historic.Insert(0, $"Result: {result}");

            // Sempre retornar zerado ou vazio, seja um array, numero ou objeto.
            return result;
        }

        public int Multiplicar(int x, int y)
        {
            int result = x * y;

            _historic.Insert(0, $"Result: {result}");

            // Sempre retornar zerado ou vazio, seja um array, numero ou objeto.
            return result;
        }


        public int Dividir(int x, int y)
        {
            int result = x / y;

            _historic.Insert(0, $"Result: {result}");

            // Sempre retornar zerado ou vazio, seja um array, numero ou objeto.
            return result;
        }

        // retorno do historico
        // Teste Extra: Quando ocorrer Exception: Assert.Throws<Exception>
        public List<string> Historic()
        {
            if (_historic.Count > 3)
            {
                _historic.RemoveRange(3, _historic.Count - 3);
            }

            return _historic;
        }


    }
}
