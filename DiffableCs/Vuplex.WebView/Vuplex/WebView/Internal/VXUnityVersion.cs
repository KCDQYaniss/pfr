namespace Vuplex.WebView.Internal;

public class VXUnityVersion
{
	private static VXUnityVersion _instance; //Field offset: 0x0
	public readonly int Major; //Field offset: 0x10
	public readonly int Minor; //Field offset: 0x14
	public readonly int Patch; //Field offset: 0x18
	public readonly string String; //Field offset: 0x20

	public static VXUnityVersion Instance
	{
		 get { } //Length: 215
	}

	public VXUnityVersion() { }

	public static VXUnityVersion get_Instance() { }

}

