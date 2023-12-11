//Extract, replace, and remove data from an input string

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
var startIndex = input.IndexOf("<span>");
quantity = input.Substring(input.IndexOf("<span>")+6,input.IndexOf("</span>")-(input.IndexOf("<span>")+6));
output = input.Replace("<div>","").Replace("</div>","").Replace("&trade;","&reg;");

Console.WriteLine(quantity);
Console.WriteLine(output);