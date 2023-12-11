//Write code to reverse each word in a message

string pangram = "The quick brown fox jumps over the lazy dog";
var splitArray = pangram.Split(' ');
for (int i = 0; i < splitArray.Length; i++)
{
    var charArray = splitArray[i].ToCharArray().Reverse();
    splitArray[i] = String.Join("",charArray);
}
pangram = String.Join(" ",splitArray);

Console.WriteLine(pangram);