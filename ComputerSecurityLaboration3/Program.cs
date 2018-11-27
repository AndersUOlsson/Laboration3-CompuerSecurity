using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerSecurityLaboration3
{
    class Program
    {
        const int SPACE = 32;
        //static private readonly List<string> hexArray = new List<string>();
        static void Main(string[] args)
        {
            string message1 = "32510ba9a7b2bba9b8005d43a304b5714cc0bb0c8a34884dd91304b8ad40b62b07df44ba6e9d8a2368e51d04e0e7b207b70b9b8261112bacb6c866a232dfe257527dc29398f5f3251a0d47e503c66e935de81230b59b7afb5f41afa8d661cb";
            string message2 = "466d06ece998b7a2fb1d464fed2ced7641ddaa3cc31c9941cf110abbf409ed39598005b3399ccfafb61d0315fca0a314be138a9f32503bedac8067f03adbf3575c3b8edc9ba7f537530541ab0f9f3cd04ff50d66f1d559ba520e89a2cb2a83";
            char[] message1Temp = message1.ToCharArray();
            char[] message2Temp = message2.ToCharArray();
            List<int> valuesMessage1 = new List<int>();
            List<int> valuesMessage2 = new List<int>(); 
            foreach (char letter in message1Temp)
            {
                valuesMessage2.Add(Convert.ToInt32(letter));
            }
            foreach (char letter in message2Temp)
            {
                valuesMessage1.Add(Convert.ToInt32(letter));
            }

           
            List<string> XORedMessage = new List<string>();
            for(int i = 0; i < valuesMessage1.Count(); i++)
            {
                int result = valuesMessage1.IndexOf(i) ^ valuesMessage2.IndexOf(i);
                string hex = String.Format("{0:X}", result);
                XORedMessage.Add(hex);
            }

            XORedMessage.ForEach(i => Console.WriteLine("{0}", i));

            Console.ReadKey();
        }
    }
}
