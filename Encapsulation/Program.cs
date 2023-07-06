using Encapsulation;
Console.WriteLine("Write your name then i will show your Belance");
string input = Console.ReadLine();
Security security = new Security();
security.setName(input);
security.setBalance(500000000);
security.getName();
security.getBalance();