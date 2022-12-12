namespace Home_Work_4_1
{
    internal class Program
    {
        static void Main()
        {
            bool check = true;
            string action;
            do
            {
                Console.WriteLine($"\nChoose your File type: XML \\ TXT \\ DOC ");
                string type = Console.ReadLine();

                switch (type.ToUpper())
                {
                    case "XML":
                        AbstractHandler xmlFile = new XMLHandler();

                        Console.Write("\n1 Open file.\n2 Create file.\n3 Change file\n4 Save file\nChoose number for action: ");
                        action = Console.ReadLine();

                        switch (action)
                        {
                            case "1":
                                xmlFile.Open();
                                break;
                            case "2":
                                xmlFile.Create();
                                break;
                            case "3":
                                xmlFile.Change();
                                break;
                            case "4":
                                xmlFile.Save();
                                break;
                            default:
                                Console.WriteLine("\nWrong number.");
                                break;
                        }
                        break;
                    case "TXT":
                        AbstractHandler txtFile = new TXTHandler();

                        Console.Write("\n1 Open file.\n2 Create file.\n3 Change file\n4 Save file\nChoose number: ");
                        action = Console.ReadLine();

                        switch (action)
                        {
                            case "1":
                                txtFile.Open();
                                break;
                            case "2":
                                txtFile.Create();
                                break;
                            case "3":
                                txtFile.Change();
                                break;
                            case "4":
                                txtFile.Save();
                                break;
                            default:
                                Console.WriteLine("\nWrong number.");
                                break;
                        }
                        break;
                    case "DOC":
                        AbstractHandler docFile = new DOCHandler();

                        Console.Write("\n1 Open file.\n2 Create file.\n3 Change file\n4 Save file\nChoose number: ");
                        action = Console.ReadLine();

                        switch (action)
                        {
                            case "1":
                                docFile.Open();
                                break;
                            case "2":
                                docFile.Create();
                                break;
                            case "3":
                                docFile.Change();
                                break;
                            case "4":
                                docFile.Save();
                                break;
                            default:
                                Console.WriteLine("\nWrong number.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("\nIncorrect File type");
                        break;
                }
            }
            while (check);

            Console.ReadKey();
        }
    }
}