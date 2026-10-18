namespace Sirenix.Utilities;

[Extension]
public static class ListExtensions
{

	public static void SetLength(ref IList list, int length) { }

	public static void SetLength(ref IList list, int length, Func newElement) { }

	[Extension]
	public static void SetLength(IList list, int length) { }

	[Extension]
	public static void SetLength(IList list, int length, Func newElement) { }

}

