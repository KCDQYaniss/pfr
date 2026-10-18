namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprField : ExprWithType
{
	[CompilerGenerated]
	private Expr <OptionalObject>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly FieldWithType <FieldWithType>k__BackingField; //Field offset: 0x48

	public FieldWithType FieldWithType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Expr OptionalObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ExprField(CType type, Expr optionalObject, FieldWithType field) { }

	[CompilerGenerated]
	public FieldWithType get_FieldWithType() { }

	[CompilerGenerated]
	public Expr get_OptionalObject() { }

	[CompilerGenerated]
	public void set_OptionalObject(Expr value) { }

}

