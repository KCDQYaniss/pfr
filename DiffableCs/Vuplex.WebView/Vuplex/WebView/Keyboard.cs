namespace Vuplex.WebView;

public class Keyboard : BaseKeyboard
{
	private const float DEFAULT_KEYBOARD_WIDTH = 0.5; //Field offset: 0x0
	private const float DEFAULT_KEYBOARD_HEIGHT = 0.125; //Field offset: 0x0
	[FormerlySerializedAs("InitialResolution")]
	[Label("Resolution (px / Unity unit)")]
	[Tooltip("You can change this to make web content appear larger or smaller.")]
	public float Resolution; //Field offset: 0x50

	[Obsolete("Keyboard.InitialResolution is now deprecated. Please use Keyboard.Resolution instead.")]
	public float InitialResolution
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public WebViewPrefab WebViewPrefab
	{
		 get { } //Length: 112
	}

	private void _initKeyboard() { }

	public Keyboard() { }

	public float get_InitialResolution() { }

	public WebViewPrefab get_WebViewPrefab() { }

	[Obsolete("Keyboard.Init() has been removed. The Keyboard script now initializes itself automatically, so Init() no longer needs to be called.", True)]
	public void Init(float width, float height) { }

	public static Keyboard Instantiate() { }

	public static Keyboard Instantiate(float width, float height) { }

	public void set_InitialResolution(float value) { }

	private void Start() { }

}

