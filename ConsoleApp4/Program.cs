using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Восьмая задача
            
            Console.Write("\n Enter Text ");
            string A = Console.ReadLine();
            Console.WriteLine(A);
            Console.Write("\n Enter the position of the character you want to delete ");
            int a_ydalenie = Convert.ToInt32(Console.ReadLine());
            A = A.Remove(a_ydalenie - 1, 1);
            Console.WriteLine("\n Result " + A);
            #endregion

            #region Девятая задача

            Console.Write("\n Enter the character you want to remove ");
            string a_vipolnyaem_ydalenie = Console.ReadLine();
            while (true)
            {
                if (A.IndexOf(a_vipolnyaem_ydalenie) == -1)
                    break;
                else
                {
                    int indeks = A.IndexOf(a_vipolnyaem_ydalenie);
                    A = A.Remove(indeks, 1);
                }
            }
            Console.WriteLine("\n Result " + A);
            #endregion

            #region Десятая задача

            Console.Write("\n Enter the character you want to insert ");
            string a_vstl = Console.ReadLine();
            Console.Write("\n Enter the position where you want to paste ");
            int a_index_insert = Convert.ToInt32(Console.ReadLine());
            A = A.Insert(a_index_insert - 1, a_vstl);
            Console.WriteLine("\n Result " + A);
            #endregion

            #region Одинадцатая задача

            Console.Write("\n Enter Text ");
            string Ben = Console.ReadLine();
            bool proverka = true;
            for (int i = 0; i < Ben.Length / 2; i++)
            {
                if (Ben[i] == Ben[Ben.Length - 1 - i])
                    continue;
                else
                {
                    proverka = false;
                    break;
                }
            }
            if (proverka)
                Console.WriteLine("\n The word is a palindrome ");
            else
                Console.WriteLine("\n The word is not a palindrome ");
            #endregion

            #region Двенадцатая задача

            Console.Write("Введите текст: ");
            string C = Console.ReadLine();
            string[] C_count = C.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Кол-во слов = {0}", C_count.Length);
            #endregion

            #region Тринадцатая задача

            Console.Write("\n Enter Text ");
            string Den = Console.ReadLine();
            Console.Write("\n Enter the text you are looking for ");
            string poisk = Console.ReadLine();
            Console.Write("\n Enter the text you want to paste ");
            string lojem = Console.ReadLine();
            if (Den.IndexOf(poisk) != -1)
                Den = Den.Replace(poisk, lojem);
            else
                Console.WriteLine("\n Enter the text you are looking for ");
            Console.WriteLine("\n Result [0]", Den );
            #endregion

            #region Четырнадцатая задача 

            Console.Write("\n Enter Text ");
            string Enum = Console.ReadLine();
            string[] E_pred = Enum.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] E_pred_buf = Enum.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < E_pred.Length - 1; i++)
            {
                Enum = Enum.Replace(E_pred[i], E_pred_buf[i + 1]);
                Enum = Enum.Replace("   " + E_pred[i + 1], "  " + E_pred_buf[i]);
            }
            Console.WriteLine("\n Result [0]", Enum);
            #endregion

            #region Пятнадцатая задача

            Console.Write("\n Enter Text  ");
            string Fear = Console.ReadLine();
            string[] Fear_rind = Fear.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int Fear_podch = 0;
            for (int i = 0; i < Fear_rind.Length; i++)
            {
                if (Fear_rind[i][Fear_rind[i].Length - 1] == 'э' || Fear_rind[i][Fear_rind[i].Length - 1] == 'у' || Fear_rind[i][Fear_rind[i].Length - 1] == 'о' ||
                    Fear_rind[i][Fear_rind[i].Length - 1] == 'и' || Fear_rind[i][Fear_rind[i].Length - 1] == 'е' || Fear_rind[i][Fear_rind[i].Length - 1] == 'е' ||
                    Fear_rind[i][Fear_rind[i].Length - 1] == 'ы' || Fear_rind[i][Fear_rind[i].Length - 1] == 'ы' || Fear_rind[i][Fear_rind[i].Length - 1] == 'ю' || Fear_rind[i][Fear_rind[i].Length - 1] == 'я')
                    Fear_podch++;
            }
            Console.WriteLine("\n Number of vowels :  [0]", Fear_podch);
            #endregion
        }
    }
}