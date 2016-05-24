namespace _06.TruckTour
{
    using System;
    using System.Linq;

    public class TruckTour
    {
        public static void Main()
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());
            PetrolPump[] petrolPumps = new PetrolPump[numberOfPetrolPumps];
            for (int i = 0; i < petrolPumps.Length; i++)
            {
                long[] args = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                long litres = args[0];
                long distance = args[1];
                petrolPumps[i] = new PetrolPump(litres, distance);
            }

            for (int i = 0; i < petrolPumps.Length; i++)
            {
                long litresLeft = 0;
                for (int j = i; j < petrolPumps.Length + i; j++)
                {
                    litresLeft += petrolPumps[j % petrolPumps.Length].Litres;
                    litresLeft -= petrolPumps[j % petrolPumps.Length].DistanceToNextPump;

                    if (litresLeft < 0)
                    {
                        break;
                    }
                }

                if (litresLeft >= 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }

    public class PetrolPump
    {
        public PetrolPump(long litres, long distance)
        {
            this.Litres = litres;
            this.DistanceToNextPump = distance;
        }

        public long Litres { get; set; }

        public long DistanceToNextPump { get; set; }
    }
}