class Account
{
    private long id;
    private double balance;
    public long Id { 
        get
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }  
     }
    public double Balance 
    { 
        get
        {
            return this.balance;

        } 
        set
        {
            this.balance = value    ;
        } 
    }
    public Account(long id, double balance)
    {
        this.id = id;
        this.balance = balance;
    }
    public void Deposit(double amount)
    {
        if(amount <= 0)
        {
            System.Console.WriteLine("Not a valid amount of money");
            return;
        }

        this.balance += amount;
    }
    public bool IsWithdrew(double amount)
    {
        if(amount > balance){
            System.Console.WriteLine("Please, try out less amount");
            return false;
        }
        balance -= amount;
        return true;
    }

    public void PrintBalance(string name)
    {
        System.Console.WriteLine($"{name}'s balance: {balance}");
    }

}