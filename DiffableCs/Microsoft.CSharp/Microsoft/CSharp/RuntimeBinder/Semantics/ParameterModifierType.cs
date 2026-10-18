namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ParameterModifierType : CType
{
	[CompilerGenerated]
	private readonly bool <IsOut>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly CType <ParameterType>k__BackingField; //Field offset: 0x20

	public virtual Type AssociatedSystemType
	{
		 get { } //Length: 69
	}

	public virtual CType BaseOrParameterOrElementType
	{
		 get { } //Length: 5
	}

	public bool IsOut
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CType ParameterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ParameterModifierType(CType parameterType, bool isOut) { }

	public virtual Type get_AssociatedSystemType() { }

	public virtual CType get_BaseOrParameterOrElementType() { }

	[CompilerGenerated]
	public bool get_IsOut() { }

	[CompilerGenerated]
	public CType get_ParameterType() { }

}

