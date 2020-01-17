using System;

public class BubbleSort
{
    public string[] myarray { get; set; }

    public BubbleSort(string[] arr, int n)
    {
        String temp;

        for (int j = 0; j < n - 1; j++)
        {
            for (int i = j + 1; i < n; i++)
            {
                if (arr[j].CompareTo(arr[i]) > 0)
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        myarray = arr;


    }

    public String[] getSortedArray()
    {

        return myarray;
    }

}



