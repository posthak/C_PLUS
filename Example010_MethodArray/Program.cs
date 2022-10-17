//             0  1   2   3   4   5   6   7   
int[] array = {13, 172, 351, 4, 1445, 169, 44, 18666};
{
    int n = array.Length;
    int find = 4;

int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
        }
    index++;
}
}