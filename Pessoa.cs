using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula73_WF_IMC
{
    internal class Pessoa
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Imc { get; set; }

        public void CalculaIMC()
        {
            Imc = Peso / (Altura * Altura);
                       
        }

        public string StatusImc()
        {
            if (Imc < 18.5)
            {
                return $"IMC = {Imc} - ABAIXO DO PESO ";
            }
            else if (Imc >= 18.5 && Imc <= 24.9)
            {
                return $"IMC = {Imc} - PESO NORMAL ";
            }
            else if (Imc >= 25 && Imc <= 29.9)
            {
                return $"IMC = {Imc} - SOBREPESO ";
            }
            else if (Imc >= 30 && Imc <= 34.9)
            {
                return $"IMC = {Imc} - OBESIDADE GRAU I ";
            }
            else if (Imc >= 35 && Imc <= 39.9)
            {
                return $"IMC = {Imc} - OBESIDADE GRAU II ";
            }
            else
            {
                return $"IMC = {Imc} - OBESIDADE GRAU III / MÓRMIDA ";
            }
        }
    }
}
