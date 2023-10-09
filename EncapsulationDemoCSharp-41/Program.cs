using EncapsulationDemoCSharp_41;

var seth = new Person();

seth.Name = "Seth";
seth.Age = 29;


seth.AddMoney(200.00);
Console.WriteLine(seth.CheckWallet());

seth.AddMoney(2000.00);
Console.WriteLine(seth.CheckWallet());
