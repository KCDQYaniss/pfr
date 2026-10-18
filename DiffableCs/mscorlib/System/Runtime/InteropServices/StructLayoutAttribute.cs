namespace System.Runtime.InteropServices;

[AttributeUsage(12, Inherited = False)]
[ComVisible(True)]
public sealed class StructLayoutAttribute : Attribute
{
	internal LayoutKind _val; //Field offset: 0x10
	public int Pack; //Field offset: 0x14
	public int Size; //Field offset: 0x18
	public CharSet CharSet; //Field offset: 0x1C

	internal StructLayoutAttribute(LayoutKind layoutKind, int pack, int size, CharSet charSet) { }

	internal static StructLayoutAttribute GetCustomAttribute(RuntimeType type) { }

	internal static bool IsDefined(RuntimeType type) { }

}

