namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class Expr
{
	private CType _type; //Field offset: 0x10
	[CompilerGenerated]
	private object <RuntimeObject>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private CType <RuntimeObjectActualType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly ExpressionKind <Kind>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private EXPRFLAG <Flags>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <IsOptionalArgument>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <ErrorString>k__BackingField; //Field offset: 0x38

	public string ErrorString
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public EXPRFLAG Flags
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsOptionalArgument
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ExpressionKind Kind
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[ExcludeFromCodeCoverage]
	public override object Object
	{
		 get { } //Length: 39
	}

	internal object RuntimeObject
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	internal CType RuntimeObjectActualType
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public CType Type
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	protected Expr(ExpressionKind kind) { }

	[CompilerGenerated]
	public string get_ErrorString() { }

	[CompilerGenerated]
	public EXPRFLAG get_Flags() { }

	[CompilerGenerated]
	public bool get_IsOptionalArgument() { }

	[CompilerGenerated]
	public ExpressionKind get_Kind() { }

	public override object get_Object() { }

	[CompilerGenerated]
	internal object get_RuntimeObject() { }

	[CompilerGenerated]
	internal CType get_RuntimeObjectActualType() { }

	public CType get_Type() { }

	[CompilerGenerated]
	public void set_ErrorString(string value) { }

	[CompilerGenerated]
	public void set_Flags(EXPRFLAG value) { }

	[CompilerGenerated]
	public void set_IsOptionalArgument(bool value) { }

	[CompilerGenerated]
	internal void set_RuntimeObject(object value) { }

	[CompilerGenerated]
	internal void set_RuntimeObjectActualType(CType value) { }

	protected void set_Type(CType value) { }

}

