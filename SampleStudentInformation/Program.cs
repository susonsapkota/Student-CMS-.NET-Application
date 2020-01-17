using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentForm());
            
            /*
            String[] arr = { "D", "C", "A", "B" };
            BubbleSort bubble = new BubbleSort(arr, arr.Length);
            String[] sortedArr = bubble.getSortedArray();
            for (int i = 0; i < sortedArr.Length; i++)
            {
                Console.WriteLine(sortedArr[i]);
            }
            Console.WriteLine("asdasfasd");
            */
        }
    }
}
