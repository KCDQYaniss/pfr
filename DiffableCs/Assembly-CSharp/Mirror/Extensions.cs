namespace Mirror;

[Extension]
public static class Extensions
{

	[Extension]
	public static void CopyTo(IEnumerable source, List destination) { }

	[Extension]
	internal static string GetMethodName(Delegate func) { }

	[Extension]
	public static int GetStableHashCode(string text) { }

	[Extension]
	public static string ToHexString(ArraySegment segment) { }

	[Extension]
	public static bool TryDequeue(Queue source, out T element) { }

}

