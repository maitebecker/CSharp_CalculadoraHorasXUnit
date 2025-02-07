using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
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

        private static bool EhHoraValida(string hora)
        {
            // Verifica se há exatamente um ":" separando horas e minutos
            string[] partes = hora.Split(':');
            if (partes.Length != 2) return false;

            // Tenta converter as partes para números inteiros
            if (int.TryParse(partes[0], out int horas) && int.TryParse(partes[1], out int minutos))
            {
                return horas >= 0 && minutos >= 0 && minutos < 60;
            }

            return false;
        }

        private static TimeSpan ConverterHora(string hora)
        {
            string[] partes = hora.Split(':');
            int horas = int.Parse(partes[0]);  // Permite horas maiores que 24
            int minutos = int.Parse(partes[1]); // Mantém os minutos corretos
            return TimeSpan.FromHours(horas) + TimeSpan.FromMinutes(minutos);
        }

        private string FormatarResultado(TimeSpan resultado)
        {
            int horasTotais = (int)resultado.TotalHours;
            return $"{horasTotais:D2}:{resultado.Minutes:D2}";
        }

        public string Somar(string hora1, string hora2)
        {
            if (!EhHoraValida(hora1) || !EhHoraValida(hora2))
            {
                return "Erro: Formato inválido. Use HH:mm.";
            }
            TimeSpan horario1 = ConverterHora(hora1);
            TimeSpan horario2 = ConverterHora(hora2);
            TimeSpan resultado = horario1.Add(horario2);
            string resultadoFormatado = FormatarResultado(resultado);
            listaHistorico.Insert(0, "Resultado: " + resultadoFormatado + " - Data: " + data);

            return resultadoFormatado;
        }

        public string Subtrair(string hora1, string hora2)
        {
            if (!EhHoraValida(hora1) || !EhHoraValida(hora2))
            {
                return "Erro: Formato inválido. Use HH:mm.";
            }
            TimeSpan horario1 = ConverterHora(hora1);
            TimeSpan horario2 = ConverterHora(hora2);
            TimeSpan resultado = horario1.Subtract(horario2);

            if (resultado < TimeSpan.Zero)
            {
                return "Erro: Resultado negativo inválido.";
            }

            string resultadoFormatado = FormatarResultado(resultado);
            listaHistorico.Insert(0, "Resultado: " + resultadoFormatado + " - Data: " + data);

            return resultadoFormatado;
        }

        public string Divisao(string hora1, double divisor)
        {
            if (!EhHoraValida(hora1) || divisor == 0)
            {
                return "Erro: Formato inválido ou divisão por zero";
            }
            TimeSpan horario1 = ConverterHora(hora1);
            TimeSpan resultado = horario1.Divide(divisor);
            
            string resultadoFormatado = FormatarResultado(resultado);
            listaHistorico.Insert(0, "Resultado: " + resultadoFormatado + " - Data: " + data);

            return resultadoFormatado;
        }

        public string Multiplicacao(string hora1, double fator)
        {
            if (!EhHoraValida(hora1))
            {
                return "Erro: Formato inválido. Use HH:mm.";
            }
            TimeSpan horario1 = ConverterHora(hora1);
            TimeSpan resultado = horario1.Multiply(fator);

            string resultadoFormatado = FormatarResultado(resultado);
            listaHistorico.Insert(0, "Resultado: " + resultadoFormatado + " - Data: " + data);

            return resultadoFormatado;
        }

        //Mostra as últimas três operações
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
 }

