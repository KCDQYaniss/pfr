namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
internal struct Bitwise
{

	internal static int AlignDown(int value, int alignPow2) { }

	internal static int AlignUp(int value, int alignPow2) { }

	internal static int CountBits(ulong* ptr, int length, int pos, int numBits = 1) { }

	internal static uint ExtractBits(uint input, int pos, uint mask) { }

	internal static ulong ExtractBits(ulong input, int pos, ulong mask) { }

	internal static int Find(ulong* ptr, int pos, int count, int numBits) { }

	private static int FindByte(ulong* ptr, int beginBit, int endBit, int numBits) { }

	private static int FindUint(ulong* ptr, int beginBit, int endBit, int numBits) { }

	private static int FindUlong(ulong* ptr, int beginBit, int endBit, int numBits) { }

	private static int FindUpto14bits(ulong* ptr, int beginBit, int endBit, int numBits) { }

	private static int FindUpto6bits(ulong* ptr, int beginBit, int endBit, int numBits) { }

	private static int FindUshort(ulong* ptr, int beginBit, int endBit, int numBits) { }

	internal static int FindWithBeginEnd(ulong* ptr, int beginBit, int endBit, int numBits) { }

	internal static int FromBool(bool value) { }

	internal static ulong GetBits(ulong* ptr, int length, int pos, int numBits = 1) { }

	internal static bool IsSet(ulong* ptr, int pos) { }

	internal static int lzcnt(ushort value) { }

	internal static int lzcnt(byte value) { }

	internal static uint ReplaceBits(uint input, int pos, uint mask, uint value) { }

	internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value) { }

	internal static uint SetBits(uint input, int pos, uint mask, bool value) { }

	internal static ulong SetBits(ulong input, int pos, ulong mask, bool value) { }

	internal static bool TestAll(ulong* ptr, int length, int pos, int numBits = 1) { }

	internal static bool TestAny(ulong* ptr, int length, int pos, int numBits = 1) { }

	internal static bool TestNone(ulong* ptr, int length, int pos, int numBits = 1) { }

	internal static int tzcnt(ushort value) { }

	internal static int tzcnt(byte value) { }

}

