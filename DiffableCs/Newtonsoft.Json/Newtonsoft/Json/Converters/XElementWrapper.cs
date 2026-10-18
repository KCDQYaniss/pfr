namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
{
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private List _attributes; //Field offset: 0x20

	public virtual List Attributes
	{
		 get { } //Length: 1335
	}

	private XElement Element
	{
		private get { } //Length: 112
	}

	public override bool IsEmpty
	{
		 get { } //Length: 34
	}

	[Nullable(2)]
	public virtual string LocalName
	{
		[NullableContext(2)]
		 get { } //Length: 39
	}

	[Nullable(2)]
	public virtual string NamespaceUri
	{
		[NullableContext(2)]
		 get { } //Length: 48
	}

	[Nullable(2)]
	public virtual string Value
	{
		[NullableContext(2)]
		 get { } //Length: 178
		[NullableContext(2)]
		 set { } //Length: 145
	}

	public XElementWrapper(XElement element) { }

	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	public virtual List get_Attributes() { }

	private XElement get_Element() { }

	public override bool get_IsEmpty() { }

	[NullableContext(2)]
	public virtual string get_LocalName() { }

	[NullableContext(2)]
	public virtual string get_NamespaceUri() { }

	[NullableContext(2)]
	public virtual string get_Value() { }

	public override string GetPrefixOfNamespace(string namespaceUri) { }

	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	[NullableContext(2)]
	public virtual void set_Value(string value) { }

	public override void SetAttributeNode(IXmlNode attribute) { }

}

