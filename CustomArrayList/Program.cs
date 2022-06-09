using System;

namespace CustomArrayList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomArrayList list = new CustomArrayList();
            list.Add(1);
            list.Add("aaa");
            list.Add(30.45);
            list.Add( true);
            list.Insert(2, 44);
            Console.WriteLine(list);


            list.Remove(true);
            Console.WriteLine(list);

            list.Add("aaa");
            list.Add(30.45);


            foreach (var element in list)
            {
                Console.WriteLine(element);
            }


            Console.WriteLine(list.LastIndexOf("aaa"));
        }
    }

}