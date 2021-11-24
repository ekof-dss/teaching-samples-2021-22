/*

class	            The type argument must be any class, interface, delegate, or array type.

class?	            The type argument must be a nullable or non-nullable class, interface, delegate, or array type.

struct	            The type argument must be non-nullable value types such as primitive data types int, char, bool, float, etc.

new()	            The type argument must be a reference type which has a public parameterless constructor. It cannot be 
combined with struct and unmanaged constraints.

notnull	            The type argument can be non-nullable reference types or value types. If not, then the compiler generates a 
warning instead of an error.

unmanaged	        The type argument must be non-nullable unmanged types.

<base class name>   The type argument must be or derive from the specified base class. The Object, Array, ValueType classes are 
disallowed as a base class constraint. The Enum, Delegate, MulticastDelegate are disallowed as base class constraint.

<base class name>?	The type argument must be or derive from the specified nullable or non-nullable base class

<interface name>	The type argument must be or implement the specified interface.

<interface name>?	The type argument must be or implement the specified interface. It may be a nullable reference type, a 
non-nullable reference type, or a value type

where T: U	        The type argument supplied for T must be or derive from the argument supplied for U.

*/


using System;
using System.Collections;

namespace RS2.GenericConstraints
{
    class MyClass { }

    interface IMyInterface { }

    struct MyStruct { }

    class DataStore1<T> where T : class
    {
        public T Data { get; set; }
    }

    class DataStore2<T> where T : struct
    {
        public T Data { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            // ogranicenje where T : class
            DataStore1<string> store11 = new DataStore1<string>(); // valid
            DataStore1<MyClass> store12 = new DataStore1<MyClass>(); // valid
            DataStore1<IMyInterface> store13 = new DataStore1<IMyInterface>(); // valid
            DataStore1<IEnumerable> store14 = new DataStore1<IEnumerable>(); // valid
            DataStore1<ArrayList> store15 = new DataStore1<ArrayList>(); // valid
            //DataStore1<int> store16 = new DataStore1<int>(); // compile-time error

            // ogranicenje where T : struct
            DataStore2<int> store21 = new DataStore2<int>(); // valid
            DataStore2<char> store22 = new DataStore2<char>(); // valid
            DataStore2<MyStruct> store23 = new DataStore2<MyStruct>(); // valid
            //DataStore2<string> store24 = new DataStore2<string>(); // compile-time error 
            //DataStore2<IMyInterface> store25 = new DataStore2<IMyInterface>(); // compile-time error 
            //DataStore2<ArrayList> store26 = new DataStore2<ArrayList>(); // compile-time error

        }
    }
}
