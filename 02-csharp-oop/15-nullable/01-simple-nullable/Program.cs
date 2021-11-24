/*

As you know, a value type cannot be assigned a null value. For example, int i = null will give you a compile time error.

C# 2.0 introduced nullable types that allow you to assign null to value type variables. You can declare nullable types using 
Nullable<T> where T is a type.
 
A nullable type can represent the correct range of values for its underlying value type, plus an additional null value. For 
example, Nullable<int> can be assigned any value from -2147483648 to 2147483647, or a null value.

The Nullable types are instances of System.Nullable<T> struct. Think it as something like the following structure.

[Serializable]
public struct Nullable<T> where T : struct
{
    public bool HasValue { get; }

    public T Value { get; }

    // other implementation
}

 */

using System;

Nullable<int> i = null;

if (i.HasValue)
    Console.WriteLine(i.Value); // or Console.WriteLine(i)
else
    Console.WriteLine("Null");

i = 42;
if (i.HasValue)
    Console.WriteLine(i.Value); 
else
    Console.WriteLine("Null");

int? num1 = null;
int? num2 = 45;
double? num3 = new double?();
double? num4 = 3.14157;
Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);

bool? boolval = new bool?();
Console.WriteLine("A Nullable boolean value: {0}", boolval);

num1 = null;
num3 = num1 ?? 5.34;
//num3 = num1.HasValue ? num1.Value : 5.34;
Console.WriteLine(" Value of num3: {0}", num3);

num3 = num4 ?? 5.34;
Console.WriteLine(" Value of num3: {0}", num3);