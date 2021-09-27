using System;

class Program {
  public static void Main (string[] args) {
 //Console.WriteLine("Enter Prime Number:");
 //double Num = Convert.ToDouble(Console.ReadLine());

//double Prime = Num/2;

//Console.WriteLine("Enter Prime Number:" + Prime);

int i = 0;
while (i < 19) 
{
  if (i == 1 || i == 4 || i == 6 || i == 8 || i == 9 || i == 10 || i == 12 || i == 14 || i == 15 ||i == 16 || i == 18)
{
    i++;
    continue;
  }
  Console.WriteLine("Not Prime Number " + i);
  i++;
}
int p = 0;
while (p < 19) 
{
  if (p == 2 || p == 3 || p == 5 || p == 7 || p == 11 || p == 13 || p == 17)
{
    p++;
    continue;
  }
  Console.WriteLine("Prime Number " + p);
  p++;
}


         



  }
}