namespace homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(110, "Alice", 28);
        cus1.PrintCusInfo();

        Customer cus2 = new Customer(111, "Bob", 30);
        cus2.PrintCusInfo();

        cus1.ChangeID(220);
        cus1.PrintCusInfo();

        cus2.ChangeID(221);
        cus2.PrintCusInfo();

        cus2.CompareAge(cus1);
    }
}

class Customer{
    public int cus_id {get;set;} = 0;
    public string cus_name = string.Empty;
    public int cus_age = 0;
    public Customer(int cus_id, string cus_name, int cus_age){
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id){
        this.cus_id = new_id;
    }

    public void PrintCusInfo(){
        Console.WriteLine($"Customer ID: {cus_id}, Customer name: {cus_name}, Customer age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer){
        if(objCustomer.cus_age > this.cus_age) {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        } else {
            Console.WriteLine($"{this.cus_name} is older.");
        }
    }
}