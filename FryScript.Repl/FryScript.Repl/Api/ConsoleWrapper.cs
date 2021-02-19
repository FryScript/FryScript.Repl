using System;
using System.Collections.Generic;
using System.Text;

namespace FryScript.Repl.Api
{
    [ScriptableType("console")]
    public class ConsoleWrapper
    {
        [ScriptableMethod("writeLine")]
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        [ScriptableMethod("write")]
        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}
