namespace Lab8
{
    internal interface IMeal
    {
        void CreateMeal();
    }

    internal class Pizza : IMeal
    {
        public void CreateMeal()
        {
            Console.WriteLine("Cook pizza");
        }
    }

    internal class FoodAdapter : IFood
    {
        private IMeal _adaptee;

        public FoodAdapter(IMeal adaptee)
        {
            _adaptee = adaptee;
            Console.WriteLine("Adapt Meal to Food");
        }

        public void Cook()
        {
            Console.WriteLine("adapted cook");
            _adaptee.CreateMeal();
        }
    }
}
