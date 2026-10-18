//Type is in global namespace

public static class FindObjectsProxy
{

	public static List FindAllObjectsOfTypeOnLoadedScenes() { }

	public static List FindObjectsOfTypeAll() { }

	public static Object FindUnityObjectOfType(Type type) { }

	public static T FindUnityObjectOfType() { }

	public static T[] FindUnityObjectsOfType() { }

	public static Object[] FindUnityObjectsOfType(Type type) { }

	public static List FindUnityObjectsOfTypeUpsideDownOrder() { }

	public static List FindUnityObjectsOnScene() { }

	private static string GetCallstackMethod() { }

	[Conditional("DEBUG")]
	private static void InternalLog(string sampleName) { }

	private static void TraverseUpsideDownOrder(Transform transform, List results) { }

}

