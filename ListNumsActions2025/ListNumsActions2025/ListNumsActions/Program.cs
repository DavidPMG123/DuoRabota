namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "contains":
                        
                        //TODO
                        break;


                    case "add":
                        int element1 = int.Parse(cmd[1]);
                        int element2 = int.Parse(cmd[2]);

                        nums.Add(element1 + element2);
                        break;

                    case "countl":
                          int number = int.Parse(cmd[1]);
                        int count = nums.Count(n => n > number);
                        Console.WriteLine(count);
                        break;




                    //TO DO
                    default:
                        break;
                }
            }
        }
    }
}
