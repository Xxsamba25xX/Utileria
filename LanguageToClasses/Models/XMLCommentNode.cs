using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Models
{
    public class XMLCommentNode : AbstractNode
    {
        public XMLCommentNode(AbstractNode actualNode, string value)
        {
            Value = value;
            Parent = actualNode;
            Name = "";
            Childrens = new List<AbstractNode>();
        }

        public string Value { get; set; }
    }
}
