using System;
using System.Collections.Generic;

namespace RipodLab4
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

        public double Time { get; set; }

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
                   Type == other.Type &&
                   Time == other.Time;
        }

        public override int GetHashCode()
        {
            var hashCode = -1536796747;
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<Node>>.Default.GetHashCode(Parents);
            hashCode = hashCode * -1521134295 + EqualityComparer<Node>.Default.GetHashCode(Next);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + Time.GetHashCode();
            return hashCode;
        }

        public int LengthWay()
        {
            var length = 0;
            var node = this;

            while (node.Next != null)
            {
                node = node.Next;
                length++;
            }

            return length;
        }
    }
}
