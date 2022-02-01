namespace TicketSystemProject;

class Program
{
    static void Main(string[] args)
    {
        string file = "C:/Users/mattz/source/repos/AssignmentWeek1/Files/tickets.txt";
        string choice;
        do
        {
            Console.WriteLine("Type 1 to read data from file");
            Console.WriteLine("Type 2 to create a file from data");
            Console.WriteLine("Type anything else to exit");

            choice = Console.ReadLine();



            if (choice == "1")
            {
                if (File.Exists(file))
                {
                    StreamReader sr = new StreamReader(file);
                    

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] column = line.Split(',');

                        for (int i = 0; i < column.Length; i++)
                        {
                            Console.WriteLine($"{column[i]}");
                        }
                        
                        
                    }

                    sr.Close();
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
            }

            // Read File


            else if (choice == "2")
            {


                // Write File
                StreamWriter sw = new StreamWriter(file, true);
                Console.WriteLine("TicketID");
                var ticketID = Console.ReadLine();

                Console.WriteLine("Summary");
                var summary = Console.ReadLine();

                Console.WriteLine("Status");
                var status = Console.ReadLine();

                Console.WriteLine("Priority");
                var priority = Console.ReadLine();

                Console.WriteLine("Name of Submitter");
                var submitter = Console.ReadLine();

                Console.WriteLine("Name Assigned");
                var assigned = Console.ReadLine();

                Console.WriteLine("How many are watching?");
                var numberWatching = Convert.ToInt16(Console.ReadLine());

                string[] names = new string[numberWatching];
                for (int i = 0; i < (numberWatching); i++)
                {
                    Console.WriteLine("Enter name " + (i + 1));
                    var reply = Console.ReadLine();
                    names[i] = reply;
                }

                var namesWatching = string.Join('|', names);

                var entryRow = $"{ticketID},{summary},{status},{priority},{submitter},{assigned},{namesWatching}";
                sw.WriteLine(entryRow);
                sw.Close();
            }
        } while (choice == "1" || choice == "2");
    }
}