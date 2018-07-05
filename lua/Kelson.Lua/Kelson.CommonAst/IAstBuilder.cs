using Antlr4.Runtime.Tree;
using System.IO;

namespace Kelson.CommonAst
{
    public interface IAstBuilder
    {
        IAstBuilderWithSource WithSource(string source);
        IAstBuilderWithSource WithSource(Stream source);
    }

    public interface IAstBuilderWithSource : IFinalBuilder<IAstNode>
    {
        IAstBuilderWithSource WithListener(IParseTreeListener listener);
    }
}
