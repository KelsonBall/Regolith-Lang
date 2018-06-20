using System;
using System.IO;
using Antlr4.Runtime;
using Kelson.Lua.Listeners;

namespace Kelson.Lua
{
    public class LuaSource
    {
        private readonly Func<LuaParser> parserSource;

        public LuaSource(string text)
        {
            parserSource = () =>
            {
                var stream = new AntlrInputStream(text);
                var lexar = new LuaLexer(stream);
                var tokens = new CommonTokenStream(lexar);
                return new LuaParser(tokens);
            };                       
        }

        public void ParseToXml(TextWriter output)
        {
            var parser = parserSource();
            using (var printer = new XmlPrinter(output))
            {
                parser.AddParseListener(printer);
                parser.chunk();
            }
        }
    }
}
