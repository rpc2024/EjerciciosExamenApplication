
namespace EjerciciosExamenApplication
{
    class EjerciciosExamen
    {
        public static int Menor3(int n1, int n2, int n3)
        {
            if (n1 <= n2)
            {
                if (n1 <= n3)
                    return n1;
                else return n3;
            }
            else
            {
                if (n2 <= n3)
                    return n2;
                else
                    return n3;
            }
            
        }

        public static int Menor4(int n1, int n2, int n3, int n4)
        {

            if (n1 < n2)

                return Menor3(n1, n3, n4);
            else
                return Menor3(n2, n3, n4);
        }

        public static void PrintSerie()
        {
           int n = 6;
            if (n < 0)
                System.Console.Write(0);
            for (int i = 1; i < n; i++)
                System.Console.Write("," + i);
        }

        // HUF que se le pase int e imprima una linea de n*

        public static void PrintAsteriscos(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }

        public static void PrintAseriscosPlus(int n)
        {
            for (int i = 0; i < n; i ++)
            {
                if ((i % 2) == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }
        }

        public static void PrintAsteriscoPlusMenosBarra(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int resto = i % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }

                //HUF int --> cubo de asteriscos
            }
        }
            public static void PrintCuadrado(int n)
            {           
                for ( int r = 0; r < n; r++)
                {
                    for ( int c = 0; c < n; c++)
                    {
                        System.Console.Write("*");
                            System.Console.WriteLine();
                    }
                }


            }
  

        //HUF que devuelva el menor de 16 numeros 

        public static int Menor16 (int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10, int n11, int n12, int n13, int n14, int n15, int n16)
        {

            return Menor4(Menor4(n1, n2, n3, n4),  Menor4(n5, n6, n7, n8) , Menor4(n9, n10, n11, n12), Menor4(n13, n14, n15, n16));
        }


        public static void PrintCuadradoAP(int n)
        {
            for ( int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((r % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }

                System.Console.WriteLine();
            }

        }

        public static void PrintCuadradoAPIntercalado(int n)
        {
            int r = 0; int c = 0;            
            for ( r = 0; r < n; r++)
            {
                for (c = 0; c < n; c++)
                {
                    int Flag = r + c;
                    if ((Flag % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();

            }
        }


        public static void PrintEscalera( int n)
        {
            int r = 0; int c = 0;
            for (r = 0; r < n; r++)
            {
                for (c = 0; c <= r; c++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();

            }
        }

        public static void PrintEscaleraEspaciada(int n)
        {
            int r = 0; int c = 0;
            int nespacios = n - (r + 1);
            int nasteriscos = n + (r + 1);
            for (r = 0; r < n; r ++)
            {
                for (c = 0; c < n; c ++)
                {
                    
                    

                }





            }




        }



    }



}
