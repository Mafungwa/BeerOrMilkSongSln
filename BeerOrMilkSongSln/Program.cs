namespace BeerOrMilkSongSln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentance = new string[5];

            sentance[0] = " bottles of beer on the wall ";
            sentance[1] = " bottles of beer. \n";
            sentance[2] = "Take one down and pass it around, ";            
            sentance[3] = " bottles of beer on the wall";
           
                for (int i = 99; i >= 2; i--)
            {
                if (i == 2) 
                {
                    Console.Write(
                 +i +
                 sentance[0]
                 + i +
                 sentance[1]
                 );
                  Console.Write("Take one down and pass it around, ");
                    Console.WriteLine("1 bottle of beer on the wall");
                }

                else
                {
                  
                    Console.WriteLine(
                   +i +
                   sentance[0]
                   + i +
                   sentance[1]
                   +
                   sentance[2]
                   +
                   (i - 1)
                   +
                   sentance[3]);
                }
                          

            }
            Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
        }
    }
}
