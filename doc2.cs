
     using system;
     class Class4
     {
         public int x;
       public void Input X()
      {
       Console.WriteLine("Enter the value of x");
       int x = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("x = "+x);
      }
    public static void Main()
   {
    Class4 obj = new Class4();
            int exitkey=1;
            while (exitkey>0)
            {​​​​​​​
                Console.WriteLine("You want to exit ? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {​​​​​​​
                    obj.InputX();
                    choice = Console.ReadLine();
                }​​​​​​​
                else
                {​​​​​​​
                    break;
                }​​​​​​​
            }​​​​​​​
            Console.ReadLine();
}
}

    
 
