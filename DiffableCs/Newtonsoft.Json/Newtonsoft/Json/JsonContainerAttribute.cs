namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(2)]
public abstract class JsonContainerAttribute : Attribute
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private object[] <ItemConverterParameters>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; //Field offset: 0x38
	internal Nullable _isReference; //Field offset: 0x40
	internal Nullable _itemIsReference; //Field offset: 0x42
	internal Nullable _itemReferenceLoopHandling; //Field offset: 0x44
	internal Nullable _itemTypeNameHandling; //Field offset: 0x4C
	private Type _namingStrategyType; //Field offset: 0x58
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	private object[] _namingStrategyParameters; //Field offset: 0x60

	public string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool IsReference
	{
		 get { } //Length: 62
		 set { } //Length: 78
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public object[] ItemConverterParameters
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Type ItemConverterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool ItemIsReference
	{
		 get { } //Length: 62
		 set { } //Length: 78
	}

	public ReferenceLoopHandling ItemReferenceLoopHandling
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	public TypeNameHandling ItemTypeNameHandling
	{
		 get { } //Length: 60
		 set { } //Length: 86
	}

	internal NamingStrategy NamingStrategyInstance
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public object[] NamingStrategyParameters
	{
		 get { } //Length: 5
		 set { } //Length: 170
	}

	public Type NamingStrategyType
	{
		 get { } //Length: 5
		 set { } //Length: 170
	}

	public string Title
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[NullableContext(1)]
	protected JsonContainerAttribute(string id) { }

	protected JsonContainerAttribute() { }

	[CompilerGenerated]
	public string get_Description() { }

	[CompilerGenerated]
	public string get_Id() { }

	public bool get_IsReference() { }

	[CompilerGenerated]
	public object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	public Type get_ItemConverterType() { }

	public bool get_ItemIsReference() { }

	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	public TypeNameHandling get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	internal NamingStrategy get_NamingStrategyInstance() { }

	public object[] get_NamingStrategyParameters() { }

	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	public string get_Title() { }

	[CompilerGenerated]
	public void set_Description(string value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	public void set_IsReference(bool value) { }

	[CompilerGenerated]
	public void set_ItemConverterParameters(object[] value) { }

	[CompilerGenerated]
	public void set_ItemConverterType(Type value) { }

	public void set_ItemIsReference(bool value) { }

	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	[CompilerGenerated]
	internal void set_NamingStrategyInstance(NamingStrategy value) { }

	public void set_NamingStrategyParameters(object[] value) { }

	public void set_NamingStrategyType(Type value) { }

	[CompilerGenerated]
	public void set_Title(string value) { }

}

