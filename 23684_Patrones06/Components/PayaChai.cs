using System;
namespace _Patrones06.Components
{
    public class PayaChai : Beverage
    {
        public PayaChai(String size)
        {
            this.description = "Payachai";
            this.size = !size.isEmpty() ? size : this.size;
            setCost();
        }

        @Override
    protected void setCost()
        {
            switch (this.size)
            {
                case "Pequeño":
                    this.cost = 25.00;
                case "Mediano":
                    this.cost = 45.00;
                case "Largo":
                    this.cost = 55.00;
                default:
                    this.cost = 60.00;
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