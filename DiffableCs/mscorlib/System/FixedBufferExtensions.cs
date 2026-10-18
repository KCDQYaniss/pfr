namespace System;

[Extension]
internal static class FixedBufferExtensions
{

	[Extension]
	internal static bool FixedBufferEqualsString(ReadOnlySpan span, string value) { }

	[Extension]
	internal static int GetFixedBufferStringLength(ReadOnlySpan span) { }

	[Extension]
	internal static string GetStringFromFixedBuffer(ReadOnlySpan span) { }

}

