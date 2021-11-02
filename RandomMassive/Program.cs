// Задача - заполнение массива случайными числами

int[] a= new int[10]; // описание массива
Random rnd = new Random (); // создали объект rnd класса Random (описали объект и создали его)

for (int i = 0; i < 10; i++)
{
    a[i] = rnd.Next(0,100);
}

for (int i = 0; i < 10; i++)
{
    Console.Write(a[i] + " ");
}