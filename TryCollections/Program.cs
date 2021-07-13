using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCollections.Models;

namespace TryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = GetArrayList();
            // PrintArrayList(arrayList);
            CompareSpeed();
            Console.ReadLine();

        }

        public static void CompareSpeed()
        {
            var list = new List<int>();
            var dic = new Dictionary<int, int>();
            var arrayList = new ArrayList();
            var hashtable = new Hashtable();

            for (var i = 0; i < 1000000; i++)
            {
                list.Add(i);
                arrayList.Add(i);
                hashtable.Add(i, i);
                dic.Add(i, i);

               
            }

            var swList = new Stopwatch();
            var swarrList = new Stopwatch();
            var swdic = new Stopwatch();          
            var swhashtable = new Stopwatch();

            for (int i = 2000; i < 12000; i++)
            {
                swList.Start();
                int temp1 = list[list.IndexOf(i)];
                swList.Stop();

                swarrList.Start();
                int temp2 = (int)arrayList[arrayList.IndexOf(i)];
                swarrList.Stop();

                swdic.Start();
                int temp3 = dic[i];
                swList.Stop();

                swList.Start();
                int temp4 = (int)hashtable[i];
                swhashtable.Stop();

            }

            Console.WriteLine(

                $@"
                     List:{swList.ElapsedMilliseconds}
                     ArrayList:{swarrList.ElapsedMilliseconds}
                     HashTable:{swhashtable.ElapsedMilliseconds}
                     Dictionary:{swdic.ElapsedMilliseconds}
                            ");


        }

        #region HasTable
        public static void ExecDictionary()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1, "Hello");
            dic.Add(5, DateTime.Today.ToString("yyyy/MM/dd HH:mm:ss"));
            dic.Add(6, "will removed");

            Console.WriteLine("Total count:" + dic.Count);
            if (dic.ContainsKey(6))
                dic.Remove(6);
            Console.WriteLine("Total count:" + dic.Count);

            var item = dic[5];
            Console.WriteLine(item.ToString());

            foreach (KeyValuePair<int, string> entry in dic)
            {
                Console.WriteLine($"Key:{entry.Key},Value:{entry.Value}");

            }


            //  hashtable.Add("1","Alice");
            //  hashtable.Add("2", "Bruce");
            //  hashtable.Add(DateTime.Today, "Alice");


            ////  hashtable.Add("2", "KK");

            //  if (hashtable.ContainsKey("2"))
            //      hashtable.Remove("2");
            //  var notExistItem = hashtable["2"];

            //  Console.WriteLine("Total count:" + hashtable.Count);

            //  var item = hashtable[DateTime.Today];
            //  Console.WriteLine(item.ToString());

            //  foreach (DictionaryEntry entry in hashtable)
            //  {
            //      Console.WriteLine($"Key:{entry.Key},Value:{entry.Value}");
            //  }

        }


        #endregion

        #region Array
        public static void ExecArray()
        {
            int[] arr = { 2, 1, 3 };
            int[] newArray = { 0, 0, 0 };
            Array.Copy(arr, newArray, 3);
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            int indexOf = Array.IndexOf(arr, 2);
            Console.WriteLine("Index of:" + indexOf);
            Console.WriteLine("Iength:" + arr.Length);

            Array.Resize(ref arr, 10);
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region List
        private static void ExecList()
        {
            List<int> list = new List<int>();
            list.Add(12);
            for (var i = 0; i < 20; i++)
            {
                list.Add(i + 100);
            }
            list.Insert(5, 500);
            list.Remove(110);
            int a = list[0];
            Console.WriteLine(a);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void ExecList2()
        {
            var list = new List<Student>();
            Student stusent = new Student()
            {
                No = "1",
                Name = "Name1"
            };

            list.Add(stusent);
            for (var i = 0; i < 20; i++)
            {
                Student studentTemp = new Student()
                {
                    No = (i + 20).ToString(),
                    Name = "Name" + (i + 20)
                };
                list.Add(studentTemp);
            }

            Student a = list[0];
            Console.WriteLine(a.GetText());

            foreach (var item in list)
            {
                Console.WriteLine(item.GetText());
            }
        }
        #endregion

        #region ArrayList

        private static ArrayList GetArrayList()
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                arrayList.Add(i);
                arrayList.Add("ok" + i);
            }


            arrayList.Remove(8);
            arrayList.Insert(1, "The inserted item.");
            arrayList[0] = "Replaced Item";
            arrayList.Add(DateTime.Now);

            return arrayList;
        }

        private static void PrintArrayList(ArrayList arrayList)
        {
            Console.WriteLine("Total items count:" + arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
            }

            int indexOf1 = arrayList.IndexOf("The inserted item.");
            Console.WriteLine("Find [The inserted item.]" + indexOf1);

            int indexOf2 = arrayList.IndexOf("Hello world");
            Console.WriteLine("Find [Hello world.]" + indexOf2);
            arrayList.Clear();
            Console.WriteLine("Total items count after clear:" + arrayList.Count);


        }
        #endregion



    }
}
