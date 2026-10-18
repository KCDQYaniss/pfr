namespace Newtonsoft.Json.Utilities;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
internal struct StructMultiKey`2 : IEquatable
{
	public readonly T1 Value1; //Field offset: 0x0
	public readonly T2 Value2; //Field offset: 0x0

	public StructMultiKey`2(T1 v1, T2 v2) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(StructMultiKey other) { }

	public virtual int GetHashCode() { }

}

