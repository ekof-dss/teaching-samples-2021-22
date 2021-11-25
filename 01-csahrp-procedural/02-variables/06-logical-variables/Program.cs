int i = 42;
double x = 420.0001e-1 ;
double y = 4199.9999e-2;
bool b0 = i < x;
System.Console.WriteLine( i + " < " + x + " is " + b0);
b0 = i <y;
System.Console.WriteLine( i + " < " + y + " is " + b0);
System.Console.WriteLine();

char ch1 = 'H';
char ch2 = '!';
bool b1 = ch1 < ch2;
System.Console.WriteLine("'"+ch1 + "' < '" + ch2 + "' is " + b1);
System.Console.WriteLine();

System.Console.WriteLine("not '"+ch1 + "' < '" + ch2 + "' is " + !b1);
System.Console.WriteLine();


char ch3 = 'B';
char ch4 = 'a';
bool b2 = ch3 >= ch4;
System.Console.WriteLine("'"+ch3 + "' >= '" + ch4 + "' is " + b2);
System.Console.WriteLine();

System.Console.WriteLine("'"+ch1 + "' < '" + ch2 + "' and '"+ch3 + "' >= '" + ch4 + "' is " + (b1 && b2));
System.Console.WriteLine("'"+ch1 + "' < '" + ch2 + "' or '"+ch3 + "' >= '" + ch4 + "' is " + (b1 || b2));
System.Console.WriteLine();
