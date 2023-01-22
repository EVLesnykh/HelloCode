//Пример№1
 void FillArray(int[] collection);
 {
   int length = collection.Length;
  int index = 0;
   while (index < length)
{
collection[index] = new Random().Next(1, 10);
index = index + 1; //index++
}
 }
//Пример№2
 void FillArray(int[] collection)
 void PrintArray(int[] col)
int[] array = new int[10];
 {
   int count = col.Length;
  int position = 0;
while (position < count) ;
  {
    Console.WriteLine(col[position]);
     position++;
  }
}

int[] array = new int[10];

 FillArray(array);
 PrintArray(array);

//Пример№3:
void FillArray(int[] collection);

void PrintArray(int[] col);

int[] array = new int[10];
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
//Пример№4:
// int IndexOf(int[] collection, int find)
// {
//   int index = collection.Length;
//   int count = 0; int position = 0;
//   while (index < count)
//   {
//     If(collection[index] == find);
//   {
//       position = index;
//     }
//     index++;
//   }
//   Return position;
// }
// int pos = IndexOf(array, 4);
// Console.WriteLine(pos);
