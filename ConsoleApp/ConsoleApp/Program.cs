using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region homework
            //string[] response = FindLetter(new string[] { "Elgiz", "Memmed", "Huseyn","mmmm","dddd","ccc" }, 'e');
            //Console.WriteLine(String.Join(" ", response));
            //Console.WriteLine(response.Length);
            #endregion

            #region out,ref
            //int a=1;
            //ChangeNum(out a);
            //Console.WriteLine(a);

            //int[] arr = { 10, 20, 30 };
            //ChangeArrElm(arr);
            //Console.WriteLine(arr[0]);
            #endregion

            #region consol app,TryParse
            //Console.WriteLine("Eded daxil edin: ");
            //string num = Console.ReadLine();
            //int x;
            //bool result = int.TryParse(num, out x);
            ////Console.WriteLine(x);
            ////Console.WriteLine(result);

            //while (!result)
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //    num = Console.ReadLine();
            //    result = int.TryParse(num, out x);
            //}
            //Console.WriteLine(x);
            #endregion

            //StringBuilder str = new StringBuilder();
            //str.Append("abcdefgh");
            //str.Remove(0, 4);
            //Console.WriteLine(str);

            Console.WriteLine(ReversWordOfText("Salam Rafiq bey"));
        }

        static StringBuilder ReversWordOfText(string sent)
        {
            StringBuilder result = new StringBuilder();
            string[] words = sent.Split(' ');
            foreach (string item in words)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    result.Append(item[i]);
                }
                if (item != words[words.Length - 1])
                {
                    result.Append(' ');
                }
            }
            return result;
        }

        //static string ReversWodOfText(string sent)
        //{
        //    string result = "";
        //    string[] words = sent.Split(' ');
        //    foreach (string item in words)
        //    {
        //        for(int i = item.Length - 1; i >= 0; i--)
        //        {
        //            result += item[i];
        //        }
        //        if(item!= words[words.Length - 1])
        //        {
        //            result += " ";
        //        }
        //    }

        //    return result;
        //}

        #region out,ref
        //static void ChangeNum(out int a)
        //{
        //    a = 10;
        //    Console.WriteLine(a);
        //}

        //static void ChangeArrElm(int[] arr)
        //{
        //    arr[0] = 100;
        //    Console.WriteLine(arr[0]);
        //}
        #endregion

        #region homework, array resize
        //static string[] FindLetter(string[] arr,char letter)
        //{
        //    string[] result = { };
        //    int count = 0;
        //    foreach (string item in arr)
        //    {
        //        foreach (char l in item.ToLower())
        //        {
        //            if (l == letter)
        //            {
        //                Array.Resize(ref result, result.Length + 1);
        //                result[count] = item;
        //                count++;
        //                //Console.WriteLine(item);
        //                break;
        //            }
        //        }
        //        //Console.WriteLine(item.Contains(letter));
        //    }
        //    return result;
        //}
        #endregion
    }
}
