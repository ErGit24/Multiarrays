



int[,] int2darray = new int[,]

{
    {1,2,3 },
    {4,5,6 },
    {7,8,9 }
};

Console.WriteLine("2d arrays");

Console.WriteLine(int2darray[1,0]);  // 4
Console.WriteLine(int2darray[2, 2]); // 9
Console.WriteLine(int2darray[0, 0]); // 1


int[,,] int3darray = new int[,,]
{
    {
        {1,2},
        {3,4},
    },
    {
        {5,6},
        {7,8},
    }
};
Console.WriteLine("3d arrays");
Console.WriteLine(int3darray[0,0,0]);
Console.WriteLine(int3darray[1, 0, 1]);

Console.WriteLine("Dimensions");
Console.WriteLine(int2darray.Rank);
Console.WriteLine(int3darray.Rank);

Console.WriteLine("for each loop");

foreach(int i in int2darray)
{
    Console.WriteLine(i);
}