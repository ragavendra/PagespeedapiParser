// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using PagespeedapiParser;

Console.WriteLine("Hello, World!");
Parser pgm = new Parser();
await pgm.httpCall();

