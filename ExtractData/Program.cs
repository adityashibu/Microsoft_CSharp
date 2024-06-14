const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string start = "<span>";
const string end = "</span>";
quantity = input.Substring(input.IndexOf(start) + start.Length, input.IndexOf(end) - input.IndexOf(start) - start.Length);

const string start2 = "<div>";
const string end2 = "</div>";
output = input.Substring(input.IndexOf(start2) + start2.Length, input.IndexOf(end2) - input.IndexOf(start2) - start2.Length);
output = output.Replace("&trade;", "&reg;");

Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);