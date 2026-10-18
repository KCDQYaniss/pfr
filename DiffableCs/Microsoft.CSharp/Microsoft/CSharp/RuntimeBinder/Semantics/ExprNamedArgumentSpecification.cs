namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprNamedArgumentSpecification : Expr
{
	private Expr _value; //Field offset: 0x40
	[CompilerGenerated]
	private readonly Name <Name>k__BackingField; //Field offset: 0x48

	public Name Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Expr Value
	{
		 get { } //Length: 5
		 set { } //Length: 211
	}

	public ExprNamedArgumentSpecification(Name name, Expr value) { }

	[CompilerGenerated]
	public Name get_Name() { }

	public Expr get_Value() { }

	public void set_Value(Expr value) { }

}

