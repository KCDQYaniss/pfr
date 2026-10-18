namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprConstant : ExprWithType
{
	[CompilerGenerated]
	private Expr <OptionalConstructorCall>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly ConstVal <Val>k__BackingField; //Field offset: 0x48

	public long Int64Value
	{
		 get { } //Length: 208
	}

	public bool IsZero
	{
		 get { } //Length: 128
	}

	public virtual object Object
	{
		 get { } //Length: 1652
	}

	public Expr OptionalConstructorCall
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ulong UInt64Value
	{
		 get { } //Length: 90
	}

	public ConstVal Val
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExprConstant(CType type, ConstVal value) { }

	public long get_Int64Value() { }

	public bool get_IsZero() { }

	public virtual object get_Object() { }

	[CompilerGenerated]
	public Expr get_OptionalConstructorCall() { }

	public ulong get_UInt64Value() { }

	[CompilerGenerated]
	public ConstVal get_Val() { }

	[CompilerGenerated]
	public void set_OptionalConstructorCall(Expr value) { }

}

