using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingAndBST
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**Hashing Problem**");
            Console.WriteLine("**USE CASE 1-To find frequency of words ** ");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            MapNode<string, int> myMapNode = new MapNode<string, int>(6);
            switch (num)
            {
                case 1:
                    string[] words = { "to", "be", "or", "not", "to", "be" };
                    int count = 1;
                    foreach (string i in words)
                    {
                        count = myMapNode.CheckHash(i);
                        if (count > 1)
                        {
                            myMapNode.Add(i, count);
                        }
                        else
                        {
                            myMapNode.Add(i, 1);
                        }
                    }

                    IEnumerable<string> uniqueItems = words.Distinct<string>();
                    foreach (var i in uniqueItems)
                    {
                        myMapNode.Display(i);
                    }
                    break;
                default:
                    Console.WriteLine("Enter the valid option!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
