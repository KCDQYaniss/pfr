namespace BitPacking;

public static class BitsHelper
{
	internal static class Enum`1
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal long <.cctor>b__4_0(KeyValuePair x) { }

			internal TEnum <.cctor>b__4_1(KeyValuePair x) { }

			internal long <.cctor>b__4_2(KeyValuePair x) { }

			internal TEnum <.cctor>b__4_3(KeyValuePair x) { }

			internal long <.cctor>b__4_4(KeyValuePair x) { }

			internal TEnum <.cctor>b__4_5(KeyValuePair x) { }

			internal long <.cctor>b__4_6(TEnum enum) { }

			internal long <.cctor>b__4_7(KeyValuePair x) { }

			internal TEnum <.cctor>b__4_8(KeyValuePair x) { }

		}

		public static readonly long Min; //Field offset: 0x0
		public static readonly long Max; //Field offset: 0x0
		private static readonly Func IntCaster; //Field offset: 0x0
		private static readonly Dictionary IntToEnumTable; //Field offset: 0x0

		private static Enum`1() { }

		public static TEnum ToEnum(long i) { }

		public static long ToInt(TEnum e) { }

	}

	private static class EnumToByte`1
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__6_0; //Field offset: 0x0
			public static Func <>9__6_1; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal byte <get_IntToEnumTable>b__6_0(TEnum x) { }

			internal TEnum <get_IntToEnumTable>b__6_1(TEnum x) { }

		}


		public static Dictionary IntToEnumTable
		{
			 get { } //Length: 2007
		}

		public static byte Max
		{
			 get { } //Length: 429
		}

		public static byte Min
		{
			 get { } //Length: 429
		}

		public static Dictionary get_IntToEnumTable() { }

		public static byte get_Max() { }

		public static byte get_Min() { }

		public static long ToIntCaster(TEnum arg) { }

	}

	private static class EnumToInt`1
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__6_0; //Field offset: 0x0
			public static Func <>9__6_1; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal int <get_IntToEnumTable>b__6_0(TEnum x) { }

			internal TEnum <get_IntToEnumTable>b__6_1(TEnum x) { }

		}


		public static Dictionary IntToEnumTable
		{
			 get { } //Length: 1853
		}

		public static int Max
		{
			 get { } //Length: 407
		}

		public static int Min
		{
			 get { } //Length: 407
		}

		public static Dictionary get_IntToEnumTable() { }

		public static int get_Max() { }

		public static int get_Min() { }

		public static long ToIntCaster(TEnum arg) { }

	}

	private static class EnumToLong`1
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__6_0; //Field offset: 0x0
			public static Func <>9__6_1; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal long <get_IntToEnumTable>b__6_0(TEnum x) { }

			internal TEnum <get_IntToEnumTable>b__6_1(TEnum x) { }

		}


		public static Dictionary IntToEnumTable
		{
			 get { } //Length: 1837
		}

		public static long Max
		{
			 get { } //Length: 407
		}

		public static long Min
		{
			 get { } //Length: 407
		}

		public static Dictionary get_IntToEnumTable() { }

		public static long get_Max() { }

		public static long get_Min() { }

		public static long ToIntCaster(TEnum arg) { }

	}

	private static class EnumToShort`1
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__6_0; //Field offset: 0x0
			public static Func <>9__6_1; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal short <get_IntToEnumTable>b__6_0(TEnum x) { }

			internal TEnum <get_IntToEnumTable>b__6_1(TEnum x) { }

		}


		public static Dictionary IntToEnumTable
		{
			 get { } //Length: 2007
		}

		public static short Max
		{
			 get { } //Length: 429
		}

		public static short Min
		{
			 get { } //Length: 429
		}

		public static Dictionary get_IntToEnumTable() { }

		public static short get_Max() { }

		public static short get_Min() { }

		public static long ToIntCaster(TEnum arg) { }

	}


	public static int BitRequired(long min, long max) { }

	public static void CalculateDataForQuantizing(float min, float max, float res, out float delta, out int maxIntegerValue, out int bits) { }

	public static float DequantizeUIntToFloat(uint integerValue, float min, int maxIntegerValue, float delta) { }

	public static uint Log2(uint value) { }

	private static uint Popcount(uint x) { }

	public static uint QuantizeFloatValue(float value, float min, float delta, int maxIntegerValue) { }

}

