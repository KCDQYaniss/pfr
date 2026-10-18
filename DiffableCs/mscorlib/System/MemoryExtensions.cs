namespace System;

[Extension]
public static class MemoryExtensions
{

	[Extension]
	public static Memory AsMemory(T[] array, int start, int length) { }

	[Extension]
	public static Memory AsMemory(T[] array, int start) { }

	[Extension]
	public static Span AsSpan(T[] array, int start) { }

	[Extension]
	public static ReadOnlySpan AsSpan(string text) { }

	[Extension]
	public static ReadOnlySpan AsSpan(string text, int start) { }

	[Extension]
	public static ReadOnlySpan AsSpan(string text, int start, int length) { }

	[Extension]
	public static Span AsSpan(ArraySegment segment) { }

	[Extension]
	public static Span AsSpan(T[] array, int start, int length) { }

	[Extension]
	public static Span AsSpan(T[] array) { }

	[Extension]
	internal static bool Contains(ReadOnlySpan source, char value) { }

	[Extension]
	public static void CopyTo(T[] source, Span destination) { }

	[Extension]
	public static bool EndsWith(ReadOnlySpan span, ReadOnlySpan value, StringComparison comparisonType) { }

	[Extension]
	public static bool EndsWith(ReadOnlySpan span, ReadOnlySpan value) { }

	[Extension]
	internal static bool EqualsOrdinal(ReadOnlySpan span, ReadOnlySpan value) { }

	[Extension]
	internal static bool EqualsOrdinalIgnoreCase(ReadOnlySpan span, ReadOnlySpan value) { }

	[Extension]
	public static int IndexOf(Span span, T value) { }

	[Extension]
	public static int IndexOf(ReadOnlySpan span, T value) { }

	[Extension]
	public static int IndexOfAny(ReadOnlySpan span, T value0, T value1) { }

	[Extension]
	public static int IndexOfAny(ReadOnlySpan span, ReadOnlySpan values) { }

	private static bool IsTypeComparableAsBytes(out ulong size) { }

	[Extension]
	public static int LastIndexOf(ReadOnlySpan span, T value) { }

	[Extension]
	public static bool SequenceEqual(ReadOnlySpan span, ReadOnlySpan other) { }

	[Extension]
	public static bool StartsWith(ReadOnlySpan span, ReadOnlySpan value) { }

	[Extension]
	public static bool StartsWith(ReadOnlySpan span, ReadOnlySpan value, StringComparison comparisonType) { }

	[Extension]
	public static int ToUpperInvariant(ReadOnlySpan source, Span destination) { }

	[Extension]
	public static ReadOnlySpan Trim(ReadOnlySpan span) { }

	[Extension]
	public static ReadOnlySpan TrimEnd(ReadOnlySpan span) { }

	[Extension]
	public static ReadOnlySpan TrimStart(ReadOnlySpan span) { }

}

