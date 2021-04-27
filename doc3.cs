using System;
class MyException:ApplicationException
{
    public void MyNewException()
    {
        Console.WriteLine("Exception occured , when object is null");
    }
}

    class Class4
    {
    public static void Main()
    {   
       Class4 c =null;
        try
        {
            if(c==null)
            {
                throw MyException();
            }
        }
            catch(MyNewException mn) 
            {
                mn.MyNewExceptionException();
            }
            Console.ReadLine();
        } 
    }