System.Console.Write(">>> ");
string? str = Console.ReadLine();

string[] arr = str.Split(",");

int[] arrint = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    arrint[i] = Convert.ToInt32(arr[i]);
}


int count = 0;

for (int i = 0; i < arrint.Length; i++)
{
    if (arrint[i]>0)
    {
        count= count+1;
    }
    
}

System.Console.WriteLine($"\nПользователь ввёл ({count}) числа больше нуля.");