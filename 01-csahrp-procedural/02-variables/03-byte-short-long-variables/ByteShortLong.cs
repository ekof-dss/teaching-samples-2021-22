byte xb = 100;
byte yb = 100;
System.Console.WriteLine("xb = " + xb);
System.Console.WriteLine("yb = " + yb);
byte zb = (byte)(xb + yb);
System.Console.WriteLine("xb + yb = " + zb);
System.Console.WriteLine();

xb = 100;
yb = 200;
System.Console.WriteLine("xb = " + xb);
System.Console.WriteLine("yb = " + yb);
zb = (byte)(xb + yb);
System.Console.WriteLine("xb + yb = " + zb);
System.Console.WriteLine();

short xs = xb;
short ys = yb;
System.Console.WriteLine("xs = " + xs + ", ys = " + ys);
short zs = (short)(xs + ys);
System.Console.WriteLine("xs + ys = " + zs);
System.Console.WriteLine();

xs = 30000;
ys = 5_000;
System.Console.WriteLine("xs = " + xs + ", ys = " + ys);
zs = (short)(xs + ys);
System.Console.WriteLine("xs + ys = " + zs);
System.Console.WriteLine();

xs = 30000;
ys = 30_000;
System.Console.WriteLine("xs = " + xs + ", ys = " + ys);
zs = (short)(xs + ys);
System.Console.WriteLine("xs + ys = " + zs);
System.Console.WriteLine();

long xl = xs;
long yl = ys;
System.Console.WriteLine("xl = " + xl + ", yl = " + yl);
long zl = xl + yl;
System.Console.WriteLine("xl + yl = " + zl);
System.Console.WriteLine();

xl = 5_000_000_000_000_000_000;
yl = xl;
System.Console.WriteLine("xl = " + xl + ", yl = " + yl);
zl = xl + yl;
System.Console.WriteLine("xl + yl = " + zl);
System.Console.WriteLine();
