//namespace banner;
class Banner 
{
    private float width;
    private float height;
    
    public Banner(float width, float height)
    {
      this.width = width;
      this.height = height;  
    }

    public float Width
    {
        get{return width;}
        set{width = value;}
    }
    public float Height
    {
        get{return height;}
        set{height = value;}
    }
    public virtual double Area ()
    {
        return width * height;
    }
    
    public virtual double Price ()
    {
        return 10*Area();

    }
}