// Старый добрый обычный поиск нужного элемента перебором в массиве
int [] array = {1,2,17,18,17};
int n = array.Length;

int find = 17;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine (index);
        //break прерывает цикл - то есть после первого найденного нужного элемента цикл остановится
        break;
    }
    index ++;
}

