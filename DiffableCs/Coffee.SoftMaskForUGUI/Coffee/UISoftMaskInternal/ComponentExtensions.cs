namespace Coffee.UISoftMaskInternal;

[Extension]
internal static class ComponentExtensions
{

	[Extension]
	public static void AddComponentOnChildren(Component self, HideFlags hideFlags, bool includeSelf) { }

	[Extension]
	public static void AddComponentOnChildren(Component self, bool includeSelf) { }

	[Extension]
	public static T GetComponentInParent(Component self, bool includeSelf, Transform stopAfter, Predicate valid) { }

	[Extension]
	public static T[] GetComponentsInChildren(Component self, int depth) { }

	[Extension]
	public static void GetComponentsInChildren(Component self, List results, int depth) { }

	[Extension]
	private static void GetComponentsInChildren_Internal(Component self, List results, int depth) { }

	[Extension]
	public static T GetOrAddComponent(Component self) { }

	[Extension]
	public static T GetRootComponent(Component self) { }

}

