using System;

namespace C__Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pro;
            do {
                Console.WriteLine("");
                //Bienvenida para el ususario e Instrucciones :)
                Console.WriteLine("Bienvenido a Calculadora 3000!!!\n Calcula lo que quieras!" + 
                "\n1.- -Suma-" +
                "\n2.- -Resta-" +
                "\n3.- -Multiplicacíon-" +
                "\n4.- -División-" +
                "\n5.- -Módulo-" +
                "\n6.- Salir - \n");
                String VE1 = null;
                VE1 = Console.ReadLine().ToString();//Desicion Tomada
                //Switch
                switch (VE1) 
                {
                    //OPERACION DE SUMA
                    case "1":
                        Console.WriteLine("---------");
                        Console.WriteLine("Suma!");
                        Console.WriteLine("----------");
                        //Numero 1 / suma
                        Console.WriteLine("Primer Numero a Sumar: "); 
                        int Numz = Convert.ToInt16(Console.ReadLine());
                        //Numero 2 / Suma
                        Console.WriteLine("Segundo Numero a Sumar: "); 
                        int Numo = Convert.ToInt16(Console.ReadLine());
                        int LaSuma = Numz + Numo; //Operacion
                        //Resultado
                        Console.WriteLine($"El resultado es igual a: " + LaSuma ); 
                        break;

                    //OPERACION DE RESTA
                    case "2":
                        Console.WriteLine("--------");
                        Console.WriteLine("Resta!");
                        Console.WriteLine("---------");
                        //Numero 1 / resta
                        Console.WriteLine("Primer Numero: "); 
                        int NumR1 = Convert.ToInt16(Console.ReadLine());
                        //Numero 1 / resta
                        Console.WriteLine("Segundo Numero: "); 
                        int NumR2 = Convert.ToInt16(Console.ReadLine());
                        int LaResta = NumR1 - NumR2; //operacion
                        //Resultado
                        Console.WriteLine($"El resultado es igual a : " + LaResta ); 
                        break;

                    //OPERACION DE Multiplicacion
                    case "3":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Multiplicacion!!!");
                        Console.WriteLine("---------------------");
                        //Numero 1 / multiplicacion
                        Console.WriteLine("Primer Numero: "); 
                        int NumM1 = Convert.ToInt16(Console.ReadLine());
                        //Numero 2 / multiplicacion
                        Console.WriteLine("Segundo Numeero: "); 
                        int NumM2 = Convert.ToInt16(Console.ReadLine());
                        int LaMult = NumM1 * NumM2; //operacion
                        //Resultado
                        Console.WriteLine($"El resultado es igual a : " + LaMult );
                        break;

                    //OPERACION DE Division 
                    case "4":  
                        Console.WriteLine("-----------");
                        Console.WriteLine("División!!!");
                        Console.WriteLine("-------------");
                        //Numero 1 / Division
                        Console.WriteLine("Primer Numero: "); 
                        int NumD1 = Convert.ToInt16(Console.ReadLine());
                        //Numero 2 / Division
                        Console.WriteLine("Segundo Numero: "); 
                        int NumD2 = Convert.ToInt16(Console.ReadLine());
                    
                        //Por los divisores en 0
                        if (NumD1 <= 0 || NumD2 <= 0)
                            Console.WriteLine("Uno de los números es igual a 0");

                        else {
                            int LaDiv = NumD1 / NumD2;
                            //Resultado
                            Console.WriteLine("El resultado es igual a :" + LaDiv);
                        }
                        break;

                    //OPERACION DE Modulo
                    case "5":
                        Console.WriteLine("--------------");
                        Console.WriteLine("Módulo!!!");
                        Console.WriteLine("------------");
                        //Numero 1 / Modulo
                        Console.WriteLine("Introduzca el 1er. Número: "); 
                        int NumMod1 = Convert.ToInt16(Console.ReadLine());
                        //Numero 1 / Modulo
                        Console.WriteLine("Introduzca el 2do. Número: "); 
                        int NumMod2 = Convert.ToInt16(Console.ReadLine());
                        int ElMod = NumMod1 % NumMod2; //operacion
                        //Resultado
                        Console.WriteLine($"El resultado del módulo es: " + ElMod ); 
                        break;
                    
                    //Para Salir
                    case "6":
                        Console.WriteLine("");
                        Console.WriteLine("Gracias por usar la Calculodara 3000!!!   :)  ");
                        break;

                    default:
                        Console.WriteLine("x-x");
                        break;
                }
                //Final del programa
                Console.WriteLine("");
                Console.WriteLine("¿Desea continuar?");
                Console.WriteLine("1. Si -- 2. No");
                Console.WriteLine("");
                Pro = Convert.ToUInt16(Console.ReadLine());
            } while(Pro == 1);
        }   
    }
}