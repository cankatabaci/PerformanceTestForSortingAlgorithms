using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace PerformanceTestForSortingAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBubble_100_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            a.Bubble(r.randomYuz);
            sw.Stop();
            TimeSpan t = sw.Elapsed;
            MessageBox.Show("Bubble Sort algorithm's array sorting performance with 100 elements: " + t.TotalMilliseconds);
        }

        private void btnQuick_100_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.quickSort(r.randomYuz, 0, 99);
            sw.Stop();
            MessageBox.Show("Quick Sort algorithm's array sorting performance with 100 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnHeap_100_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.HeapSort(r.randomYuz);
            sw.Stop();
            MessageBox.Show("Heap Sort algorithm's array sorting performance with 100 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnBubble_750_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            a.Bubble(r.randomYediYuzElli);
            sw.Stop();
            MessageBox.Show("Bubble Sort algorithm's array sorting performance with 750 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnBubble_1500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            a.Bubble(r.randomBinBesYuz);
            sw.Stop();
            MessageBox.Show("Bubble Sort algorithm's array sorting performance with 1500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnBubble_7500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            a.Bubble(r.randomYediBinBesYuz);
            sw.Stop();
            MessageBox.Show("Bubble Sort algorithm's array sorting performance with 7500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnBubble_15000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            a.Bubble(r.randomOnBesBin);
            sw.Stop();
            MessageBox.Show("Bubble Sort algorithm's array sorting performance with 15000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnBubble_75000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            a.Bubble(r.randomYetmisBesBin);
            sw.Stop();
            MessageBox.Show("Bubble Sort algorithm's array sorting performance with 75000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnBubble_150000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();

            sw.Start();
            a.Bubble(r.randomYuzElliBin);
            sw.Stop();
            MessageBox.Show("Bubble Sort algorithm's array sorting performance with 150000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnQuick_750_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.quickSort(r.randomYediYuzElli, 0, 749);
            sw.Stop();
            MessageBox.Show("Quick Sort algorithm's array sorting performance with 750 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnQuick_1500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.quickSort(r.randomBinBesYuz, 0, 1499);
            sw.Stop();
            MessageBox.Show("Quick Sort algorithm's array sorting performance with 1500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnQuick_7500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.quickSort(r.randomYediBinBesYuz, 0, 7499);
            sw.Stop();
            MessageBox.Show("Quick Sort algorithm's array sorting performance with 7500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnQuick15000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.quickSort(r.randomOnBesBin, 0, 14999);
            sw.Stop();
            MessageBox.Show("Quick Sort algorithm's array sorting performance with 15000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnQuick_75000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.quickSort(r.randomYetmisBesBin, 0, 74999);
            sw.Stop();
            MessageBox.Show("Quick Sort algorithm's array sorting performance with 75000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnQuick_150000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.quickSort(r.randomYuzElliBin, 0, 149999);
            sw.Stop();
            MessageBox.Show("Quick Sort algorithm's array sorting performance with 750000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnHeap_750_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.HeapSort(r.randomYediYuzElli);
            sw.Stop();
            MessageBox.Show("Heap Sort algorithm's array sorting performance with 750 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnHeap1500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.HeapSort(r.randomBinBesYuz);
            sw.Stop();
            MessageBox.Show("Heap Sort algorithm's array sorting performance with 1500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnHeap_7500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.HeapSort(r.randomYediBinBesYuz);
            sw.Stop();
            MessageBox.Show("Heap Sort algorithm's array sorting performance with 7500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnHeap_15000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.HeapSort(r.randomOnBesBin);
            sw.Stop();
            MessageBox.Show("Heap Sort algorithm's array sorting performance with 15000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnHeap_75000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.HeapSort(r.randomYetmisBesBin);
            sw.Stop();
            MessageBox.Show("Heap Sort algorithm's array sorting performance with 75000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnHeap_150000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.HeapSort(r.randomYuzElliBin);
            sw.Stop();
            MessageBox.Show("Heap Sort algorithm's array sorting performance with 150000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnİnsertion_100_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Insertion(r.randomYuz);
            sw.Stop();
            MessageBox.Show("Insertion Sort algorithm's array sorting performance with 100 elements: " + sw.ElapsedMilliseconds.ToString());

        }

        private void btnInsertion_750_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Insertion(r.randomYediYuzElli);
            sw.Stop();
            MessageBox.Show("Insertion Sort algorithm's array sorting performance with 750 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnInsertion_1500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Insertion(r.randomBinBesYuz);
            sw.Stop();
            MessageBox.Show("Insertion Sort algorithm's array sorting performance with 1500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnInsertion_7500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Insertion(r.randomYediBinBesYuz);
            sw.Stop();
            MessageBox.Show("Insertion Sort algorithm's array sorting performance with 7500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnInsertion_15000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Insertion(r.randomOnBesBin);
            sw.Stop();
            MessageBox.Show("Insertion Sort algorithm's array sorting performance with 15000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnInsertion_75000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Insertion(r.randomYetmisBesBin);
            sw.Stop();
            MessageBox.Show("Insertion Sort algorithm's array sorting performance with 75000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnInsertion_150000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Insertion(r.randomYuzElliBin);
            sw.Stop();
            MessageBox.Show("Insertion Sort algorithm's array sorting performance with 150000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnSelection_100_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Selection(r.randomYuz);
            sw.Stop();
            MessageBox.Show("Selection Sort algorithm's array sorting performance with 100 elements: " + sw.ElapsedMilliseconds.ToString());

        }

        private void btnSelection_750_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Selection(r.randomYediYuzElli);
            sw.Stop();
            MessageBox.Show("Selection Sort algorithm's array sorting performance with 750 elements:" + sw.ElapsedMilliseconds.ToString());
        }

        private void btnSelection_1500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Selection(r.randomBinBesYuz);
            sw.Stop();
            MessageBox.Show("Selection Sort algorithm's array sorting performance with 1500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnSelection_7500_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Selection(r.randomYediBinBesYuz);
            sw.Stop();
            MessageBox.Show("Selection Sort algorithm's array sorting performance with 7500 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnSelection_15000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Selection(r.randomOnBesBin);
            sw.Stop();
            MessageBox.Show("Selection Sort algorithm's array sorting performance with 15000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnSelection_75000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Selection(r.randomYetmisBesBin);
            sw.Stop();
            MessageBox.Show("Selection Sort algorithm's array sorting performance with 75000 elements: " + sw.ElapsedMilliseconds.ToString());
        }

        private void btnSelection_150000_Click(object sender, EventArgs e)
        {
            Algorithms a = new Algorithms();
            RandomArray r = new RandomArray();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a.Selection(r.randomYuzElliBin);
            sw.Stop();
            MessageBox.Show("Selection Sort algorithm's array sorting performance with 150000 elements: " + sw.ElapsedMilliseconds.ToString());
        }
    }
}
