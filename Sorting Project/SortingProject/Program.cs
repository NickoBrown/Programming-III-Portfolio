using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

//30032159
//Nicholas Brown
//Sorting Algorithm comparison demo program

namespace SortingProject
{
    class Program
    {
        static int MAX_VALUES = 10000000;
        static int MIN_VALUE = 10000;
        static int NUM_TESTS = 100;
        static int NUM_VALUES = 10000;


        static void Main(string[] args)
        {
            /*
            int NUM_VALUES;
            if (!int.TryParse(args[0], out NUM_VALUES))
            {
                NUM_VALUES = 5000;
            }
            */


            FileStream stream;
            if (!File.Exists("output" + NUM_VALUES + ".csv"))
            {
                
                stream = File.Create("output" + NUM_VALUES + ".csv");
             }
            else
            {
                stream = new FileStream("output" + NUM_VALUES + ".csv", FileMode.OpenOrCreate);
            }
            
            StreamWriter writer = new StreamWriter(stream);
            string quickValues = "Quick,";
            string introValues = "Intro,";
            string heapValues = "Heap,";

            for (int j = 0; j < (NUM_TESTS + 1); j++)
            {
                Console.WriteLine("=====" + (j) + "=====");
                Stopwatch stopWatchQuick = new Stopwatch();
                Stopwatch stopWatchIntro = new Stopwatch();
                Stopwatch stopWatchHeap = new Stopwatch();

                List<int> numbers = new List<int>();
                Random rand = new Random();
                for (int i = 0; i < NUM_VALUES; i++)
                {

                    numbers.Add(rand.Next(MAX_VALUES - MIN_VALUE) + MIN_VALUE);
                }


                /*
                for (int i = 0; i < NUM_VALUES; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
                */

                stopWatchQuick.Start();
                List<int> quickSorted = numbers;
                QuickSort(quickSorted, 0, NUM_VALUES - 1);
                stopWatchQuick.Stop();

                stopWatchIntro.Start();
                List<int> introSorted = numbers;
                IntroSort(ref introSorted);
                stopWatchIntro.Stop();

                stopWatchHeap.Start();
                List<int> heapSorted = HeapSort(numbers);
                stopWatchHeap.Stop();
                

                /*
                foreach(int value in mergeSorted)
                {
                    Console.WriteLine(value);
                }
                */
                if(j != 0)
                {
                    quickValues += stopWatchQuick.ElapsedMilliseconds + ",";
                    introValues += stopWatchIntro.ElapsedMilliseconds + ",";
                    heapValues += stopWatchHeap.ElapsedMilliseconds + ",";
                }
                
            }
            writer.WriteLine(heapValues);
            writer.WriteLine(quickValues);
            writer.WriteLine(introValues);
            writer.Flush();
            writer.Close();
            stream.Close();
        }






        #region quick sort

        static int Partition(List<int> list, int low, int high)
        {
            //1. Select a pivot point.
            int pivot = list[high];

            int lowIndex = (low - 1);

            //2. Reorder the collection.
            for (int j = low; j < high; j++)
            {
                if (list[j] <= pivot)
                {
                    lowIndex++;

                    int temp = list[lowIndex];
                    list[lowIndex] = list[j];
                    list[j] = temp;
                }
            }

            int temp1 = list[lowIndex + 1];
            list[lowIndex + 1] = list[high];
            list[high] = temp1;

            return lowIndex + 1;
        }

        static void QuickSort(List<int> list, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(list, low, high);

                //3. Recursively continue sorting the array
                QuickSort(list, low, partitionIndex - 1);
                QuickSort(list, partitionIndex + 1, high);
            }
        }

        #endregion

        #region intro sort
        public static void IntroSort(ref List<int> data)
        {
            int partitionSize = Partition(ref data, 0, data.Count - 1);

            if (partitionSize < 16)
            {
                InsertSort(ref data);
            }
            else if (partitionSize > (2 * Math.Log(data.Count)))
            {
                IntroHeapSort(ref data);
            }
            else
            {
                QuickSortRecursive(ref data, 0, data.Count - 1);
            }
        }

        private static void InsertSort(ref List<int> data)
        {
            for (int i = 1; i < data.Count; ++i)
            {
                int j = i;

                while ((j > 0))
                {
                    if (data[j - 1] > data[j])
                    {
                        data[j - 1] ^= data[j];
                        data[j] ^= data[j - 1];
                        data[j - 1] ^= data[j];

                        --j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }



        private static void IntroHeapSort(ref List<int> data)
        {
            int heapSize = data.Count;

            for (int p = (heapSize - 1) / 2; p >= 0; --p)
                MaxHeapify(ref data, heapSize, p);

            for (int i = data.Count - 1; i > 0; --i)
            {
                int temp = data[i];
                data[i] = data[0];
                data[0] = temp;

                --heapSize;
                MaxHeapify(ref data, heapSize, 0);
            }
        }

        private static void MaxHeapify(ref List<int> data, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && data[left] > data[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && data[right] > data[largest])
                largest = right;

            if (largest != index)
            {
                int temp = data[index];
                data[index] = data[largest];
                data[largest] = temp;

                MaxHeapify(ref data, heapSize, largest);
            }
        }

        private static void QuickSortRecursive(ref List<int> data, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(ref data, left, right);
                QuickSortRecursive(ref data, left, q - 1);
                QuickSortRecursive(ref data, q + 1, right);
            }
        }

        private static int Partition(ref List<int> data, int left, int right)
        {
            int pivot = data[right];
            int temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if (data[j] <= pivot)
                {
                    temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                    i++;
                }
            }

            data[right] = data[i];
            data[i] = pivot;

            return i;
        }
        #endregion

        #region heapsort
        public static List<int> HeapSort(List<int> list)
        {
            return HeapSort(list, 0, list.Count, Comparer<int>.Default);
        }

        public static List<int> HeapSort(List<int> list, int offset, int length, IComparer<int> comparer)
        {
            return HeapSort(list, offset, length, comparer.Compare);
        }

        public static List<int> HeapSort(List<int> input, int offset, int length, Comparison<int> comparison)
        {
            List<int> sorted = input;
            // build binary heap from all items
            for (int i = 0; i < length; i++)
            {
                int index = i;
                int item = sorted[offset + i]; // use next item

                // and move it on top, if greater than parent
                while (index > 0 &&
                    comparison(sorted[offset + (index - 1) / 2], item) < 0)
                {
                    int top = (index - 1) / 2;
                    sorted[offset + index] = sorted[offset + top];
                    index = top;
                }
                sorted[offset + index] = item;
            }

            for (int i = length - 1; i > 0; i--)
            {
                // delete max and place it as last
                int last = sorted[offset + i];
                sorted[offset + i] = sorted[offset];

                int index = 0;
                // the last one positioned in the heap
                while (index * 2 + 1 < i)
                {
                    int left = index * 2 + 1, right = left + 1;

                    if (right < i && comparison(sorted[offset + left], sorted[offset + right]) < 0)
                    {
                        if (comparison(last, sorted[offset + right]) > 0) break;

                        sorted[offset + index] = sorted[offset + right];
                        index = right;
                    }
                    else
                    {
                        if (comparison(last, sorted[offset + left]) > 0) break;

                        sorted[offset + index] = sorted[offset + left];
                        index = left;
                    }
                }
                sorted[offset + index] = last;
            }

            return sorted;
        }
        #endregion


    }}

