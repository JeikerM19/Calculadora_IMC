// using System;

namespace MiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora(75, 1.75);
            calculadora.CalcularCondicionPeso();
        }
    }

    class Calculadora
    {
        double peso;
        double altura;
        // --- DEFINICIÓN DEL CONSTRUCTOR ---
        public Calculadora(double peso, double altura)
        {
            // El constructor recibe datos y los asigna a las variables de la clase
            this.peso = peso;
            this.altura = altura;
        }
        public void CalcularCondicionPeso()
        {
            var imc = CalcularIMC(peso, altura);
            if (imc < 18.5)
            {
                Console.WriteLine("Estado: Bajo peso");
            }
            else if(imc < 25)
            {
                Console.WriteLine("Estado: Peso normal");
            }
            else
            {
                Console.WriteLine("Estado: Sobrepreso");
            }
        }
        private static double CalcularIMC(double peso, double altura)
        {
            return peso/(altura*altura);
        }
    }
}


//Metodo corto:
// var calculadora = new Calculadora(75, 1.75);
// calculadora.MostrarCondicion();

// class Calculadora(double peso, double altura)
// {
//     public void MostrarCondicion()
//     {
//         string estado = CalcularIMC() switch
//         {
//             < 18.5 => "Bajo peso",
//             < 25   => "Peso normal",
//             _      => "Sobrepeso"
//         };

//         Console.WriteLine($"Estado: {estado}");
//     }
//     private double CalcularIMC() => peso / (altura * altura);
// }