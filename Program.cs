// See https://aka.ms/new-console-template for more information
using Conversor_arquivosUtil;

Console.WriteLine("Hello, World!");


Pessoa pessoa = new Pessoa();
pessoa.name	= "Wellington";
pessoa.idade = "32";
pessoa.profissão = "Desenvolvedor de sistemas";


ConversorJson json = new ConversorJson();
var xml = json.Conversor(pessoa);
Console.WriteLine(xml);

ConversorXML Xml = new ConversorXML();
Console.WriteLine(Xml.Conversor(pessoa));
Console.WriteLine("Hello, World!");