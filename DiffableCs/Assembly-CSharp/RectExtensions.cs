//Type is in global namespace

[Extension]
public static class RectExtensions
{
	private static readonly Rect s_empty; //Field offset: 0x0

	public static Rect Empty
	{
		 get { } //Length: 95
	}

	private static RectExtensions() { }

	[Extension]
	public static bool Contains(Rect self, Rect rect) { }

	private static Rect CreateEmptyRect() { }

	public static Rect get_Empty() { }

	[Extension]
	public static bool IsEmpty(Rect self) { }

}

