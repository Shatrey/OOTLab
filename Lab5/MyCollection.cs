using System.Collections;

namespace Lab5
{
    internal class MyCollection : IEnumerable
    {
        private object[] items = new object[3];

        public MyCollection()
        {
            items[0] = 1;
            items[1] = "Item 2";
            items[2] = 3;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(items);
        }
    }
}
