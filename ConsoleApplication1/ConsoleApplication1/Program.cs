using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Pham", "Ngoc", "Duy" };


            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");


            Console.WriteLine("Nhap vao Size Mang");
            int size = int.Parse(Console.ReadLine());
            Stack st = new Stack(size);
            st.Push(4);
            st.Push(6);
            st.Push(8);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Count());
            st.Clear();
          
        }
    }
}
