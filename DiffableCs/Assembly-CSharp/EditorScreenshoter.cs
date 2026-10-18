//Type is in global namespace

[ExecuteInEditMode]
public class EditorScreenshoter : MonoBehaviour
{
	public const string ScreenshotsDirectory = "/EFT_Screenshots/"; //Field offset: 0x0
	[SerializeField]
	private Camera _camera; //Field offset: 0x20
	[SerializeField]
	private Vector2 _textureDimensions; //Field offset: 0x28
	[SerializeField]
	private Texture2D _screenshot; //Field offset: 0x30

	public EditorScreenshoter() { }

	public static Texture2D MakeScreenshot(Camera camera, int width, int height) { }

	public void MakeScreenshotAndSave() { }

}

