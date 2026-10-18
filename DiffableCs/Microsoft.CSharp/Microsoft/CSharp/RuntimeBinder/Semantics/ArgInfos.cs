namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class ArgInfos
{
	public int carg; //Field offset: 0x10
	public TypeArray types; //Field offset: 0x18
	public List prgexpr; //Field offset: 0x20

	public ArgInfos() { }

}

