namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class TypeTable
{
	[IsReadOnly]
	private struct KeyPair`2 : IEquatable
	{
		private readonly TKey1 _pKey1; //Field offset: 0x0
		private readonly TKey2 _pKey2; //Field offset: 0x0

		public KeyPair`2(TKey1 pKey1, TKey2 pKey2) { }

		public override bool Equals(KeyPair other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private static readonly Dictionary s_aggregateTable; //Field offset: 0x0
	private static readonly Dictionary s_arrayTable; //Field offset: 0x8
	private static readonly Dictionary s_parameterModifierTable; //Field offset: 0x10
	private static readonly Dictionary s_pointerTable; //Field offset: 0x18
	private static readonly Dictionary s_nullableTable; //Field offset: 0x20

	private static TypeTable() { }

	public static void InsertAggregate(AggregateSymbol aggregate, AggregateType outer, TypeArray args, AggregateType ats) { }

	public static void InsertArray(CType elementType, int rankNum, ArrayType pArray) { }

	public static void InsertNullable(CType underlyingType, NullableType nullable) { }

	public static void InsertParameterModifier(CType elementType, bool isOut, ParameterModifierType parameterModifier) { }

	public static void InsertPointer(CType elementType, PointerType pointer) { }

	public static AggregateType LookupAggregate(AggregateSymbol aggregate, AggregateType outer, TypeArray args) { }

	public static ArrayType LookupArray(CType elementType, int rankNum) { }

	public static NullableType LookupNullable(CType underlyingType) { }

	public static ParameterModifierType LookupParameterModifier(CType elementType, bool isOut) { }

	public static PointerType LookupPointer(CType elementType) { }

	private static KeyPair MakeKey(TKey1 key1, TKey2 key2) { }

}

