using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Models
{
	public abstract class AbstractNode
	{
		public AbstractNode Parent { get; set; } = null;
		public string Name { get; set; } = "";
		public List<AbstractNode> Childrens { get; set; } = new List<AbstractNode>();
	}
}
