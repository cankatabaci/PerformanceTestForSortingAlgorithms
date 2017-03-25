using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTestForSortingAlgorithms
{
    public class Algorithms
    {
        public void Bubble(int[] items)
        {
            int tarama;
            bool swapped = false;
            for (tarama = 0; tarama < items.Length; tarama++)
            {
                swapped = false;
                //Her tarama sonrası sondaki elemanları zaten sıralı olacağından 
                //onları karşılaştırmamak için tarama sayısı çıkart
                for (int i = 0; i < (items.Length - tarama - 1); i++)
                {
                    if (items[i] > items[i + 1])
                    {
                        int temp;
                        temp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = temp;
                        swapped = true;
                    }
                }
                //Eğer geçişte sıralama yapılmadıysa, bir sonraki geçişe geçme, işlemi bitir.
                if (!swapped)
                    break;
            }
        }
        public void Selection(int[] items)
        {
            int n = items.Length;
            int minIndis = 0;

            for (int i = 0; i < n; i++)
            {
                minIndis = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (items[j] < items[minIndis])
                        minIndis = j;
                }

                if (minIndis != i)
                {
                    int temp = items[i];
                    items[i] = items[minIndis];
                    items[minIndis] = temp;
                }
            }
        }

        public void Insertion(int[] items)
        {
            for (int j = 1; j < items.Length; j++)
            {
                int key = items[j];
                int i = j - 1;
                while (i >= 0 && items[i] > key)
                {
                    items[i + 1] = items[i];
                    i = i - 1;
                }
                items[i + 1] = key;
            }
        }

        public void quickSort(int[] items, int altindis, int ustindis)
        {
            int yeni_altindis = altindis, yeni_ustindis = ustindis, h;
            int pivot = items[(altindis + ustindis) / 2];

            do
            {
                while (items[yeni_altindis] < pivot)
                    yeni_altindis++;
                while (items[yeni_ustindis] > pivot)
                    yeni_ustindis--;
                if (yeni_altindis <= yeni_ustindis)
                {
                    h = items[yeni_altindis];
                    items[yeni_altindis] = items[yeni_ustindis];
                    items[yeni_ustindis] = h;
                    yeni_altindis++;
                    yeni_ustindis--;
                }
            } while (yeni_altindis <= yeni_ustindis);

            if (altindis < yeni_ustindis)
                quickSort(items, altindis, yeni_ustindis);
            if (yeni_altindis < ustindis)
                quickSort(items, yeni_altindis, ustindis);
        }

        public void HeapSort(int[] input)
        {
            //Build-Max-Heap
            int heapSize = input.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(input, heapSize, p);

            for (int i = input.Length - 1; i > 0; i--)
            {
                //Swap
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
        }
        private void MaxHeapify(int[] input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeapify(input, heapSize, largest);
            }
        }

    }
}
