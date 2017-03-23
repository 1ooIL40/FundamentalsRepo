using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int firstPlayerPokemons = int.Parse(Console.ReadLine());
            int secondPlayerPokemon = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int count = 1;

            for (int j = 1; j <= firstPlayerPokemons; j++)
            {
                for (int k = 1; k <= secondPlayerPokemon; k++)
                {

                    Console.Write("({0} <-> {1}) ", j, k);
                    count++;

                    if(count > maxBattles)
                    {
                        return;
                    }
                }
            }

        }
    }
}
