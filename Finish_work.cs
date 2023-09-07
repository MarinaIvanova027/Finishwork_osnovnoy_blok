string[] arr1 = new string[7] {"Samara", "1234", "eng", "0", "Moscow", "-7", "rus"};
string[] arr2 = new string[arr1.Lenght];

void MakeSecondArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for(int i = 0; i < arr1.Lenght; i++)
    {
        if(arr1.Lenght[i] <= 3)
        {
            arr2[count] = arr1[i];
            count ++;
        }
    }
}
void ShowArray(string[] arr)
{
    for(int i = 0; i < arr.Lenght; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}
