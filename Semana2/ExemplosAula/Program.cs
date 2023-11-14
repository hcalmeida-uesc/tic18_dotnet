
/* #region Foreach examples

string[] people = { "Maria", "João", "José", "Ana" };

foreach(string person in people)
{
    Console.WriteLine(person);
}
#endregion
 */

#region Fibonacci
int fib1 = 0;
int fib2 = 1;
int fib3;

Console.WriteLine(fib1);
Console.WriteLine(fib2);

for (fib3 = fib2+fib1; fib3 <= 100; )
{
    Console.WriteLine(fib3);
    fib1 = fib2;
    fib2 = fib3;
    fib3 = fib2 + fib1;
}

 #endregion