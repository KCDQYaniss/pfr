namespace BitPacking;

[Extension]
public static class BitStreamExtensions
{

	[Conditional("SERIALIZATION_VALIDATION")]
	[Extension]
	public static void DefineDependedCheck(IBitStream stream, uint checkNumber, string message = null) { }

}

