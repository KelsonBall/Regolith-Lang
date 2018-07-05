using Microsoft.Extensions.Primitives;
using System;
using System.IO;

namespace Kelson.CommonAst
{    
    public interface IProgramBuilder : IFinalBuilder<IProgram>
    {
        IProgramBuilder WithVersion(string version);
        IProgramBuilder WithName(string name);
        IProgramBuilder WithArgs(params string[] args);
        IProgramBuilder WithArgs(params StringSegment[] args);
        IProgramBuilder WithFileReferences(params string[] files);
        IProgramBuilder WithFileReferences(params Uri[] files);
        IProgramBuilder WithSourceReferences(params string[] sources);
        IProgramBuilder WithSourceReferences(params Stream[] sources);
    }
}
