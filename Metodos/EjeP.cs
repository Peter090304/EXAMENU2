using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EXAMEN.Metodos
{
    internal class EjeP
    {
        private float sumaVendedor2;
        private float sumaVendedor4;

        public void Unidimensional()
        {
            int CantidaddeProductos = 5;
            float[,] ganancias = new float[3, CantidaddeProductos];
            float sumaVendedor1 = 0.0f; _ = sumaVendedor2 == 0.0f;
            float sumaVendedor3 = 0.0f; _ = sumaVendedor4 == 0.0f;
            Console.WriteLine("Ingresar las cantidades de cada vendedor");

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < CantidaddeProductos; i++)
                {
                    ganancias[j, i] = Convert.ToSingle(Console.ReadLine());
                }
                /* Calcular promedio las ganancias del vendedor1*/
                for (int i = 0; i < CantidaddeProductos; i++)
                {
                    sumaVendedor1 += ganancias[0, i];
                }
                Console.WriteLine("Las ganancias del vendedor1 {0}", sumaVendedor1 / CantidaddeProductos);
                /* Calcular promedio las ganancias del vendedor2*/
                for (int i = 0; i < CantidaddeProductos; i++)
                {
                    sumaVendedor2 += ganancias[1, i];
                }
                /*Calcular el promedio de las ganancias del vendedor3*/
                for (int i = 0; i < CantidaddeProductos; i++)
                {
                    sumaVendedor3 = ganancias[0, i];
                }
                Console.WriteLine("Las ganancias del vendedor3 {0}", sumaVendedor3 / CantidaddeProductos);

                Console.WriteLine("Las ganancias del vendedor2{0}", sumaVendedor2 / CantidaddeProductos);
                Console.ReadKey();
            }

        }



        internal class EjeP2
        {
            public void Unidimensional2()
            {
                int[] arreglo = new int[100];
                Random random = new Random();

                // Llenar el arreglo con números aleatorios
                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i] = random.Next(101); // Números aleatorios entre 0 y 100
                }

                // Imprimir la matriz desordenada
                Console.WriteLine("Matriz desordenada:");
                ImprimirArreglo(arreglo);

                // Ordenar la matriz de forma descendente usando el método de selección
                OrdenarSeleccionDescendente(arreglo);

                // Imprimir la matriz ordenada
                Console.WriteLine("Matriz ordenada de forma descendente:");
                ImprimirArreglo(arreglo);

                // Buscar el número 75 en la matriz ordenada utilizando búsqueda binaria
                int objetivo = 75;
                int posicion = BusquedaBinaria(arreglo, objetivo);

                // Imprimir la posición del número 75 o un mensaje si no se encuentra
                if (posicion != -1)
                {
                    Console.WriteLine("El número 75 se encuentra en la posición " + posicion);
                }
                else
                {
                    Console.WriteLine("El número 75 no se encuentra en la matriz ordenada.");
                }
            }

            static void ImprimirArreglo(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            static void OrdenarSeleccionDescendente(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int indiceMaximo = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] > arr[indiceMaximo])
                        {
                            indiceMaximo = j;
                        }
                    }
                    int temp = arr[i];
                    arr[i] = arr[indiceMaximo];
                    arr[indiceMaximo] = temp;
                }
            }

            static int BusquedaBinaria(int[] arr, int objetivo)
            {
                int izquierda = 0;
                int derecha = arr.Length - 1;

                while (izquierda <= derecha)
                {
                    int medio = izquierda + (derecha - izquierda) / 2;

                    if (arr[medio] == objetivo)
                    {
                        return medio;
                    }

                    if (arr[medio] < objetivo)
                    {
                        izquierda = medio + 1;
                    }
                    else
                    {
                        derecha = medio - 1;
                    }
                }

                return -1;
            }
        }
    }
}
