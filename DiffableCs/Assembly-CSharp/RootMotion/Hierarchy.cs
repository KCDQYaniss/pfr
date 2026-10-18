namespace RootMotion;

public class Hierarchy
{

	public Hierarchy() { }

	public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array) { }

	public static bool ContainsChild(Transform transform, Transform child) { }

	public static Object ContainsDuplicate(Object[] objects) { }

	public static Transform GetAncestor(Transform transform, int minChildCount) { }

	public static Transform GetFirstCommonAncestor(Transform t1, Transform t2) { }

	public static Transform GetFirstCommonAncestor(Transform[] transforms) { }

	public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms) { }

	public static bool HierarchyIsValid(Transform[] bones) { }

	public static bool IsAncestor(Transform transform, Transform ancestor) { }

	public static bool IsCommonAncestor(Transform transform, Transform[] transforms) { }

}

