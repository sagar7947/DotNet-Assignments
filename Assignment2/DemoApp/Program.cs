using System;
namespace hospital;
class Program
{
    public static void Main(string[] args)
    {   
        Console.WriteLine(" Welcome in Sagar Hospital !!");
        //if ( args.Length<5)
        int id = int.Parse(args[0]);
        string name =args[1];
        int bed = int.Parse(args[2]);
        int Days = int.Parse(args[3]);
        double discount = double.Parse(args[4]);
        Console.WriteLine("Patient Id is {0},{1},{2},{3}",id,name,bed,Days);
        var p = new Patient(id,name,bed,Days);
        Console.WriteLine("Amount for regular Patient : {0:0.00}",p.GetBillAmount());
        var q = new InHousePatient(id,name,bed,Days,discount);
        Console.WriteLine("Amount for Special Patient : {0:0.00}",q.GetBillAmount());

    
        



    }

}