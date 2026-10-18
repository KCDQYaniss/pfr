namespace System.Text.RegularExpressions;

internal sealed class RegexTree
{
	public readonly RegexNode Root; //Field offset: 0x10
	public readonly Hashtable Caps; //Field offset: 0x18
	public readonly int[] CapNumList; //Field offset: 0x20
	public readonly int CapTop; //Field offset: 0x28
	public readonly Hashtable CapNames; //Field offset: 0x30
	public readonly string[] CapsList; //Field offset: 0x38
	public readonly RegexOptions Options; //Field offset: 0x40

	internal RegexTree(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options) { }

}

