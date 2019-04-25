using System;
using System.Collections.Generic;

namespace RipodLab2
{
    public class Node : IEquatable<Node>
    {
        public Node()
        {
            Parents = new List<Node>();
        }

        public IList<Node> Parents { get; set; }

        public Node Next { get; set; }

        public string Value { get; set; }

        public string Type { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Node);
        }

        public bool Equals(Node other)
        {
            return other != null &&
                   EqualityComparer<IList<Node>>.Default.Equals(Parents, other.Parents) &&
                   EqualityComparer<Node>.Default.Equals(Next, other.Next) &&
                   Value == other.Value &&
                   Type == other.Type;
        }

        public override int GetHashCode()
        {
            var hashCode = 1328362313;
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<Node>>.Default.GetHashCode(Parents);
            hashCode = hashCode * -1521134295 + EqualityComparer<Node>.Default.GetHashCode(Next);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            return hashCode;
        }
    }
}
