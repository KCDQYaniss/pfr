namespace Mono.Globalization.Unicode;

internal class Contraction
{
	public int Index; //Field offset: 0x10
	public readonly char[] Source; //Field offset: 0x18
	public readonly string Replacement; //Field offset: 0x20
	public readonly byte[] SortKey; //Field offset: 0x28

	public Contraction(int index, char[] source, string replacement, byte[] sortkey) { }

}

