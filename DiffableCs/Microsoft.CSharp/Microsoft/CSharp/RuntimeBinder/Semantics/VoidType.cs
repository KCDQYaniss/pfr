namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class VoidType : CType
{
	public static readonly VoidType Instance; //Field offset: 0x0

	private static VoidType() { }

	private VoidType() { }

	public virtual bool IsPredefType(PredefinedType pt) { }

}

