// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



/*int[] massiv = new int[8];
 NewMass(massiv.Length);

void NewMass(int size)
{
    for(int i = 0; i < size; i++)
    {
        massiv[i] = new Random().Next(0,100);          
    }
}

Console.Write($"massiv = [{String.Join(", ",  massiv)}]");*/

int[] massiv = new int[8];
 FerstMass(massiv.Length);

void FerstMass(int size)
{
    for(int i = 0; i < size; i++)
    {
        massiv[i] = new Random().Next(0,100);   
            }
        }

int[] mass = massiv;

void OldMass(int[] mass)
{
    int count = mass.Length;
    for(int i = 0; i < count; i++)
    {
       
    }
     Console.Write($"massiv = [{String.Join(", ", mass)}]");
      Console.WriteLine();
     Console.Write("Упорядоченный массив");
        Console.WriteLine();
} 

void UporMass(int[] mass)
{
        for(int i = 0; i < mass.Length - 1; i++)
    {
        int minPossition = i;
           
            for(int j = i + 1; j < mass.Length; j++)
            {
                if(mass[j] < mass[minPossition]) minPossition = j;
            }                

        int temp = mass[i];
        mass[i] = mass[minPossition];
        mass[minPossition] = temp;
    }
      
} 

OldMass(mass);

UporMass(mass);

OldMass(mass);
