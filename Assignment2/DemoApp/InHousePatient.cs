namespace hospital;
class InHousePatient : Patient
{
    private double discount;
   // public double discount {get;set;}

    public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }
    public InHousePatient(int patientId,String patientname,int bedtype,int noOfDays,double d) : base(patientId,patientname,bedtype,noOfDays) 
    {
        discount = d;
    }
  public override double GetBillAmount()
  {
    double amount = base.GetBillAmount();
    double d= amount>5000 ? 5: discount;
    return amount-amount*d/100;

  }




} 
