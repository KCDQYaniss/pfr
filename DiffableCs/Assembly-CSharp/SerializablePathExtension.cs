//Type is in global namespace

[Extension]
public static class SerializablePathExtension
{

	public static Vector2 ScreenCenter
	{
		 get { } //Length: 190
	}

	[Extension]
	public static void DrawPathDebug(NavMeshPath path, Color color, float time) { }

	public static Vector2 get_ScreenCenter() { }

}

