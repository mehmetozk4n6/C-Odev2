using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorular sorular = new Sorular();
            //sorular.Soru1();
            sorular.Soru2();
            //sorular.Soru3();
            Console.ReadLine();
        }
    }

    class Sorular
    {
        public void Soru1()
        {
            List<int> sayilar = new List<int>();
            Console.WriteLine("write a number : ");
            for (var i = 0; i < 20; i++)
            {
                while (true)
                {
                    string n = Console.ReadLine();
                    try
                    {
                        int num = int.Parse(n);
                        if (num <= 0) throw new Exception("Input type must be integer and higher than zero");
                        else
                        {
                            sayilar.Add(num);
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            List<int> primeNums = new List<int>();
            List<int> NonPrimeNums = new List<int>();

            List<int> primesUnderSeventeen = new List<int> { 2, 3, 5, 7, 11, 13 };

            foreach (int i in sayilar)
            {
                if (i < 17)
                {
                    if (primesUnderSeventeen.Contains(i)) primeNums.Add(i);
                    else NonPrimeNums.Add(i);
                }
                else
                {
                    if (((i + 1) % 6 == 0) | ((i - 1) % 6 == 0)) primeNums.Add(i);
                    else NonPrimeNums.Add(i);
                }
            }

            Console.WriteLine("Prime Nums");
            foreach (var j in primeNums.OrderBy(x => x)) Console.Write(j.ToString() + " ");
            Console.WriteLine("");
            Console.WriteLine("Prime Nums Average : " + ((float)primeNums.Sum() / (float)primeNums.Count()).ToString());

            Console.WriteLine("Non Prime Nums");
            foreach (var j in NonPrimeNums.OrderBy(x => x)) Console.Write(j.ToString() + " ");
            Console.WriteLine("");
            Console.WriteLine("Non Prime Nums Average : " + ((float)NonPrimeNums.Sum() / (float)NonPrimeNums.Count()));
        }

        public void Soru2()
        {
            List<int> nums = new List<int>();
            Console.WriteLine("write a number : ");
            for (var i = 0; i < 20; i++)
            {
                while (true)
                {
                    string n = Console.ReadLine();
                    try
                    {
                        int num = int.Parse(n);
                        nums.Add(num);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            List<int> maxNums = new List<int>();
            List<int> minNums = new List<int>();
            for (int j = 0; j < 3; j++)
            {
                int maxNum = nums.Max();
                Console.WriteLine("Maximum element " + maxNum);
                //Console.WriteLine("Maximum element " + maxNum.GetType());
                maxNums.Add(maxNum);
                maxNums.Remove(maxNum);

                int minNum = nums.Min();
                Console.WriteLine("Minimum element " + minNum);
                minNums.Add(minNum);
                minNums.Remove(minNum);
            }

            Console.WriteLine("nums");
            foreach (int k in nums) Console.WriteLine(k);

            Console.WriteLine("maxNUms");
            foreach (int k in maxNums) Console.WriteLine(k);

            Console.WriteLine("minNums");
            foreach (int k in minNums) Console.WriteLine(k);
        }

        public void Soru3()
        {
            Console.WriteLine("Give me a sentence");
            string sentence = Console.ReadLine();
            string pattern = @"[aeıuüioö]";
            Regex rg = new Regex(pattern);
            MatchCollection vowelSounds = rg.Matches(sentence);
            foreach (Match match in vowelSounds) Console.WriteLine(match);
        }
    }
}

//0
//9
//8
//7
//6
//5
//4
//3
//2
//1
