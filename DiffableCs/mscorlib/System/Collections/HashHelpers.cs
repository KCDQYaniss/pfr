namespace System.Collections;

internal static class HashHelpers
{
	public static readonly int[] primes; //Field offset: 0x0
	private static ConditionalWeakTable s_serializationInfoTable; //Field offset: 0x8

	internal static ConditionalWeakTable SerializationInfoTable
	{
		internal get { } //Length: 318
	}

	private static HashHelpers() { }

	public static int ExpandPrime(int oldSize) { }

	internal static ConditionalWeakTable get_SerializationInfoTable() { }

	public static int GetPrime(int min) { }

	public static bool IsPrime(int candidate) { }

}

