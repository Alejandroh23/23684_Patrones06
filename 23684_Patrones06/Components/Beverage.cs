using System;
namespace _Patrones06.Components
{
    public class Beverage
    {
        protected String description;
        protected double cost;
        protected String size = "Medium";

        public abstract String getSize();
        public abstract String getDescription();
        public abstract double getCost();
        protected abstract void setCost();

    }
}
