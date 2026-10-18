namespace UnityEngine.UIElements;

internal static class StyleCache
{
	private static Dictionary s_ComputedStyleCache; //Field offset: 0x0
	private static Dictionary s_StyleVariableContextCache; //Field offset: 0x8
	private static Dictionary s_ComputedTransitionsCache; //Field offset: 0x10

	private static StyleCache() { }

	public static void SetValue(long hash, ref ComputedStyle data) { }

	public static void SetValue(int hash, StyleVariableContext data) { }

	public static void SetValue(int hash, ComputedTransitionProperty[] data) { }

	public static bool TryGetValue(long hash, out ComputedStyle data) { }

	public static bool TryGetValue(int hash, out StyleVariableContext data) { }

	public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data) { }

}

