// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
// начиная от 40 считает очень медленно

double Fibonacci(int n) // можно int
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}