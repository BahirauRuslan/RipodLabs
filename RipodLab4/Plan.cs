using System;
using System.Collections.Generic;
using System.Linq;

namespace RipodLab4
{
    public class Plan
    {
        private readonly IList<IList<Node>> steps;

        public Plan(Graph graph)
        {
            steps = new List<IList<Node>>();
            CreatePlan(graph);
        }

        public Plan(Graph graph, int add, int mul)
        {
            steps = new List<IList<Node>>();
            CreatePlan(graph, add, mul);
        }

        public Plan(Graph graph, int add, int mul, double timeStep)
        {
            steps = new List<IList<Node>>();
            CreatePlan(graph, add, mul, timeStep);
        }

        public int GetCountType(int step, string type)
        {
            int count = 0;

            for (var i = 0; i < steps[step].Count; i++)
            {
                if (steps[step][i].Type.Equals(type))
                {
                    count++;
                }
            }

            return count;
        }

        public IList<IList<Node>> GetSteps()
        {
            return steps;
        }

        private void CreatePlan(Graph graph, int plusType, int mulType, double timeStep)
        {
            var nodes = graph.Roots;
            while (nodes.Count > 0)
            {
                var add = plusType;
                var mul = mulType;
                var newNodes = new List<Node>();
                var nonCompleted = new List<Node>();
                steps.Add(new List<Node>());

                while (nodes.Count > 0 && (add > 0 || mul > 0))
                {
                    var criticalNode = (from node in nodes orderby node.LengthWay() select node).Last();
                    if (criticalNode.Parents.Count == 0 && criticalNode.Next != null
                        && criticalNode.Type == "+" && add > 0)
                    {
                        steps.Last().Add(criticalNode);
                        criticalNode.Time -= timeStep;
                        if (!HasNode(newNodes, criticalNode.Next) && criticalNode.Time <= 0)
                        {
                            newNodes.Add(criticalNode.Next);
                        }
                        else if (criticalNode.Time > 0)
                        {
                            nonCompleted.Add(criticalNode);
                        }
                        add--;
                    }
                    else if (criticalNode.Parents.Count == 0 && criticalNode.Next != null
                        && criticalNode.Type == "*" && mul > 0)
                    {
                        steps.Last().Add(criticalNode);
                        criticalNode.Time -= timeStep;
                        if (!HasNode(newNodes, criticalNode.Next) && criticalNode.Time <= 0)
                        {
                            newNodes.Add(criticalNode.Next);
                        }
                        else if (criticalNode.Time > 0)
                        {
                            nonCompleted.Add(criticalNode);
                        }
                        mul--;
                    }
                    else if (criticalNode.Parents.Count == 0 && criticalNode.Next == null
                        && criticalNode.Type == "+" && add > 0)
                    {
                        steps.Last().Add(criticalNode);
                        criticalNode.Time -= timeStep;
                        if (criticalNode.Time > 0)
                        {
                            nonCompleted.Add(criticalNode);
                        }
                        add--;
                    }
                    else if (criticalNode.Parents.Count == 0 && criticalNode.Next == null
                        && criticalNode.Type == "*" && mul > 0)
                    {
                        steps.Last().Add(criticalNode);
                        criticalNode.Time -= timeStep;
                        if (criticalNode.Time > 0)
                        {
                            nonCompleted.Add(criticalNode);
                        }
                        mul--;
                    }
                    else if (!HasNode(newNodes, criticalNode))
                    {
                        newNodes.Add(criticalNode);
                    }

                    nodes.Remove(criticalNode);
                }

                RemoveParentsReferences();
                newNodes.AddRange(nodes);
                newNodes.AddRange(nonCompleted);
                nodes = newNodes;
            }
        }

        private void CreatePlan(Graph graph, int plusType, int mulType)
        {
            var nodes = graph.Roots;
            while (nodes.Count > 0)
            {
                var add = plusType;
                var mul = mulType;
                var newNodes = new List<Node>();
                steps.Add(new List<Node>());

                while (nodes.Count > 0 && (add > 0 || mul > 0))
                {
                    var criticalNode = (from node in nodes orderby node.LengthWay() select node).Last();
                    if (criticalNode.Parents.Count == 0 && criticalNode.Next != null 
                        && criticalNode.Type == "+" && add > 0)
                    {
                        steps.Last().Add(criticalNode);
                        if (!HasNode(newNodes, criticalNode.Next))
                        {
                            newNodes.Add(criticalNode.Next);
                        }
                        add--;
                    }
                    else if (criticalNode.Parents.Count == 0 && criticalNode.Next != null
                        && criticalNode.Type == "*" && mul > 0)
                    {
                        steps.Last().Add(criticalNode);
                        if (!HasNode(newNodes, criticalNode.Next))
                        {
                            newNodes.Add(criticalNode.Next);
                        }
                        mul--;
                    }
                    else if (criticalNode.Parents.Count == 0 && criticalNode.Next == null 
                        && criticalNode.Type == "+" && add > 0)
                    {
                        steps.Last().Add(criticalNode);
                        add--;
                    }
                    else if (criticalNode.Parents.Count == 0 && criticalNode.Next == null
                        && criticalNode.Type == "*" && mul > 0)
                    {
                        steps.Last().Add(criticalNode);
                        mul--;
                    }
                    else if (!HasNode(newNodes, criticalNode))
                    {
                        newNodes.Add(criticalNode);
                    }

                    nodes.Remove(criticalNode);
                }

                RemoveParentsReferences();
                newNodes.AddRange(nodes);
                nodes = newNodes;
            }
        }

        private void CreatePlan(Graph graph)
        {
            while (graph.Roots.Count != 0)
            {
                IList<Node> newNodes = new List<Node>();
                steps.Add(new List<Node>());
                for (var i = 0; i < graph.Roots.Count; i++)
                {
                    if (graph.Roots[i].Parents.Count == 0 && graph.Roots[i].Next != null)
                    {
                        steps.Last().Add(graph.Roots[i]);
                        if (!HasNode(newNodes, graph.Roots[i].Next))
                        {
                            newNodes.Add(graph.Roots[i].Next);
                        }
                    }
                    else if (graph.Roots[i].Parents.Count == 0 && graph.Roots[i].Next == null)
                    {
                        steps.Last().Add(graph.Roots[i]);
                    }
                    else
                    {
                        if (!HasNode(newNodes, graph.Roots[i]))
                        {
                            newNodes.Add(graph.Roots[i]);
                        }
                    }
                }

                RemoveParentsReferences();

                graph.Roots = newNodes;
            }
        }

        private void RemoveParentsReferences()
        {
            foreach (var node in steps.Last())
            {
                if (node.Next != null && node.Time <= 0)
                {
                    node.Next.Parents.Remove(node);
                }
            }
        }

        private Node GetCriticalNode(IEnumerable<Node> nodes)
        {
            Node criticalNode = null;
            foreach (var node in nodes)
            {
                if (criticalNode == null || node.LengthWay() > criticalNode.LengthWay())
                {
                    criticalNode = node;
                }
            }

            return criticalNode;
        }

        private bool HasNode(IEnumerable<Node> nodes, Node node)
        {
            foreach (IList<Node> step in steps)
            {
                foreach (Node nodeItem in step)
                {
                    if (nodeItem.Value.Equals(node.Value))
                    {
                        return true;
                    }
                }
            }

            foreach (Node nodeItem in nodes)
            {
                if (nodeItem.Value.Equals(node.Value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
