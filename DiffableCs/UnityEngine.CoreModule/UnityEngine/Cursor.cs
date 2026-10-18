namespace UnityEngine;

[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
public class Cursor
{

	public static CursorLockMode lockState
	{
		 get { } //Length: 69
		 set { } //Length: 76
	}

	public static bool visible
	{
		 get { } //Length: 69
		 set { } //Length: 78
	}

	public static CursorLockMode get_lockState() { }

	public static bool get_visible() { }

	public static void set_lockState(CursorLockMode value) { }

	public static void set_visible(bool value) { }

	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

}

