using System;
namespace _Patrones06.Extras
{
    public class Leche
    {
        public Leche(beverage Beverage)
        {
            this.beverage = beverage;
            this.description = "Milk";
            setCost();
        }

        @Override
    protected void setCost()
        {
            switch (this.Beverage.getSize())
            {
                case "Chico":
                    this.cost = 7.00;
                case "Mediano":
                    this.cost = 12.00;
                case "Largo":
                    this.cost = 15.00;
                default:
                    this.cost = 12.00;
            }
        }

        @Override
    public String getDescription()
        {
            return String.Format("%s with %s", this.Beverage.getDescription(), this.description);
        }

        @Override
    public double getCost()
        {
            return this.Beverage.getCost() + this.cost;
        }

        @Override
    public String getSize()
        {
            return this.Beverage.getSize();
        }
    }
}