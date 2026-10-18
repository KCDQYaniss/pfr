namespace UnityEngine;

[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[NativeHeader("Runtime/Utilities/Hash128.h")]
[UsedByNativeCode]
public struct Hash128 : IComparable, IComparable, IEquatable
{
	internal ulong u64_0; //Field offset: 0x0
	internal ulong u64_1; //Field offset: 0x8

	public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3) { }

	public Hash128(ulong u64_0, ulong u64_1) { }

	public void Append(List data) { }

	public void Append(T[] data) { }

	public void Append(int val) { }

	public override int CompareTo(object obj) { }

	public override int CompareTo(Hash128 rhs) { }

	public static Hash128 Compute(string data) { }

	public static Hash128 Compute(T[] data) { }

	[FreeFunction("ComputeHash128FromScriptArray", IsThreadSafe = True)]
	private static void ComputeFromArray(Array data, int start, int count, int elemSize, ref Hash128 hash) { }

	[FreeFunction("ComputeHash128FromScriptString", IsThreadSafe = True)]
	private static void ComputeFromString(string data, ref Hash128 hash) { }

	public override bool Equals(Hash128 obj) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	private static string Hash128ToStringImpl(Hash128 hash) { }

	private static string Hash128ToStringImpl_Injected(ref Hash128 hash) { }

	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	[FreeFunction("StringToHash128", IsThreadSafe = True)]
	public static Hash128 Parse(string hashString) { }

	private static void Parse_Injected(string hashString, out Hash128 ret) { }

	private static void Rot64(ref ulong x, int k) { }

	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	private void ShortHash4(uint data) { }

	public virtual string ToString() { }

}

