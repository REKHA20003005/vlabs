using System;

 

class CompareGenericClass < T > {  
    public bool Compare(T x, T y) {  
        if (x.Equals(y)) 
       return true;  
        else 
       return false;  
    }  
}

 

class Program {  
    static void Main(string[] args) {  
        CompareGenericClass < string > Ocompare = new CompareGenericClass < string > ();  
        bool stringResult = Ocompare.Compare("Hey There", "Hey There");  
        Console.WriteLine("Generic string comapre result:" + stringResult);  

 

        CompareGenericClass < int > oIntcompare = new CompareGenericClass < int > ();  
        bool integerresult = oIntcompare.Compare(15, 16);  
        Console.WriteLine("Generic int comapre result:" + integerresult);  
    }  
}