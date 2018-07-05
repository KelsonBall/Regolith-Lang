using Microsoft.Extensions.Primitives;

namespace Kelson.CommonAst
{
    public interface IProgram
    {
        string Name { get; }
        string Version { get; }
        StringValues Args { get; }
        StringValues FileReferences { get; }
        StringValues SourceReferences { get; }
        IAstNode Root { get; }
    }
}
