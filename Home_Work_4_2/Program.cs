namespace Home_Work_4_2
{
    internal class Program
    {
        static void Main()
        {
            Player player = new Player();

            bool check = true;
            string action;

            while (check)
            {
                Console.WriteLine("Choose:\n1 Play song\n2 Record song");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    IPlayable playerPlay = player as IPlayable;
                    Console.WriteLine("\n1 Start play\n2 Pause play\n3 Stop play");
                    action = Console.ReadLine();

                    switch (action)
                    {
                        case "1":
                            playerPlay.Play();
                            break;
                        case "2":
                            playerPlay.Pause();
                            break;
                        case "3":
                            playerPlay.Stop();
                            break;
                        default:
                            continue;
                    }
                }
                else if (choose == "2")
                {
                    IRecodable playerRecord = player as IRecodable;
                    Console.WriteLine("\n1 Start record\n2 Pause record\n3 Stop record");
                    action = Console.ReadLine();

                    switch (action)
                    {
                        case "1":
                            playerRecord.Record();
                            break;
                        case "2":
                            playerRecord.Pause();
                            break;
                        case "3":
                            playerRecord.Stop();
                            break;
                        default:
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("\nWrong input");
                }
            }
        }
    }
}