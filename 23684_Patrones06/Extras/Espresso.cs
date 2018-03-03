using System;
namespace _Patrones06.Extras
{
    public class Espresso
    {
        public Espresso(beverage Beverage)
        {
            this.Beverage = Beverage;
            this.getDescription = "Espresso";
            setCost();
        }

        @Override
    protected void setCost()
        {
            switch (this.beverage.getSize())
            {
                case "Chico":
                    this.cost = 5.00;
                case "Mediano":
                    this.cost = 8.00;
                case "Largo":
                    this.cost = 12.00;
                default:
                    this.cost = 8.00;
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