

using System.Security.Cryptography.X509Certificates;

class Product

{
    public long CardNumber;
    public int CVV;
    public string ExpDate;
    public string CardholderName;
    public string Bank;
    public int Balance;

}
public class Program

{
    public static void Main(string[] args)
         
    {
        Product MyCard = new Product();

        MyCard.CardNumber = 4098568578585522;
        MyCard.CVV = 356;
        MyCard.ExpDate = "05/2025";
        MyCard.CardholderName = "Azad Ibrahimli";
        MyCard.Bank = "Unibank";
        MyCard.Balance = 652;


        Console.WriteLine(MyCard.CardNumber);
        Console.WriteLine(MyCard.CVV);
        Console.WriteLine(MyCard.ExpDate);
        Console.WriteLine(MyCard.CardholderName);
        Console.WriteLine(MyCard.Bank);
        Console.WriteLine(MyCard.Balance);


    }


}
      
        
        


       



    







