﻿using GraphIt.wasm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace GraphIt.wasm.Services
{
    public interface IXmlNodeService
    {
        void Draw(Edge edge, Node head, Node tail, XmlTextWriter writer, bool weighted, bool directed);
        void CreateNode(Node node, XmlTextWriter writer);
        void CreateNode(Edge edge, XmlTextWriter writer);
        void CreateNode(DefaultOptions d, XmlTextWriter writer);
        void Draw(Node node, XmlTextWriter writer);

    }
}