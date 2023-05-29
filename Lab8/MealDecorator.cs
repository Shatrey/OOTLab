namespace Lab8
{
    internal abstract class MealDecorator : IMeal
    {
        protected IMeal decoratedShape;

        public MealDecorator(IMeal decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public virtual void CreateMeal()
        {
            decoratedShape.CreateMeal();
        }
    }

    internal class CheeseDecorator : MealDecorator
    {
        public CheeseDecorator(IMeal decoratedShape) : base(decoratedShape)
        {
        }

        public override void CreateMeal()
        {
            base.CreateMeal();
            Console.WriteLine("Adding chees to meal");
        }
    }
}
