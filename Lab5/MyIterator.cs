using System.Collections;

namespace Lab5
{
    internal class MyEnumerator : IEnumerator
    {
        private object[] items;
        private int currentIndex = -1;

        public MyEnumerator(object[] items)
        {
            this.items = items;
        }

        public object Current
        {
            get
            {
                if (currentIndex == -1 || currentIndex >= items.Length)
                    throw new InvalidOperationException();
                return items[currentIndex];
            }
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < items.Length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
