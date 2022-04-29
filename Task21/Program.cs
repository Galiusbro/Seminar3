// Задача 21: Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.

void FillPoint(int[] point)
{
    int length = point.Length;
    int index = 0;
    while (index < length)
    {
        point[index] = new Random().Next(-10, 11);
        index++;
    }
}

void PrintPoint(int[] pointPos)
{
    int count = pointPos.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{pointPos[position]} ");
        position++;
    }
    Console.WriteLine();
}

void PointDist(int[] point1, int[] point2)
{
    double dis = Math.Sqrt  (
        (point2[0]-point1[0])*(point2[0]-point1[0])+
        (point2[1]-point1[1])*(point2[1]-point1[1])+
        (point2[2]-point1[0])*(point2[0]-point1[2])
                            );
    Console.WriteLine("{0:f}", dis);                        
}

int[] piont1 = new int[3];
int[] piont2 = new int[3];

FillPoint(piont1);
PrintPoint(piont1);

FillPoint(piont2);
PrintPoint(piont2);

PointDist(piont1, piont2);