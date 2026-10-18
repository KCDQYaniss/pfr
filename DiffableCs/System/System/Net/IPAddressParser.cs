namespace System.Net;

internal class IPAddressParser
{

	private static void AppendHex(ushort value, StringBuilder buffer) { }

	private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	private static uint ExtractIPv4Address(ushort[] address) { }

	private static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset) { }

	internal static string IPv4AddressToString(uint address) { }

	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	private static int IPv4AddressToStringHelper(uint address, char* addressString) { }

	public static bool Ipv4StringToAddress(ReadOnlySpan ipSpan, out long address) { }

	internal static string IPv6AddressToString(ushort[] address, uint scopeId) { }

	internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId) { }

	public static bool Ipv6StringToAddress(ReadOnlySpan ipSpan, ushort* numbers, int numbersLength, out uint scope) { }

	internal static IPAddress Parse(ReadOnlySpan ipSpan, bool tryParse) { }

	private static ushort Reverse(ushort number) { }

}

