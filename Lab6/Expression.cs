namespace Lab6
{
    internal abstract class AbstractExpression
    {
        public abstract int Interpret();
    }

    internal class NumberExpression : AbstractExpression
    {
        private int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public override int Interpret()
        {
            return number;
        }
    }

    internal class AddExpression : AbstractExpression
    {
        private AbstractExpression leftExpression;
        private AbstractExpression rightExpression;

        public AddExpression(AbstractExpression leftExpression, AbstractExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public override int Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }

    internal class SubtractExpression : AbstractExpression
    {
        private AbstractExpression leftExpression;
        private AbstractExpression rightExpression;

        public SubtractExpression(AbstractExpression leftExpression, AbstractExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public override int Interpret()
        {
            return leftExpression.Interpret() - rightExpression.Interpret();
        }
    }
}
