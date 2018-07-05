using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace Kelson.CommonAst
{
    public interface ITreeNode<T> : IEnumerable<T>
    {
        T Parent { get; }

        T Root { get; }

        /// <summary>
        /// Immediate descendents of this node
        /// </summary>
        IEnumerable<T> Children { get; }

        /// <summary>
        /// Depth First traversal of descendents
        /// </summary>
        IEnumerable<T> Descendents { get; }

        /// <summary>
        /// All parents of this node up to the root, starting with this nodes direct parent
        /// </summary>
        IEnumerable<T> Ancestors { get; }
    }

    public interface IAstNode : ITreeNode<IAstNode>
    {
        /// <summary>
        /// Name of the related rule in the grammar
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Tags for filtering syntax trees
        /// </summary>
        IReadOnlyList<string> Tags { get; }

        /// <summary>
        /// literal arguments of a node
        /// </summary>
        StringValues Args { get; }

        /// <summary>
        /// Source code of child nodes
        /// </summary>
        StringSegment InnerSource { get; }

        /// <summary>
        /// Source code of this node, including child nodes
        /// </summary>
        StringSegment OuterSource { get; }

        /// <summary>
        /// Grammar string of the syntax node
        /// </summary>
        string Grammar { get; }

        /// <summary>
        /// Description of this syntax node
        /// </summary>
        string Description { get; }
    }
}
