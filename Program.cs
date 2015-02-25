using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Practica_1
{
    class Program
    {
        public static string lee,l;
        public static double x = 0, y = 0;
        public static int op=0;
        public const double pi=3.1416;

        static double suma(double a,double b) {
            double r = 0;
            r = a + b;
            return r;
        }
        static double resta(double a, double b){
            double r = 0;
            r = a - b;
            return r;
        }
        static double producto(double a, double b)
        {
            double r = 0;
            r = a * b;
            return r;
        }
        static double division(double a, double b)
        {
            double r = 0;
            r = a / b;
            return r;
        }
        static double ATri(double a, double b)
        {
            double r = 0;
            r =(a * b)/2;
            return r;
        }
        static double ACir(double a)
        {
            double r = 0;
            r = pi*(a*a);
            return r;
        }
        static double ACuad(double a)
        {
            double r = 0;
            r = a*a;
            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n      Menu de Operaciones Basicas");
            do{
                Console.WriteLine("\n\n   Elige una de las siguientes opciones");
                Console.WriteLine("\n1.- Suma\n2.- Resta\n3.- Producto\n4.- Division\n5.- Area de un Triangulo\n6.- Area de un circulo\n7.- Area de un Cuadrado\n8.- Salir");
                l = Console.ReadLine();
                op = int.Parse(l);
                switch(op){

                    case 1: 
                        Console.WriteLine("\n Dame el primer numero");
                        lee= Console.ReadLine();
                        x = double.Parse(lee);
                        Console.WriteLine("\n Dame el segundo numero");
                        lee= Console.ReadLine();
                        y = double.Parse(lee);
                        Console.WriteLine("La suma es : "+ suma(x,y));
                        break;
                    case 2:
                        Console.WriteLine("\n Dame el primer numero");
                        lee = Console.ReadLine();
                        x = double.Parse(lee);
                        Console.WriteLine("\n Dame el segundo numero");
                        lee = Console.ReadLine();
                        y = double.Parse(lee);
                        Console.WriteLine("La resta es : "+ resta(x, y));
                        break;
                    case 3:
                        Console.WriteLine("\n Dame el primer numero");
                        lee = Console.ReadLine();
                        x = double.Parse(lee);
                        Console.WriteLine("\n Dame el segundo numero");
                        lee = Console.ReadLine();
                        y = double.Parse(lee);
                        Console.WriteLine("El producto es es : "+ producto(x, y));
                        break;
                    case 4:
                        Console.WriteLine("\n Dame el primer numero");
                        lee = Console.ReadLine();
                        x = double.Parse(lee);
                        Console.WriteLine("\n Dame el segundo numero");
                        lee = Console.ReadLine();
                        y = double.Parse(lee);
                        Console.WriteLine("La division es : "+ division(x, y));
                        break;
                    case 5:
                        Console.WriteLine("\n Dame la base");
                        lee = Console.ReadLine();
                        x = double.Parse(lee);
                        Console.WriteLine("\n Dame la altura");
                        lee = Console.ReadLine();
                        y = double.Parse(lee);
                        Console.WriteLine("El area del triangulo es : "+ ATri(x, y));
                        break;
                    case 6:
                        Console.WriteLine("\n Dame el radio de la circunferencia");
                        lee = Console.ReadLine();
                        x = double.Parse(lee);
                        Console.WriteLine("El area de la circunferencia es : "+ ACir(x));
                        break;
                    case 7:
                        Console.WriteLine("\n Dame el valor de un lado");
                        lee = Console.ReadLine();
                        x = double.Parse(lee);
                        Console.WriteLine("El area del triangulo es : "+ ACuad(x));
                        break;

                }
                Console.ReadLine();
            }while(op!=8);
            
           
        }
    }
}
