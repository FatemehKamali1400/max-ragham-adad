int num, a, max=0;
System.Console.WriteLine("Enter a number:");
num=int.Parse(Console.ReadLine());
while (num != 0)
{
    a = num % 10 ;
   
    if (max<=a)
    {
        max=a;
    }
    num=num / 10;
}

System.Console.WriteLine("max argham adad=" + max);
 
