using System;
using System.Text;

namespace Kelson.Lua.Repl
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StringBuilder code = new StringBuilder();
                string line = null;
                while (!string.IsNullOrEmpty(line = Console.ReadLine()))
                    code.AppendLine(line);

                string text = code.ToString().Trim();
                if (string.IsNullOrEmpty(text))
                    continue;

                var source = new LuaSource(text);
                source.ParseToXml(Console.Out);
            }
        }
    }
}
