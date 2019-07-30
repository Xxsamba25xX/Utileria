using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToObjectLibrary.Parser.Models
{
    public abstract class GeneratedElement
    {
        protected string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                ShowName = value;
            }
        }
        public string Namespace { get; set; }
        public string ShowName { get; set; }

    }


    public class GeneratedClass : GeneratedElement, IEquatable<GeneratedClass>
    {
        public string Id { get; set; }
        public Dictionary<string, GeneratedAttribute> Attributes { get; set; } = new Dictionary<string, GeneratedAttribute>();
        public Dictionary<string, GeneratedChild> Childs { get; set; } = new Dictionary<string, GeneratedChild>();
        public string ValueType { get; set; } = "object";
        public bool hasValueType { get; set; } = false;
        public bool isValueArray { get; set; } = false;
        public bool IsRoot { get; set; } = false;

        public bool Equals(GeneratedClass other)
        {
            if (other == null) return false;

            return this.Id == other.Id;
        }
    }

    public class GeneratedAttribute : GeneratedElement
    {
        public GeneratedAttribute()
        {
            Name = "Value";
            Namespace = "";
        }
        public bool IsArray { get; set; } = false;
        public string ValueType { get; set; } = "object";
    }

    public class GeneratedChild : GeneratedElement
    {
        public GeneratedClass ValueType { get; set; }
        public bool IsArray { get; set; } = false;

    }
}
