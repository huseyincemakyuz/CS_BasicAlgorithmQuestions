using System;

namespace basicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.soru
            
            Console.Write("Sayi adedini giriniz:");
            int n = int.Parse(Console.ReadLine());
            List<int> evenNums = new List<int>();

            for(int i=0;i<n;i++){
                Console.Write("{0}. sayıyı girin:",i+1);
                evenNums.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Çift olan sayılar:");
            foreach (var nums in evenNums)
            {
                if(nums%2 == 0){
                    Console.WriteLine(nums);
                }
                
            }

            // 2.soru

            Console.WriteLine("Lütfen iki adet tam sayi giriniz");
            Console.Write("İlk sayinizi giriniz:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayinizi giriniz:");
            int m = int.Parse(Console.ReadLine()); 

            int[] nums = new int[n];

            Console.WriteLine("Lütfen "+n+" adet sayı giriniz");
            for (int i = 0; i<n; i++)
            {
                Console.Write("{0}. sayıyı girin:",i+1);
                nums[i] = int.Parse(Console.ReadLine());
            }

            foreach (var num in nums)
            {
                if(num == m || m % num == 0){
                    Console.WriteLine(num);
                }
            }

            // 3.soru

            Console.Write("Lütfen bir sayi giriniz:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen "+n+" adet kelime giriniz");
            string[] words = new string[n];

            for (int i = 0; i<n; i++)
            {
                Console.Write("{0}. kelimeyi girin:",i+1);
                words[i] = Console.ReadLine();
            }

            for (int i = words.Length-1; i>=0; i--)
            {
                Console.WriteLine(words[i]);
            }

            // 4.soru

            Console.WriteLine("Lütfen bir cümle yazınız:");
            string sentence = Console.ReadLine();
            string[] sArray = sentence.Split(' '); //stringimizi split ettiğimiz arrayin uzunluğu kelime sayısını verir.
            char[] letterArray = sentence.ToCharArray(); // stringimizi karakterlerine ayırdık.

            int letterCount = 0;

            foreach (var letter in letterArray)
            {
                if(char.IsLetter(letter)){  
                    letterCount++;
                }
            }

            Console.WriteLine("Cümlemizdeki Kelime Sayımız: "+sArray.Length);
            Console.WriteLine("Cümlemizdeki Harf Sayımız: "+letterCount);
        }
    }
}