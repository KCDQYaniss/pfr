namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[IsReadOnly]
internal struct BindingContext
{
	[CompilerGenerated]
	private readonly AggregateSymbol <ContextForMemberLookup>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <Checked>k__BackingField; //Field offset: 0x8

	public bool Checked
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AggregateSymbol ContextForMemberLookup
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public BindingContext(AggregateSymbol context, bool isChecked) { }

	public BindingContext(BindingContext parent) { }

	[CompilerGenerated]
	public bool get_Checked() { }

	[CompilerGenerated]
	public AggregateSymbol get_ContextForMemberLookup() { }

}

