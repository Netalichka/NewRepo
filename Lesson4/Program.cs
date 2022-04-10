// See https://aka.ms/new-console-template for more information


class MyArray { 

  static void Main(string[] args)
    {

    int[] array = new int[20];

        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        { 
        array[i] = rnd.Next(-10000, 10000);

            Console.Write($"{array[i]}\t");

        }
 
    }
}

class SumArray
{






}