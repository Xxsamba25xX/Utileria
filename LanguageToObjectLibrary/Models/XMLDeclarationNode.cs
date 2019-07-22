using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToObjectLibrary.Models
{
    public class XMLDeclarationNode : AbstractNode
    {
        public XMLDeclarationNode(AbstractNode actualNode)
        {
            Parent = actualNode;
            Name = "";
            Childrens = new List<AbstractNode>();
        }

        public string Version { get; set; } = "";
        public string EncodingName { get; set; } = "";
        public bool isStandAlone { get; set; } = false;
    }
}
