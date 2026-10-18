namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ExprFieldInfo : ExprWithType
{
	[CompilerGenerated]
	private readonly FieldSymbol <Field>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly AggregateType <FieldType>k__BackingField; //Field offset: 0x48

	public FieldSymbol Field
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AggregateType FieldType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ExprFieldInfo(FieldSymbol field, AggregateType fieldType, CType type) { }

	[CompilerGenerated]
	public FieldSymbol get_Field() { }

	[CompilerGenerated]
	public AggregateType get_FieldType() { }

}

