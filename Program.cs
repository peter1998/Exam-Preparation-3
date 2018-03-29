
namespace Problem_2___Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;




    public class Program
    {
        public static void Main(string[] args)
        {
                   var list = Console.ReadLine().Split().ToList();
            string[] commands = new string[5];
            string input = string.Empty;
            int start = 0;
            int count = 0;
            while (true)
            {
                try
                {
                    commands = Console.ReadLine().Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);
                    input = commands[0];
                    if (input == "end")
                    {
                       

                        Console.WriteLine($"{'['}{string.Join(", ", list)}{']'}");
                        return;
                    }
                    else
                    {
                        switch (input)
                        {
                            case "reverse":
                                start = int.Parse(commands[2]);
                                count = int.Parse(commands[4]);

                                if (IsValid(list,start,count))
                                {
                                    list.Reverse(start, count);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input parameters.");
                                }


                                break;

                            case "rollRight":
                                count = int.Parse(commands[1]);
                                if (IsValid(list, start, count))
                                {
                                    rollRight(list, count);
                                }
                                
                                break;
                            case "rollLeft":
                                count = int.Parse(commands[1]);
                                if (IsValid(list, start, count))
                                {
                                    rollLeft(list, count);
                                }
                                
                                break;
                            case "sort":
                                start = int.Parse(commands[2]);
                                count = int.Parse(commands[4]);
                                if (IsValid(list, start, count))
                                {
                                    Sort(list,start, count);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input parameters.");
                                }

                               
                                break;
                            default:
                                break;
                        }
                       
                    }                }
                catch (IndexOutOfRangeException )
                {

                    Console.WriteLine("Invalid input parameters.");
                }
            }

            
        }

        private static void Sort(List<string> list, int start, int count)
        {
            var resultarray = list.Skip(start).Take(count).OrderBy(x => x).ToList();
            list.RemoveRange(start, count);
            list.InsertRange(start, resultarray);
        }

        private static void rollLeft(List<string> list, int count)
        {
            count = count % list.Count();
            for (int i = 0; i < count; i++)
            {
                string firstElem = list[0];
                for (int j = 0; j < list.Count-1; j++)
                {
                    list[j] = list[j + 1];
                }

                list[list.Count - 1] = firstElem;
            }
           
        }

        private static bool IsValid(List<string> arr, int start, int count)
        {
            if (start>=0 && start<arr.Count && count>0 && (start + count)<=arr.Count)
            {
                return true;
            }
            return false;
        }

        private static void rollRight(List<string> arr, int count)
        {
            count = count % arr.Count();
            for (int i = 0; i < count; i++)
            {
                string lastElem = arr.Last();
                arr.RemoveAt(arr.Count - 1);
                arr.Insert(0, lastElem);
            }

        }

      
    }
}
