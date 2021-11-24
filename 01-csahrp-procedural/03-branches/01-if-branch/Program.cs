int x = 10, y = 3, z = -3, w = -13;
System.Console.WriteLine("x: " + x + " y: " + y + " z: " + z + " w: " + w);

int min;
min = x;
if (y < min)
    min = y;
if (z < min)
    min = z;
if (w < min)
    min = w;

System.Console.WriteLine("Minimum for x, y, z, w: " + min);
System.Console.WriteLine();
