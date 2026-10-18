namespace Vuplex.WebView.Internal;

public static class CursorHelper
{
	private class CursorInfo
	{
		[CompilerGenerated]
		private Vector2 <HotSpot>k__BackingField; //Field offset: 0x10
		private Texture2D _texture; //Field offset: 0x18
		private string _textureName; //Field offset: 0x20

		public private Vector2 HotSpot
		{
			[CompilerGenerated]
			 get { } //Length: 19
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public Texture2D Texture
		{
			 get { } //Length: 320
		}

		public CursorInfo(string textureName, Vector2 hotSpot) { }

		[CompilerGenerated]
		public Vector2 get_HotSpot() { }

		public Texture2D get_Texture() { }

		[CompilerGenerated]
		private void set_HotSpot(Vector2 value) { }

	}

	private static Dictionary _supportedCursors; //Field offset: 0x0

	private static CursorHelper() { }

	public static void SetCursorIcon(string cursorType) { }

}

