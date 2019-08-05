namespace tuvi
{
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "a", Namespace = "", IsNullable = false)]
    public partial class A
    {


        [System.Xml.Serialization.XmlElementAttribute(ElementName = "b", Namespace = "", IsNullable = false)]
        public B[] B { get; set; }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

    }

    public partial class B
    {

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "c", Namespace = "", IsNullable = false)]
        public C[] C { get; set; }

    }

    public partial class C
    {

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "e", Namespace = "", IsNullable = false)]
        public E[] E { get; set; }

    }

    public partial class E
    {


        [System.Xml.Serialization.XmlElementAttribute(ElementName = "d", Namespace = "", IsNullable = false)]
        public D[] D { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "aux", Namespace = "")]
        public string Aux { get; set; }

    }

    public partial class D
    {


        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "aux", Namespace = "")]
        public string Aux { get; set; }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }

    }

}