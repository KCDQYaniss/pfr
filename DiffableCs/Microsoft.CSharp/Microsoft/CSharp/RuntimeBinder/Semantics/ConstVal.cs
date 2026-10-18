namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[IsReadOnly]
internal struct ConstVal
{
	private static readonly object s_false; //Field offset: 0x0
	private static readonly object s_true; //Field offset: 0x8
	private static readonly object s_zeroInt32; //Field offset: 0x10
	[CompilerGenerated]
	private readonly object <ObjectVal>k__BackingField; //Field offset: 0x0

	public bool BooleanVal
	{
		 get { } //Length: 449
	}

	public byte ByteVal
	{
		 get { } //Length: 449
	}

	public char CharVal
	{
		 get { } //Length: 449
	}

	public decimal DecimalVal
	{
		 get { } //Length: 455
	}

	public double DoubleVal
	{
		 get { } //Length: 451
	}

	public short Int16Val
	{
		 get { } //Length: 449
	}

	public int Int32Val
	{
		 get { } //Length: 448
	}

	public long Int64Val
	{
		 get { } //Length: 449
	}

	public bool IsNullRef
	{
		 get { } //Length: 76
	}

	public object ObjectVal
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public sbyte SByteVal
	{
		 get { } //Length: 449
	}

	public float SingleVal
	{
		 get { } //Length: 451
	}

	public string StringVal
	{
		 get { } //Length: 431
	}

	public ushort UInt16Val
	{
		 get { } //Length: 449
	}

	public uint UInt32Val
	{
		 get { } //Length: 448
	}

	public ulong UInt64Val
	{
		 get { } //Length: 449
	}

	private static ConstVal() { }

	private ConstVal(object value) { }

	public static ConstVal Get(float value) { }

	public static ConstVal Get(uint value) { }

	public static ConstVal Get(decimal value) { }

	public static ConstVal Get(object p) { }

	public static ConstVal Get(string value) { }

	public static ConstVal Get(int value) { }

	public static ConstVal Get(bool value) { }

	public static ConstVal Get(long value) { }

	public static ConstVal Get(ulong value) { }

	public static ConstVal Get(double value) { }

	public bool get_BooleanVal() { }

	public byte get_ByteVal() { }

	public char get_CharVal() { }

	public decimal get_DecimalVal() { }

	public double get_DoubleVal() { }

	public short get_Int16Val() { }

	public int get_Int32Val() { }

	public long get_Int64Val() { }

	public bool get_IsNullRef() { }

	[CompilerGenerated]
	public object get_ObjectVal() { }

	public sbyte get_SByteVal() { }

	public float get_SingleVal() { }

	public string get_StringVal() { }

	public ushort get_UInt16Val() { }

	public uint get_UInt32Val() { }

	public ulong get_UInt64Val() { }

	public static ConstVal GetDefaultValue(ConstValKind kind) { }

	private static bool IsDefault(object o) { }

	public bool IsZero(ConstValKind kind) { }

	private static T SpecialUnbox(object o) { }

}

