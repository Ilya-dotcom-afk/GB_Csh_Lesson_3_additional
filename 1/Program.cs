//  На ввод подаётся номер четверти, создаются 3 
//случайные точки в этой четверти. 
//Определите самый ооптимальный маршрут для торгового менеджера,
// который выезжает из начала координат.
Console.WriteLine("Введите номет четверти");
int n = Convert.ToInt32(Console.ReadLine());
double[,] graph = new double[4, 4];
Random rand = new Random();
double[] zero = {0, 0};
double[] point_1 = new double[2];
double[] point_2 = new double[2];
double[] point_3 = new double[2];
CreateRandomPoints(point_1, n);
CreateRandomPoints(point_2, n);
CreateRandomPoints(point_3, n);
FilGrafh(graph, zero, point_1, point_2, point_3);

int rows = graph.GetUpperBound(0) + 1;    // количество строк
int columns = graph.Length / rows;        // количество столбцов
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{graph[i, j]} \t");
    }
    Console.WriteLine();
}

void CreateRandomPoints (double[] array, int a)
{
   switch (a)
   {
       case 1:
       array[0] = rand.Next(0, 100);
       array[1] = rand.Next(0, 100);
       break;
       case 2:
       array[0] = rand.Next(-100, 0);
       array[1] = rand.Next(0, 100);
       break;
       case 3:
       array[0] = rand.Next(-100, 0);
       array[1] = rand.Next(-100, 0);
       break;
       case 4:
       array[0] = rand.Next(0, 100);
       array[1] = rand.Next(-100, 0);
       break;
       default:
       Console.WriteLine("Направильно задали номер четверти");
       break;
   }
}


void FilGrafh(double[,] res, double[] array1, double[] array2, double[] array3, double[] array4)
{
    double[][] mas = {array1, array2, array3, array4};
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
           res[i,j] = Math.Pow( (Math.Pow(mas[i][0]-mas[j][0], 2) + Math.Pow(mas[i][1]-mas[j][1], 2)),0.5);
    }
}
}
