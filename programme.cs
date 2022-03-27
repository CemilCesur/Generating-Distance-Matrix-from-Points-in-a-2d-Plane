using System;

namespace ConsoleApp3
{
    class Program
    {
        // random sayesinde nokta için rastgele x ve y üreten metot 
        public static double[,] üretimMatrisi(int n, int height, int width)
        {
            double[,] noktalar = new double[n, 2];
            
            // random metodu
            Random random = new Random();

            for (int a = 0; a < n; a++)
            {
                double x = random.NextDouble() * width; // NextDouble() metodu 0-1 arası bir değer döndürdüğü için width ve height ile çarpıyoruz
                double y = random.NextDouble() * height; 
                noktalar[a, 0] = x;
                noktalar[a, 1] = y;

            }

            return noktalar;
        }



        // nxn boyutunda, noktalar arasında uzaklıkları oluşturan metot 
        public static double[,] uzaklıkMatrisi(int n, double[,] matris1)
        {
            double[,] matris2 = new double[n, n];

            for (int a=0; a < n; a++)
            {
                for (int b=0; b < n; b++)
                {
                    // formül
                    matris2[a, b] = Math.Sqrt(Math.Pow((matris1[a, 0] - matris1[b, 0]),2) + Math.Pow((matris1[a, 1] - matris1[b, 1]),2));
                }
            }

            return matris2;

        } 





        static void Main(string[] args)
        {
            // örnek olarak değerleri yazdım
            int n = 10;
            int width = 100;
            int height = 100;
            
            // metotları matrislere attık
            double[,] ilkMatris = üretimMatrisi(n, height, width);

            double[,] sonMatris = uzaklıkMatrisi(n, ilkMatris);

            Console.WriteLine("\nPROJECT 1 / PART-I\n" +
                              "__________________\n");
            Console.ReadLine();
            
            // döngü ile sonmatrisi yazdırdık
            for (int i=0; i<sonMatris.GetLength(0); i++)
            {
                for (int j=0; j<sonMatris.GetLength(1); j++)
                {
                    Console.WriteLine(i + ".Satır ve " + j + ".Sütun Uzaklığı= " + sonMatris[i, j]);
                    Console.ReadLine();
                }
            }

            Console.WriteLine("\n------------------------\n" +
                                "Cemil Cesur 05180000120\n" +
                                "Emre Ergenç 05180000061\n" +
                                "------------------------");
            Console.ReadLine();
            Console.WriteLine(  "------------------------\n" +
                                "   çıkış için 'enter'\n" +
                                "------------------------");
            Console.ReadLine();



        }
    }
}
