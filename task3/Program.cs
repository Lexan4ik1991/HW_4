int[] array = new int[8];
FillArray(array);
PrintArray(array); 
void FillArray(int[] array)
{
int length = array.Length; 
int index = 0; 
    while(index < length)
    {
     array[index] = new Random().Next(-8,9); 
     index++; 
    }
}

void PrintArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        Console.Write($"{array[index]}, ");  
        index++;     
    }
}