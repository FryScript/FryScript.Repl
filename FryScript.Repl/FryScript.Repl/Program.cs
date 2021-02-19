using FryScript.Repl.Api;
using System;

namespace FryScript.Repl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fry Script Repl v0.1.0");

            var runtime = new ScriptRuntime();
            runtime.Import(typeof(ConsoleWrapper));

            while(true)
            {
                try
                {
                    Console.Write("> ");

                    var code = Console.ReadLine();

                    var result = runtime.Eval(code);

                    Console.WriteLine(result is string ? $"\"{result}\"" : result);
                }
                catch (Exception ex)
                {
                    var previous = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = previous;
                }
            }
        }
    }
}
