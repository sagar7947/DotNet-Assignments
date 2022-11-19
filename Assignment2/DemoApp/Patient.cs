namespace hospital;

class Patient
{
    private int patientid;
    private String patientname;
    private int bedtype;
    private int noofdays;

    public Patient(int patientId,String patientname,int bedtype,int noOfDays)
    {
        this.patientid = patientId;
        this.patientname = patientname;
        this.bedtype = bedtype;
        this.noofdays = noOfDays;

    }
    
    public Patient(): this(101,"Suyog",1,10)
    {
    }

    public int Patientid
    {
        get {return patientid;}
        set { patientid = value;}
    }
     public String Patientname
    {
        get {return patientname;}
        set { patientname = value;}
    }
    public int Bedtype
    {
        get {return bedtype;}
        set { bedtype = value;}
    }
     public int Noofdays
    {
        get {return noofdays;}
        set { noofdays = value;}
    }
      
    public double GetPricePerDay()
    {
     
    double price= 0;
        //double amount;
         if(bedtype == 1)
            price = 500;

        if(bedtype == 2)
             price = 350;

        if(bedtype == 3)
             price = 200;
             return price;
    }
    public virtual double GetBillAmount()
    {
        double amount = noofdays*GetPricePerDay();
        return amount; 
    }
  
}

