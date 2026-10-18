namespace System.Runtime.InteropServices;

public static class MemoryMarshal
{

	public static Span AsBytes(Span span) { }

	public static ReadOnlySpan AsBytes(ReadOnlySpan span) { }

	public static Memory AsMemory(ReadOnlyMemory memory) { }

	public static ReadOnlySpan CreateReadOnlySpan(ref T reference, int length) { }

	internal static T GetNonNullPinnableReference(Span span) { }

	internal static T GetNonNullPinnableReference(ReadOnlySpan span) { }

	public static T GetReference(Span span) { }

	public static T GetReference(ReadOnlySpan span) { }

	public static T Read(ReadOnlySpan source) { }

	public static bool TryGetArray(ReadOnlyMemory memory, out ArraySegment segment) { }

	public static bool TryWrite(Span destination, ref T value) { }

	public static void Write(Span destination, ref T value) { }

}

