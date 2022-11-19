namespace banner;

class CurvedBanner : Banner
 {
     private float radius;
     public float Radius
     {
        get {return radius;}
        set {radius = value;}
     }
     public CurvedBanner(float width, float height, float radius) : base(width, height)
     {
        this.radius = radius;
     }
     public override double Area()
    {
        return base.Area() - 0.86 * radius * radius;
    }
 }


