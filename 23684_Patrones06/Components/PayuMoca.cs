using System;
namespace _Patrones06.Components
{
    public class PayuMoca : Beverage
    {
        public PayuMoca(String size)
        {
            this.description = "PayucaMocha";
            this.size = !size.isEmpty() ? size : this.size;
            setCost();
        }

        @Override
    protected void setCost()
        {
            switch (this.size)
            {
                case "Chico":
                    this.cost = 65.00;
                case "Mediano":
                    this.cost = 85.00;
                case "Largo":
                    this.cost = 95.00;
                default:
                    this.cost = 80.00;
            }
        }

        @Override
    public String getDescription()
        {
            return String.Format("%s %s", this.size, this.description);
        }

        @Override
    public double getCost()
        {
            return this.cost;
        }

        @Override
    public String getSize()
        {
            return this.size;
        }
    }
}