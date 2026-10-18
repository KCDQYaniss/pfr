namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::All (32767), Inherited = False, AllowMultiple = True)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(2)]
internal sealed class UnconditionalSuppressMessageAttribute : Attribute
{
	[CompilerGenerated]
	[Nullable(1)]
	private readonly string <Category>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(1)]
	private readonly string <CheckId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Scope>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Target>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <MessageId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <Justification>k__BackingField; //Field offset: 0x38

	[Nullable(1)]
	public string Category
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 5
	}

	[Nullable(1)]
	public string CheckId
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 5
	}

	public string Justification
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string MessageId
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string Scope
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string Target
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[NullableContext(1)]
	public UnconditionalSuppressMessageAttribute(string category, string checkId) { }

	[CompilerGenerated]
	[NullableContext(1)]
	public string get_Category() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public string get_CheckId() { }

	[CompilerGenerated]
	public string get_Justification() { }

	[CompilerGenerated]
	public string get_MessageId() { }

	[CompilerGenerated]
	public string get_Scope() { }

	[CompilerGenerated]
	public string get_Target() { }

	[CompilerGenerated]
	public void set_Justification(string value) { }

	[CompilerGenerated]
	public void set_MessageId(string value) { }

	[CompilerGenerated]
	public void set_Scope(string value) { }

	[CompilerGenerated]
	public void set_Target(string value) { }

}

