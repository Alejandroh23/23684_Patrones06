using System;
namespace _Patrones06.Components
{
    public class PayuExpress : Beverage
    {

        public PayuExpress(String size)
        {
            this.description = "PayucaExpress";
            this.size = !size.isEmpty() ? size : this.size;
            setCost();
        }

        @Override
    protected void setCost()
        {
            switch (this.size)
            {
                case "Chico":
                    this.cost = 45.00;
                case "Mediano":
                    this.cost = 75.00;
                case "Largo":
                    this.cost = 105.00;
                default:
                    this.cost = 90.00;
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
