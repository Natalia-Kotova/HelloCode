﻿// Имеется одномерный массив array из n элементов, требуется найти элемент массива равный find
// 1. Установить счетчик index в позицию 0
// 2. Если array[index] = find, алгоритм завершил работу успешно
// 3. Увеличить index на 1
// 4. Если index < n, то перейти к шагу 2. в противном случае алгоритм завершил работу безуспешно

int [] array = {1, 12, 31, 4, 15, 16, 17, 18};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find){
        System.Console.WriteLine(index);
        break; // нужно,  если вдруг в массиве есть несколько чисел равных find, тогда алгоритм остановится на первом
    }
    // index = index + 1;
    index++;
}