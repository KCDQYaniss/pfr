namespace Microsoft.CSharp.RuntimeBinder.Semantics;

[Extension]
internal static class ListExtensions
{

	[Extension]
	public static T Head(List list) { }

	[Extension]
	public static bool IsEmpty(List list) { }

	[Extension]
	public static List Tail(List list) { }

}

