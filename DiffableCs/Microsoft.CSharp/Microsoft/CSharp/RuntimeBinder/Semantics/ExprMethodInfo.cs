namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprMethodInfo : ExprWithType
{
	[CompilerGenerated]
	private readonly MethWithInst <Method>k__BackingField; //Field offset: 0x40

	public ConstructorInfo ConstructorInfo
	{
		 get { } //Length: 870
	}

	public MethWithInst Method
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MethodInfo MethodInfo
	{
		 get { } //Length: 1794
	}

	public virtual object Object
	{
		 get { } //Length: 7
	}

	public ExprMethodInfo(CType type, MethodSymbol method, AggregateType methodType, TypeArray methodParameters) { }

	public ConstructorInfo get_ConstructorInfo() { }

	[CompilerGenerated]
	public MethWithInst get_Method() { }

	public MethodInfo get_MethodInfo() { }

	public virtual object get_Object() { }

}

