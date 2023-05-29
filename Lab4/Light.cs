namespace Lab4
{
    internal class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }

        public void SetColor(string colour)
        {
            Console.WriteLine($"Set colour to {colour}");
        }
    }
}
