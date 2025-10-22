using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    internal class Program
    {
        static void ej1()
        {
            /*
             * Ejercicio 1
             * Crea una aplicación que, en primer lugar, pida al usuario que 
             * introduzca el tamaño del array de enteros a crear, y a continuación 
             * proceda a solicitarle al usuario el valor de cada uno de esos 
             * componentes del array. Finalmente, muestra por pantalla la suma y 
             * la media de todos los valores del array
             */
            Console.WriteLine("Introduce el tamaño del array: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            if (tamaño <= 0)
            {
                Console.WriteLine("Tamaño no valido.");
                return;
            }
            int[] array = new int[tamaño];
            int suma = 0;
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine("Introduce el valor del elemento " + (i + 1) + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                suma += array[i];
            }
            double media = (double)suma / tamaño;
            Console.WriteLine("La suma de los elementos es: " + suma);
            Console.WriteLine("La media de los elementos es: " + media);    
        }

        

        static void ej2()
        {
            /*
             * Ejercicio 2
             * Crea una aplicación que cuente el número de espacios en blanco 
             * existentes en una cadena que el usuario introduce por teclado. Debes 
             * implementar una función que reciba como parámetro un string y 
             * devuelva el número de caracteres.
             */
            Console.WriteLine("Introduce una cadena de texto: ");
            string cadena = Console.ReadLine();
            int espacios = ContarEspacios(cadena);
            Console.WriteLine("El número de espacios en blanco es: " + espacios);
        }

        static int ContarEspacios(string cadena)
        {
            int contador = 0;
            foreach (char c in cadena)
            {
                if (c == ' ')
                {
                    contador++;
                }
            }
            return contador;
        }

        static void ej3()
        {
            /*
             * Ejercicio 3
             * Realiza un programa que, mediante un método auxiliar y con 
             * recursividad, calcule el factorial de un número que el usuario 
             * introduce por teclado. Nota: el factorial de un número se calcula
             * como n!=n*(n-1)*(n-2)*(n-3)*…*3*2*1. 
             * Por ejemplo: 6!=6*5*4*3*2*1=720
             */
            Console.WriteLine("Introduce un número para calcular su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
                return;
            }
            long factorial = CalcularFactorial(numero);
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
        }

        static long CalcularFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalcularFactorial(n - 1);
            }
        }

        static void ej4()
        {
            /*
             * Ejercicio 4
             * Crea un programa que compruebe si un número que el usuario 
             * introduce por teclado es primo o no. Impleméntalo mediante una
             * función. Nota: un número es primo si solo es divisible por sí mismo y
             * por la unidad.
             */
            Console.WriteLine("Introduce un número para comprobar si es primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool esPrimo = EsPrimo(numero);
            if (esPrimo)
            {
                Console.WriteLine("El número " + numero + " es primo.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " no es primo.");
            }
        }
        static bool EsPrimo(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void ej5()
        {
            /*
             * Ejercicio 5
             * Crea un programa que calcule la potencia X de un número
             * determinado. El usuario introducirá por teclado tanto la base como
             * el exponente. NO puedes utilizar la clase Math. Impleméntalo de dos
             * formas: iterativa y recursiva.
             */
            Console.WriteLine("Introduce la base: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el exponente: ");
            int exponente = Convert.ToInt32(Console.ReadLine());
            long resultadoIterativo = CalcularPotenciaIterativa(baseNum, exponente);
            long resultadoRecursivo = CalcularPotenciaRecursiva(baseNum, exponente);
            Console.WriteLine("Resultado (Iterativo): " + resultadoIterativo);
            Console.WriteLine("Resultado (Recursivo): " + resultadoRecursivo);
        }

        static long CalcularPotenciaIterativa(int baseNum, int exponente)
        {
            long resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        static long CalcularPotenciaRecursiva(int baseNum, int exponente)
        {
            if (exponente == 0)
            {
                return 1;
            }
            else
            {
                return baseNum * CalcularPotenciaRecursiva(baseNum, exponente - 1);
            }
        }

        static void ej6()
        {
            /*
             * Ejercicio 6
             * Crea una aplicación que se encargue de controlar el login de un
             * usuario en una aplicación. Tendrás que implantarlo mediante una
             * función que reciba como parámetro el usuario y la contraseña, y que
             * devuelva “true” si el usuario es “usuario2DAM” y la contraseña es
             * “pass2DAM”. Además, el usuario solo tendrá permitido tres intentos.
             */
            while (true)
            {
                Console.WriteLine("Introduce el usuario: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("Introduce la contraseña: ");
                string contraseña = Console.ReadLine();
                bool loginCorrecto = ComprobarLogin(usuario, contraseña);
                if (loginCorrecto)
                {
                    Console.WriteLine("Login correcto. Bienvenido.");
                    break;
                }
                else
                {
                    Console.WriteLine("Login incorrecto. Inténtalo de nuevo.");
                }
            }
        }
        static bool ComprobarLogin(string usuario, string contraseña)
        {
            return usuario == "usuario2DAM" && contraseña == "pass2DAM";
        }

        static void ej7()
        {
            /*
             * Ejercicio 7
             * Crea un programa que pida dos número enteros al usuario y diga si
             * alguno de ellos es múltiplo del otro. Crea una función EsMultiplo que
             * reciba los dos números, y devuelve si el primero es múltiplo del
             * segundo
             */

            Console.WriteLine("Introduce el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool esMultiplo = EsMultiplo(num1, num2);
            if (esMultiplo)
            {
                Console.WriteLine("El número " + num1 + " es múltiplo de " + num2);
            }
            else
            {
                Console.WriteLine("El número " + num1 + " no es múltiplo de " + num2);
            }
        }

        static bool EsMultiplo(int a, int b)
        {
            if (b == 0)
            {
                return false;
            }
            return a % b == 0;
        }

        static void ej8()
        {
            /*
             * Ejercicio 8
             * Crea un programa en C#, que mediante el uso de una función auxiliar,
             * calcule la suma de los dígitos individuales de un número que el
             * usuario introduce por teclado. Por ejemplo, si el usuario introduce el
             * número 23, el resultado debe ser 2+3=5.
             */
            Console.WriteLine("Introduce un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int suma = CalcularSumaDigitos(numero);
            Console.WriteLine("La suma de los dígitos de " + numero + " es: " + suma);
        }

        static int CalcularSumaDigitos(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            return suma;
        }

        static void ej9()
        {
            /*
             * Ejercicio 9
             * Crea una función que devuelva la posición del número menor de un 
             * array. Los valores de este array se definen en el código directamente.
             */
            int[] numeros = { -15, 3, 8, 7, -7,  1, 4 };
            int posicion = EncontrarMinimo(numeros);
            Console.WriteLine("La posición del número menor es: " + posicion);
        }

        static int EncontrarMinimo(int[] array)
        {
            int min = array[0];
            int posicion = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    posicion = i;
                }
            }
            return posicion;
        }

        static void ej10()
        {
            /*
             * Ejercicio 10
             * Crea un programa en C# para simular un banco y sus clientes, los 
             * cuales realizan depósitos.Implementa las clases Cliente y Banco.
             * El constructor de Banco creará tres instancias de la clase Cliente.
             * El constructor de Cliente recibirá como parámetros un string con el nombre
             * del cliente.
             * En Cliente tienes que definir:
             * • El campo nombre (string)
             * • El campo cantidadTotal (int o double)
             * • El método Ingresar, que tiene como argumento un entero o double.
             * • El método Sacar, que tiene como parámetro un entero o doublé.
             * • El método GetCantidadTotal, que devuelve el dinero que el cliente
             * tiene en su cuenta.
             * • El método MostrarInformacion, que mostrará por pantalla la
             * cantidad total que el usuario tiene en su
             * cuenta.
             * En Banco tienes que definir:
             * • El main de la aplicación, que creará la instancia de Banco, realizará
             * operaciones (llamada a Operar() y que mostrará información por pantalla (método ObtenerEstado()).
             * • El constructor creará tres instancias de Cliente, pasándole como
             * parámetro un nombre.
             * • El método Operar, que simulará el ingreso de dinero en las cuentas
             * de cada cliente (llamando el método Ingresar de la clase Cliente).
             * • El método ObtenerEstado, que en primer lugar muestra el dinero
             * total que se han ingresado en el banco por parte de los tres cliente
             * (suma de los tres), y a continuación muestra el dinero que ha
             * ingresado cada cliente (mediante el método GetCantidadTotal de la
             * clase Cliente)
             */
            Banco banco = new Banco();
            banco.Operar();
            Console.WriteLine("Bienvenido al banco");
            while (true)
            {
                banco.ObtenerEstado();
                Console.WriteLine("Pulse 1 para ingresar dinero, 2 para sacar dinero, 0 para salir: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 0)
                {
                    break;
                }
                Console.WriteLine("Seleccione cliente (1, 2, 3): ");
                int clienteNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce la cantidad: ");
                double cantidad = Convert.ToDouble(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        if (clienteNum == 1)
                        {
                            banco.cliente1.Ingresar(cantidad);
                        }
                        else if (clienteNum == 2)
                        {
                            banco.cliente2.Ingresar(cantidad);
                        }
                        else if (clienteNum == 3)
                        {
                            banco.cliente3.Ingresar(cantidad);
                        }
                        break;
                    case 2:
                        if (clienteNum == 1)
                        {
                            banco.cliente1.Sacar(cantidad);
                        }
                        else if (clienteNum == 2)
                        {
                            banco.cliente2.Sacar(cantidad);
                        }
                        else if (clienteNum == 3)
                        {
                            banco.cliente3.Sacar(cantidad);
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            Console.WriteLine("Fin del Banco.");
        }

        class Cliente
        {
            private string nombre;
            private double cantidadTotal;
            public Cliente(string nombre)
            {
                this.nombre = nombre;
                this.cantidadTotal = 0;
            }
            public void Ingresar(double cantidad)
            {
                cantidadTotal += cantidad;
            }
            public void Sacar(double cantidad)
            {
                if (cantidad <= cantidadTotal)
                {
                    cantidadTotal -= cantidad;
                }
                else
                {
                    Console.WriteLine("No hay suficiente saldo.");
                }
            }
            public double GetCantidadTotal()
            {
                return cantidadTotal;
            }
            public void MostrarInformacion()
            {
                Console.WriteLine("Cliente: " + nombre + ", Cantidad Total: " + cantidadTotal);
            }
        }

        class Banco
        {
            public Cliente cliente1;
            public Cliente cliente2;
            public Cliente cliente3;
            public Banco()
            {
                cliente1 = new Cliente("Cliente 1");
                cliente2 = new Cliente("Cliente 2");
                cliente3 = new Cliente("Cliente 3");
            }
            public void Operar()
            {
                cliente1.Ingresar(1000);
                cliente2.Ingresar(2000);
                cliente3.Ingresar(1500);
            }
            public void ObtenerEstado()
            {
                double totalBanco = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();
                Console.WriteLine("Total ingresado en el banco: " + totalBanco);
                cliente1.MostrarInformacion();
                cliente2.MostrarInformacion();
                cliente3.MostrarInformacion();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa.");
            bool bucle = true;
            while (bucle==true)
            {
                Console.WriteLine("1. Ej1");
                Console.WriteLine("2. Ej2");
                Console.WriteLine("3. Ej3");
                Console.WriteLine("4. Ej4");
                Console.WriteLine("5. Ej5");
                Console.WriteLine("6. Ej6");
                Console.WriteLine("7. Ej7");
                Console.WriteLine("8. Ej8");
                Console.WriteLine("9. Ej9");
                Console.WriteLine("10. Ej10");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione opcion: ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        bucle = false;
                        break;
                    case 1:
                        ej1 (); 
                        break;
                    case 2:
                        ej2();
                        break;
                    case 3:
                        ej3();
                        break;
                    case 4:
                        ej4();
                        break;
                    case 5:
                        ej5();
                        break;
                    case 6:
                        ej6();
                        break;
                    case 7:
                        ej7();
                        break;
                    case 8:
                        ej8();
                        break;
                    case 9:
                        ej9();
                        break;
                    case 10:
                        ej10();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            }
        }
    }
}
