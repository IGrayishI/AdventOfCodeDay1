using System.Threading.Channels;

namespace AdventOfCodeDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();
            GeneratedString generatedString = new GeneratedString();
            foreach (string sampleString in generatedString.list)
            {
                List<int> ints = new();
                
                for (int i = 0; i < sampleString.Length; i++)
                {
                    
                    string letter = sampleString[i].ToString();
                    if (int.TryParse(letter, out int digit))
                    {
                        ints.Add(digit);
                    }
                }
                
                    int firstInt = ints.FirstOrDefault();
                    int secondInt = ints.LastOrDefault();
                    string concatenated = firstInt.ToString() + secondInt.ToString();

                    int result = int.Parse(concatenated);
                    Console.WriteLine(result);
                    listOfNumbers.Add(result);

            }
            int sumtotal = 0;
            foreach (int i in listOfNumbers)
            {
                sumtotal += i;
            }
            Console.WriteLine(sumtotal);
        }
        
    }
}