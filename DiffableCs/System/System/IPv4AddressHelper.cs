namespace System;

internal static class IPv4AddressHelper
{

	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	private static bool Parse(string name, byte* numbers, int start, int end) { }

	private static bool ParseCanonical(ReadOnlySpan name, byte* numbers, int start, int end) { }

	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	internal static int ParseHostNumber(ReadOnlySpan str, int start, int end) { }

	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

}

