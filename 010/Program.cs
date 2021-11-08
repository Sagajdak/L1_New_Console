//Одномерный массив, найти элемент, равный find. Установить счётчик
//int n = int.Parse(Console.ReadLine());
int n=10;
int [] array = new int[n];
int i = 0;
while (i < n)
{
     array [i]=new Random().Next(1, 50);
     i++;
}
//Вывод массива
i = 0;
while (i<n)
{
    Console.Write(array[i]);
    Console.Write(" ");
    i++;
}

//Одномерный массив, найти элемент, равный find
int count = 0;
int find = 5;
i = 0;
while (i<n)
{
    if (array[i] == find) count++;
    i++;
}
Console.WriteLine("find встречался в массиве: ");
Console.WriteLine(count);


