namespace Vuplex.WebView;

public class CanvasKeyboard : BaseKeyboard
{
	[FormerlySerializedAs("InitialResolution")]
	[Label("Resolution (px / Unity unit)")]
	[Tooltip("You can change this to make web content appear larger or smaller.")]
	public float Resolution; //Field offset: 0x50

	[Obsolete("CanvasKeyboard.InitialResolution is now deprecated. Please use CanvasKeyboard.Resolution instead.")]
	public float InitialResolution
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public CanvasWebViewPrefab WebViewPrefab
	{
		 get { } //Length: 112
	}

	private void _initCanvasKeyboard() { }

	public CanvasKeyboard() { }

	public float get_InitialResolution() { }

	public CanvasWebViewPrefab get_WebViewPrefab() { }

	public static CanvasKeyboard Instantiate() { }

	public void set_InitialResolution(float value) { }

	private void Start() { }

}

