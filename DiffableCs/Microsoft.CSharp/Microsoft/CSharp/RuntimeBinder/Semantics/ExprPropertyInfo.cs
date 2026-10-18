namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprPropertyInfo : ExprWithType
{
	[CompilerGenerated]
	private readonly PropWithType <Property>k__BackingField; //Field offset: 0x40

	public PropWithType Property
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PropertyInfo PropertyInfo
	{
		 get { } //Length: 877
	}

	public ExprPropertyInfo(CType type, PropertySymbol propertySymbol, AggregateType propertyType) { }

	[CompilerGenerated]
	public PropWithType get_Property() { }

	public PropertyInfo get_PropertyInfo() { }

}

