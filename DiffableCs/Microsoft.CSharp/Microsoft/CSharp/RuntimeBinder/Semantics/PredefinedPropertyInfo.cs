namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class PredefinedPropertyInfo
{
	public PREDEFPROP property; //Field offset: 0x10
	public PredefinedName name; //Field offset: 0x14
	public PREDEFMETH getter; //Field offset: 0x18

	public PredefinedPropertyInfo(PREDEFPROP property, PredefinedName name, PREDEFMETH getter) { }

}

