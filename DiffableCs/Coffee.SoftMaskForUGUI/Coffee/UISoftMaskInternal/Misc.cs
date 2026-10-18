namespace Coffee.UISoftMaskInternal;

internal static class Misc
{

	public static void Destroy(Object obj) { }

	public static void DestroyImmediate(Object obj) { }

	public static T[] FindObjectsOfType() { }

	[Conditional("UNITY_EDITOR")]
	public static void QueuePlayerLoopUpdate() { }

	[Conditional("UNITY_EDITOR")]
	public static void SetDirty(Object obj) { }

}

