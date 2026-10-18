namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = False)]
public sealed class MaybeNullWhenAttribute : Attribute
{
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; //Field offset: 0x10

	public MaybeNullWhenAttribute(bool returnValue) { }

}

