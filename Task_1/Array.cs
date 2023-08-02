namespace Task_1
{
    public class Array : IOutput
    {
        public Array()
        {
            list = new List<int>(100);
        }

        public Array(int size)
        {
            list = new List<int>(size);
        }

        private List<int> list;

        public void Add(int value)
        {
            list.Add(value);
        }

        public void RemovebyValue(int value)
        {
            list.Remove(value);
        }

        public void RemoveByIndex(int index)
        {
            list.RemoveAt(index);
        }

        public void Sort()
        {
            int size = list.Count;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        public void Show()
        {
            Console.Write("Array: [");
            foreach (var item in list)
            {
                Console.Write("{" + item + "}");
            }
            Console.Write("]");
        }

        public void Show(string info)
        {
            Show();
            Console.WriteLine(" - " + info);
        }
    }
}
