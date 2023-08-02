using Task_1.Interfaces;

namespace Task_1
{
    public class Array : IOutput, IMath, ISort
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

        public void SortAsc()
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

        public void SortDesc()
        {
            int size = list.Count;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
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

        public int Max()
        {
            int result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    result = list[i];
                }
                else if (list[i] > result)
                {
                    result = list[i];
                }
            }

            return result;
        }

        public int Min()
        {
            int result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    result = list[i];
                }
                else if (list[i] < result)
                {
                    result = list[i];
                }
            }

            return result;
        }

        public float Avg()
        {
            int tmp = 0;
            foreach (var item in list)
            {
                tmp += item;
            }
            return tmp / list.Count;
        }

        public bool Search(int valueToSearch)
        {
            foreach (var item in list)
            {
                if (item == valueToSearch)
                    return true;
            }
            return false;
        }
    }
}
