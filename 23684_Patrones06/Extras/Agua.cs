using System;
namespace _Patrones06.Extras
{
    public class Agua : Extra
    {
        public Agua(beverage Beverage)
        {
            this.Beverage = Beverage;
            this.getDescription() = "Agua";
            setCost();
        }

        @Override
    protected void setCost()
        {
            switch (this.beverage.getSize())
            {
                case "Chico":
                    this.cost = 2.00;
                case "Mediano":
                    this.cost = 3.00;
                case "Largo":
                    this.cost = 4.00;
                default:
                    this.cost = 5.00;
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