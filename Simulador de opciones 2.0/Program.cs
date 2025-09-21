using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_opciones_2._0
{
    internal class Program
    {
        static void menu_main()
        {
            bool errores = false;
            while (!errores)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("***1.Determinar número primo y par. " +
                        "2.Simulador de Banco. 3.Salir.***");
                    Console.ResetColor();
                    int opcion_mainmenu = int.Parse(Console.ReadLine());
                    while (opcion_mainmenu < 0 || opcion_mainmenu > 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Escriba una opción válida.");
                        Console.ResetColor();
                        opcion_mainmenu = int.Parse(Console.ReadLine());
                    }
                    switch (opcion_mainmenu)
                    {
                        case 1:
                            {
                                primos_par();
                                break;
                            }
                        case 2:
                            {
                                banco();
                                break;
                            }
                        case 3:
                            {
                                salir();
                                break;
                            }

                    }

                    errores = true;
                }
                catch (FormatException error)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. " + error.Message);
                    Console.ResetColor();
                }
            }
        }

        static void primos_par()
        {
            bool errores = false;
            while (!errores) //permite repetir el ciclo si la entrada no es la correcta uwu
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("**Determine si un número es par y/o primo");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Escriba un número.");
                    Console.ResetColor();
                    int numero = int.Parse(Console.ReadLine());
                    while (numero < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingrese un valor mayor a 0");
                        Console.ResetColor();
                        numero = int.Parse(Console.ReadLine());
                    } 
                    bool par = false;
                    bool primo = false;
                    int z = 0;
                    for (int i = 1; i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            z = z + 1;
                        }
                    }
                    if (z == 2)
                    {
                        primo = true;
                    }
                    else
                    {
                        primo = false;
                    }

                    if (numero % 2 == 0)
                    {
                        par = true;
                    }
                    else
                    {
                        par = false;
                    }

                    if (!par && !primo)
                    {
                        Console.WriteLine("El numero no es par ni es primo");
                    }
                    else if (!par && primo)
                    {
                        Console.WriteLine("El numero no es par pero si es primo");
                    }
                    else if (par && !primo)
                    {
                        Console.WriteLine("El numero es par pero no es primo");
                    }
                    else
                    {
                        Console.WriteLine("El numero es primo y par");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("1.Determinar de nuevo. 2.Salir");
                    Console.ResetColor();
                    int opcion = int.Parse(Console.ReadLine());
                    while (opcion != 1 && opcion != 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Seleccione una opción válida");
                        Console.ResetColor();
                        opcion = int.Parse(Console.ReadLine());
                    }
                    switch (opcion)
                    {
                        case 1:
                            {
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                menu_main();
                                break;
                            }
                    }
                    errores = true;
                }
                catch (FormatException error)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. " + error.Message);
                    Console.ResetColor();
                }
            }
            
        }
        static void banco() //wnifnvnkje !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            bool errores = false;
            string contraseña = "banco123";
            while (!errores)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("1.Iniciar Sesión. 2.Salir");
                    Console.ResetColor();
                    int op = int.Parse(Console.ReadLine());
                    while (op != 1 && op != 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Seleccione una opción válida");
                        Console.ResetColor();
                        op = int.Parse(Console.ReadLine());
                    }
                        switch (op)
                        {
                        case 1:
                            {
                                Console.WriteLine("***Ingrese su contraseña***");
                                string ac = Console.ReadLine();
                                while (ac != contraseña)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Contraseña incorrecta, por favor, ingrese su contraseña.");
                                    Console.ResetColor();
                                    ac = Console.ReadLine();
                                }
                                if (ac == contraseña)
                                {
                                    menu_banco();
                                    break;
                                }
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                menu_main();
                                break;
                            }
                        }
                    


                    errores = true; //breaks the fucking cycle
                }
                catch (FormatException error)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. " + error.Message);
                    Console.ResetColor();
                }
            }
        }
        static void menu_banco()
        {
            double saldo = 3400;
            bool acceso_banco = true;
            while (acceso_banco == true)
            {
                bool errores = false;
                while (!errores)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("***Seleccione una acción***");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("1.Consultar Saldo. 2.Depositar. 3.Retirar. 4.Cerrar Sesión");
                        Console.ResetColor();
                        int op = int.Parse(Console.ReadLine());
                        while (op < 0 || op > 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Seleccione una opción válida");
                            Console.ResetColor();
                            op = int.Parse(Console.ReadLine());
                        }

                        switch (op)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Su saldo actual es de: " + saldo);
                                    Console.ResetColor();
                                    break;
                                }
                            case 2:
                                {
                                    bool depositar = true;
                                    while (depositar == true)
                                    {
                                        Console.WriteLine("¿Qué cantidad desea depositar a su cuenta?");
                                        double deposito = double.Parse(Console.ReadLine());
                                        while (deposito < 0)
                                        {
                                            Console.WriteLine("Cantidad no disponible.");
                                            deposito = double.Parse(Console.ReadLine());
                                        }
                                        saldo = saldo + deposito;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Depósito realizado exitosamente");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("1.Depositar de nuevo. 2.Salir");
                                        Console.ResetColor();
                                        int opcion = int.Parse(Console.ReadLine());
                                        while (opcion != 1 && opcion != 2)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Seleccione una opción válida");
                                            Console.ResetColor();
                                            opcion = int.Parse(Console.ReadLine());
                                        }
                                        if (opcion == 1)
                                        {
                                            acceso_banco = true;
                                        }
                                        else 
                                        {
                                            Console.Clear();
                                            depositar = false;
                                            acceso_banco = true;

                                        }
                                    }


                                    break;
                                }
                            case 3:
                                {
                                    bool retirar = true;
                                    while (retirar == true)
                                    {
                                        Console.WriteLine("¿Qué cantidad desea retirar a su cuenta?");
                                        double retiro = double.Parse(Console.ReadLine());
                                        while (retiro < 0 || saldo < retiro)
                                        {
                                            Console.WriteLine("Cantidad no disponible.");
                                            retiro = double.Parse(Console.ReadLine());
                                        }
                                        saldo = saldo - retiro;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Retiro realizado exitosamente");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("1.Retirar de nuevo. 2.Salir");
                                        Console.ResetColor();
                                        int opcion = int.Parse(Console.ReadLine());
                                        while (opcion != 1 && opcion != 2)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Seleccione una opción válida");
                                            Console.ResetColor();
                                            opcion = int.Parse(Console.ReadLine());
                                        }
                                        if (opcion == 1)
                                        {
                                            acceso_banco = true;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            retirar = false;
                                            acceso_banco = true;

                                        }
                                    }


                                    break;
                                }
                            case 4:
                                {   Console.Clear();
                                    acceso_banco = false;
                                    errores = true;
                                    banco();
                                    break;
                                }
                        }


                        errores = true;
                    }
                    catch (FormatException error)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error. " + error.Message);
                        Console.ResetColor();
                    }
                }
            }
            
                
            
        }

        static void salir()
        {

        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***Bienvenido al programa.***");
            menu_main();
        }
    }
}
