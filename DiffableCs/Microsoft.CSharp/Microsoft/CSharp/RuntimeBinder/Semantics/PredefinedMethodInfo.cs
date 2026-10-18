namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class PredefinedMethodInfo
{
	public PREDEFMETH method; //Field offset: 0x10
	public PredefinedType type; //Field offset: 0x14
	public PredefinedName name; //Field offset: 0x18
	public MethodCallingConventionEnum callingConvention; //Field offset: 0x1C
	public ACCESS access; //Field offset: 0x20
	public int cTypeVars; //Field offset: 0x24
	public int[] signature; //Field offset: 0x28

	public PredefinedMethodInfo(PREDEFMETH method, PredefinedType type, PredefinedName name, MethodCallingConventionEnum callingConvention, ACCESS access, int cTypeVars, int[] signature) { }

}

