using System;
namespace banner;
class Program

{
    public static void Main(string[] args)
    {
        float width = float.Parse(args[0]);
        float height = float.Parse(args[1]);
        float radius = float.Parse(args[2]);
        int copies = int.Parse(args[3]);

        Console.WriteLine("banner size is {0},{1}", width, height);
        var b = new Banner(width, height);
        Console.WriteLine("Price of regular banner is {0}",b.Price());
        Console.WriteLine("Area of regular banner:{0:0.00}", b.Area());
        var c = new CurvedBanner(width, height, radius);
        Console.WriteLine("Area of curved banner:{0:0.00}", c.Area());
        
        Console.WriteLine("price of banner with given number of copies:{0:0.00}", BannerPrice1.BannerPrice(b,copies));

    }
}

class BannerPrice1
{
    public static double BannerPrice(Banner info, int copies)
    {
        float rate = copies < 5 ? 0.8f : 0.75f;

        return copies * rate * info.Area();
    }
}