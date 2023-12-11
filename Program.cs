//Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

var orderArray = orderStream.Split(',').Order();
foreach (var order in orderArray)
{
    Console.WriteLine(order.Length == 4 ? $"{order}":$"{order}\t- Error");
}
