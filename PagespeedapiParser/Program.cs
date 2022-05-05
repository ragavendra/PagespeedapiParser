using PagespeedapiParser;

Console.WriteLine("Google's Page Speed Loader! - Only 3 calls in a day only");
Console.WriteLine("Enter website: like: google.ca");
var uri = "http://www." + Console.ReadLine();
Parser pgm = new Parser();
//var uri = "http://www.google.ca";
Console.WriteLine($"Site: {uri}");
Console.WriteLine($"Loading ... ");

//pgm.httpCall(uri);
await pgm.httpCall(uri);

