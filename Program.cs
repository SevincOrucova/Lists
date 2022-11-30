using System;
using System.Reflection;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            Console.WriteLine("Enter the capasity : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            myList.AddElementsToList(array);
            Console.WriteLine(myList.ConvertToString());

            //myList.AddElementsAtTheBeginning();
            //Console.WriteLine("After adding element : " + myList.ConvertToString());

            //myList.AddElementByIndex();
            //Console.WriteLine("After adding element by index : " + myList.ConvertToString());

            //myList.DeleteLastElement();
            //Console.WriteLine("After delete last element : " + myList.ConvertToString());

            //myList.DeleteFirstElement();
            //Console.WriteLine("After delete first element : " + myList.ConvertToString());

            //myList.DeleteElementByIndex();
            //Console.WriteLine("After delete element by index : " + myList.ConvertToString());

            //myList.DeleteNLastElements();
            //Console.WriteLine("After delete n last elements : " + myList.ConvertToString());

            //myList.DeleteNFirstElements();
            //Console.WriteLine("After delete n first elements : " + myList.ConvertToString());

            //myList.DeleteNElementByIndex();
            //Console.WriteLine("After delete n elements by index : " + myList.ConvertToString());

            //Console.WriteLine("Number of this list is : " + myList.GetLength());

            //Console.WriteLine("The element of index is : " + myList.GetElementByIndex());

            //Console.WriteLine($"The index of element is : {myList.GetIndexByValue()}");

            //myList.ReverseList();
            //Console.WriteLine("After Reverse of this list : " + myList.ConvertToString());

            //Console.WriteLine("The maximum value of this array is : " + myList.FindMaxValue());

            //Console.WriteLine("The minimum value of this array is : " + myList.FindMinValue());

            //Console.WriteLine("The index of maximum value of this array is : " + myList.FindIndexOfMaxValue());

            //Console.WriteLine("The index of minimum value of this array is : " + myList.FindIndexOfMinValue());

            //myList.SortByAscending();
            //Console.WriteLine("After sorting by ascending : " + myList.ConvertToString());

            //myList.SortByDescending();
            //Console.WriteLine("After sorting by ascending : " + myList.ConvertToString());

            //myList.AddListToEnd();
            //Console.WriteLine(myList.ConvertToString());

            //myList.AddListToBeginning();
            //Console.WriteLine(myList.ConvertToString());

            //myList.AddListByIndex();
            //Console.WriteLine(myList.ConvertToString());
        }
    }
    public class MyList
    {
        private int[] list;
        public void AddElementsToList(int[] array)
        {
            if (list == null)
            {
                list = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    list[i] = array[i];
                }
            }
            else
            {
                int listLength = list.Length;
                Array.Resize(ref list, listLength + array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    list[i + list.Length] = array[i];
                }
            }

        }

        public string ConvertToString()
        {
            string result = "";
            if (list != null)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (i == 0)
                    {
                        result = list[i].ToString();
                    }
                    else
                    {
                        result = result + "; " + list[i].ToString();
                    }
                }
            }
            return result;
        }

        public void AddElementsAtTheBeginning()
        {
            Console.WriteLine("Enter the element : ");
            int element = Convert.ToInt32(Console.ReadLine());
            if (list == null)
            {
                list = new int[1];
                list[0] = element;
            }
            else
            {
                int listLength = list.Length;
                Array.Resize(ref list, listLength + 1);
                for (int i = list.Length - 1; i > 0; i--)
                {
                    list[i] = list[i - 1];
                }
                list[0] = element;
            }
        }

        public void AddElementByIndex()
        {
            Console.WriteLine("Enter the index : ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the element : ");
            int element = Convert.ToInt32(Console.ReadLine());
            if (list == null)
            {
                list = new int[index + 1];
                list[index] = element;
            }
            else
            {
                Array.Resize(ref list, list.Length + 1);
                for (int i = list.Length - 1; i > 0; i--)
                {
                    if (i > index)
                    {
                        list[i] = list[i - 1];

                    }
                    else if (i == index)
                    {
                        list[i] = element;
                    }
                    else
                    {
                        list[i] = list[i];
                    }
                }
            }

        }

        public void DeleteLastElement()
        {
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int[] newList = new int[list.Length - 1];
                for (int i = 0; i < newList.Length; i++)
                {
                    newList[i] = list[i];
                }
                list = newList;
            }
        }

        public void DeleteFirstElement()
        {
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int[] newList = new int[list.Length - 1];
                for (int i = 1; i < list.Length; i++)
                {
                    newList[i - 1] = list[i];
                }
                list = newList;
            }
        }

        public void DeleteElementByIndex()
        {
            Console.WriteLine("Enter the index : ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int[] newList = new int[list.Length - 1];
                for (int i = 0; i < newList.Length; i++)
                {
                    if (i < index)
                        newList[i] = list[i];
                    else
                        newList[i] = list[i + 1];
                }
                list = newList;
            }
        }

        public void DeleteNLastElements()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int[] newList = new int[list.Length - number];
                for (int i = 0; i < newList.Length; i++)
                {
                    newList[i] = list[i];
                }
                list = newList;
            }
        }

        public void DeleteNFirstElements()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int[] newList = new int[list.Length - number];
                for (int i = number; i < list.Length; i++)
                {
                    newList[i - number] = list[i];
                }
                list = newList;
            }
        }

        public void DeleteNElementByIndex()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the index : ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int[] newList = new int[list.Length - number];
                for (int i = 0; i < newList.Length; i++)
                {
                    if (i < index)
                        newList[i] = list[i];
                    else
                        newList[i] = list[i + number];

                }
                list = newList;
            }
        }

        public int GetLength()
        {
            int length = 0;
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] != null) length++;
                }
            }
            return length;
        }

        public int GetElementByIndex()
        {
            Console.WriteLine("Enter the index : ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (list == null)
            {
                Console.WriteLine("This list is empty.");
                return -1;
            }
            else if (index > list.Length)
            {
                return -1;
            }
            else
            {
                return list[index];
            }
        }

        public int GetIndexByValue()
        {
            Console.WriteLine("Enter the value : ");
            int value = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            if (list == null)
            {
                Console.WriteLine("This list is empty.");
                return -1;
            }
            else
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (value == list[i])
                    {
                        index = i;
                        break;
                    }
                    else
                    {
                        index = -1;
                    }
                }

            }
            return index;
        }

        public void ReverseList()
        {
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int[] newList = new int[list.Length];
                for (int i = 0; i < list.Length; i++)
                {
                    newList[i] = list[list.Length - i - 1];
                }
                list = newList;
            }
        }

        public int FindMaxValue()
        {
            int max = list[0];
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {

                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] > max) max = list[i];
                }
            }
            return max;
        }

        public int FindMinValue()
        {
            int min = list[0];
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] < min) min = list[i];
                }
            }
            return min;
        }

        public int FindIndexOfMaxValue()
        {
            int index = 0;
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int max = list[0];
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] > max)
                    {
                        max = list[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        public int FindIndexOfMinValue()
        {
            int index = 0;
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int min = list[0];

                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] < min)
                    {
                        min = list[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        public void SortByAscending()
        {
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int value;
                for (int i = 0; i < list.Length; i++)
                {
                    for (int j = i + 1; j < list.Length; j++)
                    {
                        if (list[i] > list[j])
                        {
                            value = list[i];
                            list[i] = list[j];
                            list[j] = value;
                        }
                    }
                }
            }
        }

        public void SortByDescending()
        {
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                int value;
                for (int i = 0; i < list.Length; i++)
                {
                    for (int j = i + 1; j < list.Length; j++)
                    {
                        if (list[i] < list[j])
                        {
                            value = list[i];
                            list[i] = list[j];
                            list[j] = value;
                        }
                    }
                }
            }
        }

        public void AddListToEnd()
        {
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                Console.WriteLine("Enter the capasity of other list : ");
                int k = Convert.ToInt32(Console.ReadLine());
                int[] OtherList = new int[k];
                int l = list.Length;
                for (int i = 0; i < k; i++)
                {
                    OtherList[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Resize(ref list, k + l);
                for (int i = 0; i < k; i++)
                {
                    list[i + l] = OtherList[i];
                }
            }
        }

        public void AddListToBeginning()
        {
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                Console.WriteLine("Enter the capasity of other list : ");
                int k = Convert.ToInt32(Console.ReadLine());
                int[] OtherList = new int[k];
                int l = list.Length;
                for (int i = 0; i < k; i++)
                {
                    OtherList[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Resize(ref list, k + l);
                for (int i = list.Length - 1; i >= 0; i--)
                {
                    if (i >= k)
                    {
                        list[i] = list[i - k];
                    }
                    else
                    {
                        list[i] = OtherList[i];
                    }


                }
            }
        }

        public void AddListByIndex()
        {
            if (list == null)
                Console.WriteLine("This list is empty.");
            else
            {
                Console.WriteLine("Enter the capasity of other list : ");
                int k = Convert.ToInt32(Console.ReadLine());
                int[] OtherList = new int[k];
                int l = list.Length;
                for (int i = 0; i < k; i++)
                {
                    OtherList[i] = Convert.ToInt32(Console.ReadLine());
                }
                int[] newList = new int[l + k];
                Console.WriteLine("Enter the index : ");
                int index = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < newList.Length; i++)
                {
                    if (i < index)
                    {
                        newList[i] = list[i];
                    }
                    else if (i >= k + index)
                    {
                        newList[i] = list[i - k];
                    }
                    else
                    {
                        newList[i] = OtherList[i - index];
                    }

                }
                list = newList;
            }
        }
    }
}
