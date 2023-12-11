class BankApp
{
    public static Bank bank = new Bank();
    public static int Main(string[] args)
    {
        while (true)
        {
            System.Console.WriteLine("Choose one of the options:");
            System.Console.WriteLine("1. Create account");
            System.Console.WriteLine("2. Delete account");
            System.Console.WriteLine("3. Transfer");
            System.Console.WriteLine("4. Print users");
            System.Console.WriteLine("0. Quit");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
                CreateAccounts();

            else if (input == 2)
                Delete();

            else if (input == 3)
                Transfer();

            else if (input == 4)
                Print();

            else if (input == 0)
            {
                System.Console.WriteLine("Quitting...");
                break;
            }
            else
                System.Console.WriteLine("Please, enter valid operation number: ");

        }

        void CreateAccounts()
        {
            System.Console.WriteLine("Please, enter client's name: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Please, enter client's id");
            long id = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Please, enter client's initial balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            bank.CreateAccount(name, id, balance);

        }
        void Delete()
        {
            System.Console.WriteLine("Please, enter user's id");
            long id = Convert.ToInt32(Console.ReadLine());
            bank.DeleteAccount(id);
        }

        void Transfer()
        {
            System.Console.WriteLine("Please, enter sender's id");
            long sender = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Please, enter reciever's id");
            long reciever = Convert.ToInt32(Console.ReadLine());
            if (reciever == sender){
                System.Console.WriteLine("You cannot transfer into your account");
                return;
            }
            System.Console.WriteLine("Please, enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            bank.TransferMoney(sender, reciever, amount);
        }

        void Print()
        {
            if (bank.clients.Count == 0)
                System.Console.WriteLine("There are no clients");

            System.Console.WriteLine("all available clients' list:");
            foreach (Client client in bank.clients)
                System.Console.WriteLine("Client name: " + client.name);

        }
        return 0;

    }

}