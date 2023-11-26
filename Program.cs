//array challenges

string[] array = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach(string el in array){
    if(el.StartsWith('B')){
            Console.WriteLine($"{el} starts with 'B'!");
    }
}

Console.WriteLine();