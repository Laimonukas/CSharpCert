// FizzBuzz challenge

for (int i = 1;i < 100; i++){
    Console.WriteLine($"{i}{(i % 3 == 0 ? (i % 5 == 0 ? " - FizzBuzz":" - Fizz") : (i % 5 == 0 ? " - Buzz":""))}");
}