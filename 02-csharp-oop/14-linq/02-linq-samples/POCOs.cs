using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public int StudentId
    {
        get;
        set;
    }
    
    public string StudentName
    {
        get;
        set;
    }
    
    public byte Age
    {
        get;
        set;
    } 
    
    public int StandardId
    {
        get;
        set;
    }
}

public class Standard
{
    public int StandardId
    {
        get;
        set;
    }

    public string StandardName
    {
        get;
        set;
    }
}

