//Type is in global namespace

public class Helpers
{
	internal enum HintAlignment
	{
		Left = 0,
		Rigth = 1,
	}

	private enum Languages
	{
		Any = 0,
		En = 1,
		Ru = 2,
	}


	public Helpers() { }

	public static string ColoredLog(object obj, string color = "#00FF00") { }

	public static string ColoredTag(string tag) { }

	public static string ColoredText(object text, string color = "#FFFFFF") { }

	public static string FixedNickname(string editableName, string currentName) { }

	public static string GetTag(string tag) { }

	public static Color GetTagColor(string tag) { }

	public static string GetTagHexColor(string tag) { }

	public static string HexOnly(string str) { }

	public static Color HexToColor(string hexColor, float alpha = 1) { }

	public static void Hint(Rect onHoverRect, string hint, GUIStyle style, HintAlignment alignment = 0, float xOffset = 0, float yOffset = 0) { }

	public static void HintList(Rect onHoverRect, List list, GUIStyle style, bool left = false, float xOffset = 0, float yOffset = 0) { }

	public static bool IsPositionIdentical(Vector3 posA, Vector3 posB, float epsilon = 1.1754944E-38) { }

	public static bool IsPositionInsideCollider(Collider collider, Vector3 position) { }

	public static string KFormat(int value) { }

	public static string SeparateNumericString(string str) { }

	private static Languages WordLanguage(string s) { }

}

