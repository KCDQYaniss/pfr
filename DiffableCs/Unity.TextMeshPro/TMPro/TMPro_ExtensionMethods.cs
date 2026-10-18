namespace TMPro;

[Extension]
public static class TMPro_ExtensionMethods
{

	[Extension]
	public static string ArrayToString(char[] chars) { }

	[Extension]
	public static bool Compare(Color32 a, Color32 b) { }

	[Extension]
	public static bool Compare(Color a, Color b) { }

	[Extension]
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[Extension]
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }

	[Extension]
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[Extension]
	public static bool CompareRGB(Color a, Color b) { }

	[Extension]
	public static int FindInstanceID(List list, T target) { }

	[Extension]
	public static string IntToString(int[] unicodes) { }

	[Extension]
	public static string IntToString(int[] unicodes, int start, int length) { }

	[Extension]
	public static Color MinAlpha(Color c1, Color c2) { }

	[Extension]
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[Extension]
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[Extension]
	public static Color32 Tint(Color32 c1, float tint) { }

	[Extension]
	public static int[] ToIntArray(string text) { }

	[Extension]
	internal static string UintToString(List unicodes) { }

}

