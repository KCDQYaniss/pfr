namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class MethodSymbol : MethodOrPropertySymbol
{
	private MethodKindEnum _methKind; //Field offset: 0xA8
	private bool _inferenceMustFail; //Field offset: 0xAC
	private bool _checkedInfMustFail; //Field offset: 0xAD
	private MethodSymbol _convNext; //Field offset: 0xB0
	private PropertySymbol _prop; //Field offset: 0xB8
	private EventSymbol _evt; //Field offset: 0xC0
	public bool isVirtual; //Field offset: 0xC8
	public MemberInfo AssociatedMemberInfo; //Field offset: 0xD0
	public TypeArray typeVars; //Field offset: 0xD8

	public MethodKindEnum MethKind
	{
		 get { } //Length: 7
	}

	public MethodSymbol() { }

	public MethodSymbol ConvNext() { }

	public MethodKindEnum get_MethKind() { }

	public EventSymbol getEvent() { }

	public PropertySymbol getProperty() { }

	public bool InferenceMustFail() { }

	private bool isAnyAccessor() { }

	public bool IsConstructor() { }

	public bool isEventAccessor() { }

	public bool isImplicit() { }

	public bool IsNullableConstructor() { }

	public bool isPropertyAccessor() { }

	public bool isSetAccessor() { }

	public bool isUserCallable() { }

	public void SetConvNext(MethodSymbol conv) { }

	public void SetEvent(EventSymbol evt) { }

	public void SetMethKind(MethodKindEnum mk) { }

	public void SetProperty(PropertySymbol prop) { }

}

