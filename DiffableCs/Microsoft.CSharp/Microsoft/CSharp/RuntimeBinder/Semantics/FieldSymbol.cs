namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal class FieldSymbol : VariableSymbol
{
	public bool isStatic; //Field offset: 0x40
	public bool isReadOnly; //Field offset: 0x41
	public bool isEvent; //Field offset: 0x42
	public FieldInfo AssociatedFieldInfo; //Field offset: 0x48

	public FieldSymbol() { }

	public AggregateSymbol getClass() { }

	public EventSymbol getEvent() { }

	public CType GetType() { }

	public void SetType(CType pType) { }

}

