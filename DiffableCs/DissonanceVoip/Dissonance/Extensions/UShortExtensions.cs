namespace Dissonance.Extensions;

[Extension]
internal static class UShortExtensions
{

	[Extension]
	private static int WrappedDelta(ushort a, ushort b, int bits) { }

	[Extension]
	internal static int WrappedDelta16(ushort a, ushort b) { }

	[Extension]
	internal static int WrappedDelta2(ushort a, ushort b) { }

	[Extension]
	internal static int WrappedDelta7(ushort a, ushort b) { }

}

