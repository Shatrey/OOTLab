namespace Lab8
{
    internal interface IFood
    {
        void Cook();
    }

    internal class Chief
    {
        public void Prepare(IFood food)
        {
            Console.WriteLine("Chief Prepares food");
            food.Cook();
        }
    }
}
