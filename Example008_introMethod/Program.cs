// Найти наибольшее среди 9 чисел (числа сначала вводим в программе)

// Есть стихийный способ - сравнить каждый элемент. Тут будем пробовать реализовать с помощью создания новой функции
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2 ;
    if (arg3 > result) result = arg3 ;
    return result;
}

int a1 = 2;
int b1 = 3;
int c1 = 4;
int a2 = 5;
int b2 = 9;
int c2 = 4;
int a3 = 11;
int b3 = 3;
int c3 = 19;
// введенный метод Max (с большой буквы) сравнивает и ищет максимумы по тройкам. 
// арг его аргументы, ретурн - то что выдает, Макс() - его способ вызова
int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);
int max = Max (max1, max2, max3);
Console.WriteLine (max);