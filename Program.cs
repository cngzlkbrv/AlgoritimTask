List<int> reqem = new List<int>();
while (true)
{
    Console.WriteLine("Y-daxil et eks halda cix");
    string command = Console.ReadLine();
    switch (command)
    {
        case "Y":
            Console.WriteLine("Ededi dqaxil et:");
            int eded = int.Parse(Console.ReadLine());
            reqem.Add(eded);
            break;
        default:
            int cem = 0;
            //foreach(int i in reqem)
            // {
            //     if (i % 2 == 1)
            //     {
            //         cem += i;
            //     }
            //     Console.WriteLine(cem);
            // }
            List<int> newlist = reqem.FindAll(x => x % 2 == 0);
                        newlist.ForEach(x => cem += x);
            return 0;
    }
}
