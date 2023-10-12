using System;
using hm12_task3_delegate;

Random rand = new Random();

int evenCheck = rand.Next(1, 99);
int oddCheck = rand.Next(1, 99);
int primeCheck = rand.Next(1, 99);
int fiboCheck = rand.Next(1, 99);

int size = 4;

string[] output = new string[size];

CheckNumber checkNumber = new CheckNumber();
Predicate<int> isEven = checkNumber.IsEven;
Predicate<int> isOdd = checkNumber.IsOdd;
Predicate<int> isPrime = checkNumber.IsPrime;
Predicate<int> isFibonacci = checkNumber.IsFibonacci;

output[0] = $"Number {evenCheck} is even: {isEven(evenCheck)}";
output[1] = $"Number {oddCheck} is odd: {isOdd(oddCheck)}";
output[2] = $"Number {primeCheck} is prime: {isPrime(primeCheck)}";
output[3] = $"Number {fiboCheck} is fibonacci: {isFibonacci(fiboCheck)}";

foreach (string resultString in output)
{
    Console.WriteLine(resultString);
}