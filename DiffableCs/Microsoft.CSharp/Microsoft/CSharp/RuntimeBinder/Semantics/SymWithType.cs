namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal class SymWithType
{
	private AggregateType _ats; //Field offset: 0x10
	private Symbol _sym; //Field offset: 0x18

	public AggregateType Ats
	{
		 get { } //Length: 5
	}

	public Symbol Sym
	{
		 get { } //Length: 5
	}

	public SymWithType() { }

	public SymWithType(Symbol sym, AggregateType ats) { }

	public override void Clear() { }

	[ExcludeFromCodeCoverage]
	public virtual bool Equals(object obj) { }

	public EventSymbol Event() { }

	public FieldSymbol Field() { }

	public AggregateType get_Ats() { }

	public Symbol get_Sym() { }

	[ExcludeFromCodeCoverage]
	public virtual int GetHashCode() { }

	public AggregateType GetType() { }

	public MethodSymbol Meth() { }

	public MethodOrPropertySymbol MethProp() { }

	public static bool op_Equality(SymWithType swt1, SymWithType swt2) { }

	public static bool op_Implicit(SymWithType swt) { }

	public static bool op_Inequality(SymWithType swt1, SymWithType swt2) { }

	public PropertySymbol Prop() { }

	public void Set(Symbol sym, AggregateType ats) { }

}

