//Type is in global namespace

public class PhotoManager
{
	[CompilerGenerated]
	private static class <>O
	{
		public static TextureRenderFinishedHandler <0>__OnFinished; //Field offset: 0x0

	}

	public static int MaxPoolSize; //Field offset: 0x0
	public static Vector3 CameraPosition; //Field offset: 0x4
	private static Queue _photoCameraPool; //Field offset: 0x10
	private static int _callerId; //Field offset: 0x18

	private static PhotoManager() { }

	public PhotoManager() { }

	public static void MakeTexture(GameObject gObject, Action callback) { }

	private static void OnFinished(PhotoCamera sender) { }

}

