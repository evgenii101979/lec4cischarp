// рекурсия вычисления факториала 5! =  5 * 4 * 3 * 2 * 1
    //                                  5 * 4!              1! = 1
      //                                    4 * 3!          0! = 1
        //                                      3 * 2!
          //                                        2 * 1!

double Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
  Console.WriteLine($"{i}! = {Factorial(i)}");
}
