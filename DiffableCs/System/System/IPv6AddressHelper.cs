namespace System;

internal static class IPv6AddressHelper
{

	internal static ValueTuple FindCompressionRange(ReadOnlySpan numbers) { }

	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	private static bool IsLoopback(ReadOnlySpan numbers) { }

	internal static bool IsValid(char* name, int start, ref int end) { }

	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	internal static void Parse(ReadOnlySpan address, ushort* numbers, int start, ref string scopeId) { }

	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan numbers) { }

}

