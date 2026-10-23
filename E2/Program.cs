using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Daniela Córdova Caloca 331-07

            /*1. Sintaxis
        
            TipoDato_nombre(parametros)
            {
                Instrucciones
            }
            */
           
            // 2. Ciclo
           int x = 0;
            while(x > 27)
            {
                if(x == 0 && x > 6)
                {
                    int x += 2;
                    Console.WriteLine($"{x}");
                }
                if(x == 6 && x > 15)
                {
                    int x += 3;
                    Console.WriteLine($"{x}");
                }
                int x += 4;
                    Console.WriteLine($"{x}");
            }

            // 3. Declarar variables
            int inicio = 3;
            int limite = 2;
            int y = 9;
            if(inicio * limite <= 8 && inicio > limite)
            {
                while(y < 0)
                {
                   int y -= 1;
                }

            }
            else
            {
             while(y < 18)
                {
                   int y += 1;
                }
            }

            // 4. Invocar
            int numero(int num)
            {
                bool multiplo = (num % 5 == 0) 
                return(multiplo)
            }
            int devolucion;
            devolucion = numero(25);
            if (multiplo == true)
            {
                Console.WriteLine($"{num}: Verdadero");
            }
            else (multiplo == false)
            {
                Console.WriteLine($"{num}: Falso");
            }

            //5. Funcion vacia
            void examen()
            {
                string arg = "Examen: Programacion III";
                Console.WriteLine($"{arg}");
            }
            examen()
        }    
    }
}