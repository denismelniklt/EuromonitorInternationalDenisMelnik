using System;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prašau įveskite generacijų skaičių.");
            int.TryParse(Console.ReadLine(), out int numberOfGenerations);

            var life = new Life(10);

            // inicijuojame šabloną "Toad"
            life.ToggleCell(4, 1);
            life.ToggleCell(4, 2);
            life.ToggleCell(4, 3);
            life.ToggleCell(5, 0);
            life.ToggleCell(5, 1);
            life.ToggleCell(5, 2);

            for (var i = 0; i < numberOfGenerations; i++)
            {
                if (i == 0)
                {
                    life.BeginGeneration();
                }
                else
                {
                    life.Update();
                }

                life.Wait();
                OutputBoard(life);
            }

            Console.ReadKey();
        }

        private static void OutputBoard(Life life)
        {
            var line = new String('-', life.Size);

            Console.WriteLine(line);

            for (int y = 0; y < life.Size; y++)
            {
                for (int x = 0; x < life.Size; x++)
                {
                    Console.Write(life[x, y] ? "X" : "-");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
  