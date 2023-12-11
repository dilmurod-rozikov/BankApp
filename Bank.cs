class Bank
{
    public List<Client> clients = new List<Client>();

    public void CreateAccount(string name, long id, double balance)
    {
        Account account = new Account(id, balance);

        Client client = new Client(name, account);

        foreach(Client c in clients)
        {
            if(c.account.Id == id)
            {
                System.Console.WriteLine("Can't add. There is a users with same id.");
                return;
            }

        }
        clients.Add(client);

        System.Console.WriteLine($"Created account for {name} with id: {id} and balance: {balance}");
    }

    public void DeleteAccount(long id)
    {
        Client clientRemove = null;
        foreach(Client client in clients)
        {
            if(client.account.Id == id)
            {
                clientRemove = client;
                break;
            }

        }
        if(clientRemove!= null)
        {
            clients.Remove(clientRemove);
            System.Console.WriteLine($"Account deleted for {clientRemove.name}");
            return;
        }
        System.Console.WriteLine("not found");

    }
    public void TransferMoney(long senderId, long recieverId, double amount)
    {
        Client sender = null;
        Client reciever = null;
        foreach(Client client in clients)
        {
            if(client.account.Id == senderId)
            {
                sender = client;
                break;
            }
        }
        foreach(Client client in clients)
        {
            if(client.account.Id == recieverId)
            {
                reciever = client;
                break;
            }
        }
        
        if(sender!= null && reciever!= null)
        {
            bool ans = sender.account.IsWithdrew(amount);
            if(!ans)
            {
                System.Console.WriteLine("Not enough money");
                return;
            }
            System.Console.WriteLine($"Send by {sender.name}: " + amount);

            reciever.account.Deposit(amount);
            System.Console.WriteLine($"Recieved by {reciever.name}:" + amount);
            
            sender.account.PrintBalance(sender.name);
            reciever.account.PrintBalance(reciever.name);

        }
        else
            System.Console.WriteLine("not found");
        
    }

}