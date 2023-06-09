﻿namespace FS11_ProjetoTestes
{
    public static class CalculadoraIMC
    {public static double Somar(double pNum, double sNum)
        {
            return (pNum + sNum);
        }


        public static string Calcular(double peso, double altura)
        {
            double resultado = peso / (altura * altura);

            if (resultado < 18.5)
            {
                return "texto";
            }

            if (resultado < 24.9)
            {
                return "Peso Normal";
            }

            if (resultado < 29.9)
            {
                return "Sobrepeso";
            }
            if (resultado < 34.9)
            {
                return "Obesidade Grau 1";
            }
            if (resultado < 39.9)
            {
                return "Obesidade Grau 2";
            }
            else
            {
                return "Obesidade Grau 3";
            }

        }
    }
}