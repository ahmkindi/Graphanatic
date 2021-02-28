﻿using GraphIt.wasm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphIt.wasm.Services
{
    public interface IEdgeService
    {
        Edge AddEdge(IList<Edge> edges, DefaultOptions d, int head, int tail, double weight);
        Edge AddEdge(IList<Edge> edges, DefaultOptions d, int head, int tail);
        Edge AddEdge(IList<Edge> edges, Edge e);
        Edge AddEdge(IList<Edge> edges, Edge e, int nextNodeId);
        void DeleteEdges(List<Edge> edges, IList<Edge> edgesToDel);
        void UpdateMultiGraph(DefaultOptions d, List<Edge> edges);
        IEnumerable<Edge> MultiGraphEdges(IEnumerable<Edge> edges, int head, int tail, bool directed);
        int NextId(IList<Edge> edges);
    }
}