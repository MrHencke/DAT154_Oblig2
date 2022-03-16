using CelestialsLib;


namespace Program
{
    class Program
    {
        private bool exit = false;
        static void Main(string[] args)
        {
            Program p = new Program();
            while (!p.exit)
            {
            p.ProgramLoop();
            }
        }

        void ProgramLoop()
        {
            int time;
            SolarSystem milkyWay = new MilkyWay();
            time = GetTime();
            Console.WriteLine("Please enter an object: ");
            string cmd = Console.ReadLine()!.ToLower();
            if (cmd == "") cmd = "sun";
            CelestialObject obj = milkyWay.objects.Where(i => i.Name.ToLower() == cmd).FirstOrDefault()!;
            if (obj == null) return;
            if (obj.Name == "Sun")
            {
                milkyWay.objects.ForEach(i => 
                { 
                i.Draw();
                i.WritePosition(time);
                });
            }
            else
            {
                obj.Draw(time);
            }
            exit = true;
        }

        static int GetTime()
        {
            int time;
            while (true)
            {
                    Console.WriteLine("Please enter a time: ");
                try
                {
                       return time = int.Parse(Console.ReadLine()!);
                    }
                    catch (Exception) { }
            }
        }
    }
}