namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(2432, AllowMultiple = False, Inherited = False)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class StringSyntaxAttribute : Attribute
{
	public const string CompositeFormat = "CompositeFormat"; //Field offset: 0x0
	public const string DateOnlyFormat = "DateOnlyFormat"; //Field offset: 0x0
	public const string DateTimeFormat = "DateTimeFormat"; //Field offset: 0x0
	public const string EnumFormat = "EnumFormat"; //Field offset: 0x0
	public const string GuidFormat = "GuidFormat"; //Field offset: 0x0
	public const string Json = "Json"; //Field offset: 0x0
	public const string NumericFormat = "NumericFormat"; //Field offset: 0x0
	public const string Regex = "Regex"; //Field offset: 0x0
	public const string TimeOnlyFormat = "TimeOnlyFormat"; //Field offset: 0x0
	public const string TimeSpanFormat = "TimeSpanFormat"; //Field offset: 0x0
	public const string Uri = "Uri"; //Field offset: 0x0
	public const string Xml = "Xml"; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Syntax>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	private readonly object[] <Arguments>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	public object[] Arguments
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Syntax
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StringSyntaxAttribute(string syntax) { }

	public StringSyntaxAttribute(string syntax, object[] arguments) { }

	[CompilerGenerated]
	public object[] get_Arguments() { }

	[CompilerGenerated]
	public string get_Syntax() { }

}

