using System;

namespace tarea_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrizProductos = new string[5,9];

            matrizProductos[0, 0] = "Pedro";
            matrizProductos[0, 1] = "1023";
            matrizProductos[0, 2] = "1";
            matrizProductos[0, 3] = "1";
            matrizProductos[0, 4] = "1";
            matrizProductos[0, 5] = "5533";
            matrizProductos[0, 6] = "333";
            matrizProductos[0, 7] = "1";
            matrizProductos[0, 8] = "123";

            matrizProductos[1, 0] = "Jose";
            matrizProductos[1, 1] = "5533";
            matrizProductos[1, 2] = "333";
            matrizProductos[1, 3] = "1";
            matrizProductos[1, 4] = "123";
            matrizProductos[1, 5] = "5533";
            matrizProductos[1, 6] = "333";
            matrizProductos[1, 7] = "1";

            matrizProductos[2, 0] = "MIguel";
            matrizProductos[2, 1] = "30";
            matrizProductos[2, 2] = "232";
            matrizProductos[2, 3] = "1";
            matrizProductos[2, 4] = "1323";
            matrizProductos[2, 5] = "533533";
            matrizProductos[2, 6] = "333";
            matrizProductos[2, 7] = "12434";

            matrizProductos[3, 0] = "Pedro";
            matrizProductos[3, 1] = "30";
            matrizProductos[3, 2] = "232";
            matrizProductos[3, 3] = "1232";
            matrizProductos[3, 4] = "321";
            matrizProductos[3, 5] = "5533";
            matrizProductos[3, 6] = "23423";
            matrizProductos[3, 7] = "1234";

            matrizProductos[4, 0] = "Ramon";
            matrizProductos[4, 1] = "30";
            matrizProductos[4, 2] = "120";
            matrizProductos[4, 3] = "12342";
            matrizProductos[4, 4] = "2323";
            matrizProductos[4, 5] = "234";
            matrizProductos[4, 6] = "333";
            matrizProductos[4, 7] = "243";

            Console.Write("nombre      lunes      martes    miercoles   jueves     viernes    sabado    domingo     Total (km)\n");
            
            for (int c = 0; c < matrizProductos.GetLength(0); c++) //flecha verde
            {
                int kmUno = int.Parse(matrizProductos[c, 1]);
                int kmDos = int.Parse(matrizProductos[c, 2]);
                int kmTres = int.Parse(matrizProductos[c, 3]);
                int kmCuatro = int.Parse(matrizProductos[c, 4]);
                int kmCinco = int.Parse(matrizProductos[c, 5]);
                int kmSeis = int.Parse(matrizProductos[c, 6]);
                int kmSiete = int.Parse(matrizProductos[c, 7]);

                int kmTotales = kmUno + kmDos + kmTres + kmCuatro + kmCinco + kmSeis + kmSiete;
                 matrizProductos[c, 8] = $"{kmTotales}";
            }

            for (int f = 0; f < matrizProductos.GetLength(0); f++)
            {

               for (int c = 0; c < matrizProductos.GetLength(1); c++)
               {
                   if (!string.IsNullOrEmpty(matrizProductos[f, c]))
                   {
                       if (c == 0)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                        else if  (c == 1)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                        else if  (c == 2)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                         else if  (c == 3)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                        else if  (c == 4)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                        else if  (c == 5)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                                               else if  (c == 6)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                                               else if  (c == 7)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                                               else if  (c == 8)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                                               else if  (c == 9)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                                                                      else if  (c == 10)
                       {
                           Console.Write(" {0,-10}", matrizProductos[f, c]);
                       }
                       else
                       {
                           Console.Write($"{matrizProductos[f, c]  ,-3}");
                       }
                   }

               }
               Console.WriteLine("");  // salto de linea para mostrar la siguiente fila abajo 
            }
        }
    }
}
