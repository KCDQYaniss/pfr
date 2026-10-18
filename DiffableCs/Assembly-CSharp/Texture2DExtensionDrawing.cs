//Type is in global namespace

[Extension]
public static class Texture2DExtensionDrawing
{

	[Extension]
	public static void DrawLine(Texture2D tex, Vector2 v1, Vector2 v2, Color col) { }

	[Extension]
	public static void DrawLine(Texture2D tex, int x0, int y0, int x1, int y1, Color col) { }

	[Extension]
	public static void Fill(Texture2D t, Color c) { }

}

