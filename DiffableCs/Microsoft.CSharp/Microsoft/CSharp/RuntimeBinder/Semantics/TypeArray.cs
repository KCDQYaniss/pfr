namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[DefaultMember("Item")]
internal sealed class TypeArray
{
	[IsReadOnly]
	private struct TypeArrayKey : IEquatable
	{
		private readonly CType[] _types; //Field offset: 0x0
		private readonly int _hashCode; //Field offset: 0x8

		public TypeArrayKey(CType[] types) { }

		public override bool Equals(TypeArrayKey other) { }

		[ExcludeFromCodeCoverage]
		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private static readonly Dictionary s_tableTypeArrays; //Field offset: 0x0
	public static readonly TypeArray Empty; //Field offset: 0x8
	[CompilerGenerated]
	private readonly CType[] <Items>k__BackingField; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 26
	}

	public CType Item
	{
		 get { } //Length: 43
	}

	public CType[] Items
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static TypeArray() { }

	private TypeArray(CType[] types) { }

	public static TypeArray Allocate(int ctype, TypeArray array, int offset) { }

	public static TypeArray Allocate(CType[] types) { }

	public static TypeArray Concat(TypeArray pta1, TypeArray pta2) { }

	public void CopyItems(int i, int c, CType[] dest) { }

	public int get_Count() { }

	public CType get_Item(int i) { }

	[CompilerGenerated]
	public CType[] get_Items() { }

}

