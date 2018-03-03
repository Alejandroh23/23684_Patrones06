using System;
namespace _Patrones06.Components
{
    public class PayeLate : Beverage
    {
        public PayeLate(String size)
        {
            this.description = "PayeLate";
            this.size = !size.isEmpty() ? size : this.size;
            setCost();
        }

        @Override
    protected void setCost()
        {
            switch (this.size)
            {
                case "Chico":
                    this.cost = 30.50;
                case "Mediano":
                    this.cost = 40.50;
                case "Largo":
                    this.cost = 70.50;
                default:
                    this.cost = 75.50;
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