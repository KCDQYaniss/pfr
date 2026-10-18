namespace System.Numerics;

internal static class BigIntegerCalculator
{
	private static int ReducerThreshold; //Field offset: 0x0
	private static int SquareThreshold; //Field offset: 0x4
	private static int AllocationThreshold; //Field offset: 0x8
	private static int MultiplyThreshold; //Field offset: 0xC

	private static BigIntegerCalculator() { }

	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	public static uint[] Add(uint[] left, uint right) { }

	public static uint[] Add(uint[] left, uint[] right) { }

	private static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) { }

	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	public static int Compare(uint[] left, uint[] right) { }

	private static uint[] CreateCopy(uint[] value) { }

	private static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	public static uint[] Divide(uint[] left, uint right) { }

	public static uint[] Divide(uint[] left, uint[] right) { }

	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	private static int LeadingZeros(uint value) { }

	public static uint[] Multiply(uint[] left, uint right) { }

	public static uint[] Multiply(uint[] left, uint[] right) { }

	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	public static uint Remainder(uint[] left, uint right) { }

	public static uint[] Remainder(uint[] left, uint[] right) { }

	public static uint[] Square(uint[] value) { }

	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	public static uint[] Subtract(uint[] left, uint right) { }

	public static uint[] Subtract(uint[] left, uint[] right) { }

	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	private static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) { }

}

