// Если число делится на 3, вместо него надо сказать «Fizz».
// Если число делится на 5, вместо него надо сказать «Buzz».
// А если число делится одновременно на 3 и на 5, то надо вместо него сказать «FizzBuzz».
int number = 100;
for(int i = 1; i <= 100; i++)
{
    if(i % 3 == 0)
    {
        if(i % 5 == 0) Console.WriteLine("FizzBuzz");
        else Console.WriteLine("Fizz");
    }
    else if(i % 5 == 0) Console.WriteLine("Buzz");
    else Console.WriteLine(i);
}