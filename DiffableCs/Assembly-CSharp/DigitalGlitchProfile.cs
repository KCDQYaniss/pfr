//Type is in global namespace

[CreateAssetMenu(menuName = "Effects/Digital Glitch")]
public class DigitalGlitchProfile : ScriptableObject
{
	[SerializeField]
	private Shader _shader; //Field offset: 0x18
	[Header("Global")]
	[SerializeField]
	[Tooltip("Initial on/off switch for the whole composite glitch effect. Runtime playback is controlled by Glitch.Play / Glitch.Stop.")]
	private bool _activate; //Field offset: 0x20
	[SerializeField]
	[Tooltip("If enabled, Glitch will stop itself and set Effect Enabled to false when playback reaches the end.")]
	private bool _autoDisableOnComplete; //Field offset: 0x21
	[Header("Blur")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("How much the blurred image is blended over the original image.")]
	private float _blurIntensity; //Field offset: 0x24
	[SerializeField]
	[Tooltip("Delay before blur starts after the whole effect has started, in seconds.")]
	private float _blurStartTime; //Field offset: 0x28
	[Min(0.001)]
	[SerializeField]
	[Tooltip("Total lifetime of the blur stage before the next stage starts, in seconds.")]
	private float _blurDuration; //Field offset: 0x2C
	[Min(0)]
	[SerializeField]
	[Tooltip("Time inside the blur stage needed to grow from zero to the configured blur values.")]
	private float _blurFadeInTime; //Field offset: 0x30
	[Min(0)]
	[SerializeField]
	[Tooltip("Blur time multiplier. 1 = normal speed, 2 = two times faster.")]
	private float _blurSpeed; //Field offset: 0x34
	[Range(0, 100)]
	[SerializeField]
	[Tooltip("Maximum Kawase blur offset in screen pixels.")]
	private float _blurStrength; //Field offset: 0x38
	[Range(1, 4)]
	[SerializeField]
	[Tooltip("Kawase blur iterations. Higher is smoother and wider, but more expensive.")]
	private int _blurQuality; //Field offset: 0x3C
	[Header("Pixelation")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("How much the pixelated image is blended over the previous blur stage.")]
	private float _pixelationIntensity; //Field offset: 0x40
	[SerializeField]
	[Tooltip("Delay before pixelation starts after the blur stage is finished, in seconds.")]
	private float _pixelationStartTime; //Field offset: 0x44
	[Min(0.001)]
	[SerializeField]
	[Tooltip("Total lifetime of the pixelation stage before the next stage starts, in seconds.")]
	private float _pixelationDuration; //Field offset: 0x48
	[Min(0)]
	[SerializeField]
	[Tooltip("Time inside the pixelation stage needed to grow from zero to the configured pixelation values.")]
	private float _pixelationFadeInTime; //Field offset: 0x4C
	[Min(0)]
	[SerializeField]
	[Tooltip("Pixelation time multiplier. 1 = normal speed, 2 = two times faster.")]
	private float _pixelationSpeed; //Field offset: 0x50
	[Range(1, 256)]
	[SerializeField]
	[Tooltip("Final size of one pixel block in screen pixels. 64 means very large blocks, like rendering the screen at a tiny resolution.")]
	private float _pixelationStrength; //Field offset: 0x54
	[Header("Overlay")]
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("How much the overlay stage is blended over the previous stages.")]
	private float _overlayIntensity; //Field offset: 0x58
	[SerializeField]
	[Tooltip("Delay before overlay starts after the pixelation stage is finished, in seconds.")]
	private float _overlayStartTime; //Field offset: 0x5C
	[Min(0.001)]
	[SerializeField]
	[Tooltip("Total lifetime of the overlay stage before the whole effect completes, in seconds.")]
	private float _overlayDuration; //Field offset: 0x60
	[Min(0)]
	[SerializeField]
	[Tooltip("Time inside the overlay stage needed to grow from zero to the configured overlay values.")]
	private float _overlayFadeInTime; //Field offset: 0x64
	[Min(0)]
	[SerializeField]
	[Tooltip("Overlay stage time multiplier. 1 = normal speed, 2 = two times faster.")]
	private float _overlaySpeed; //Field offset: 0x68
	[Range(0, 8)]
	[SerializeField]
	[Tooltip("Brightness / visibility strength of the overlay texture.")]
	private float _overlayStrength; //Field offset: 0x6C
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("Alpha of the visible colored overlay texture itself. This does not affect the background color.")]
	private float _overlayAlpha; //Field offset: 0x70
	[SerializeField]
	[Tooltip("Background color that appears behind the overlay textures. Alpha controls how strongly this color covers the underlying image.")]
	private Color overlayBackgroundColor; //Field offset: 0x74
	[SerializeField]
	[Tooltip("Optional 4x4 atlas used as an animated visible overlay. Each cell is one fullscreen overlay frame.")]
	private Texture2D _overlayAtlas; //Field offset: 0x88
	[Min(0)]
	[SerializeField]
	[Tooltip("How many atlas cells are switched per second.")]
	private float _overlayAtlasFrameRate; //Field offset: 0x90
	[SerializeField]
	[Tooltip("Random seed for choosing atlas cells.")]
	private int _overlayAtlasSeed; //Field offset: 0x94
	[SerializeField]
	[Tooltip("If enabled, atlas cells are selected randomly over time. If disabled, cells play sequentially from 0 to 15.")]
	private bool _overlayAtlasRandomize; //Field offset: 0x98
	[Range(0.1, 8)]
	[SerializeField]
	[Tooltip("Contrast of the overlay atlas. Higher values make the overlay texture read more clearly.")]
	private float _overlayAtlasContrast; //Field offset: 0x9C

	public bool Activate
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool AutoDisableOnComplete
	{
		 get { } //Length: 5
	}

	public float BlurDuration
	{
		 get { } //Length: 6
	}

	public float BlurFadeInTime
	{
		 get { } //Length: 6
	}

	public float BlurIntensity
	{
		 get { } //Length: 6
	}

	public int BlurQuality
	{
		 get { } //Length: 4
	}

	public float BlurSpeed
	{
		 get { } //Length: 6
	}

	public float BlurStartTime
	{
		 get { } //Length: 6
	}

	public float BlurStrength
	{
		 get { } //Length: 6
	}

	public float OverlayAlpha
	{
		 get { } //Length: 6
	}

	public Texture2D OverlayAtlas
	{
		 get { } //Length: 8
	}

	public float OverlayAtlasContrast
	{
		 get { } //Length: 9
	}

	public float OverlayAtlasFrameRate
	{
		 get { } //Length: 9
	}

	public bool OverlayAtlasRandomize
	{
		 get { } //Length: 8
	}

	public int OverlayAtlasSeed
	{
		 get { } //Length: 7
	}

	public Color OverlayBackgroundColor
	{
		 get { } //Length: 11
	}

	public float OverlayDuration
	{
		 get { } //Length: 6
	}

	public float OverlayFadeInTime
	{
		 get { } //Length: 6
	}

	public float OverlayIntensity
	{
		 get { } //Length: 6
	}

	public float OverlaySpeed
	{
		 get { } //Length: 6
	}

	public float OverlayStartTime
	{
		 get { } //Length: 6
	}

	public float OverlayStrength
	{
		 get { } //Length: 6
	}

	public float PixelationDuration
	{
		 get { } //Length: 6
	}

	public float PixelationFadeInTime
	{
		 get { } //Length: 6
	}

	public float PixelationIntensity
	{
		 get { } //Length: 6
	}

	public float PixelationSpeed
	{
		 get { } //Length: 6
	}

	public float PixelationStartTime
	{
		 get { } //Length: 6
	}

	public float PixelationStrength
	{
		 get { } //Length: 6
	}

	public Shader Shader
	{
		 get { } //Length: 5
	}

	public DigitalGlitchProfile() { }

	public bool get_Activate() { }

	public bool get_AutoDisableOnComplete() { }

	public float get_BlurDuration() { }

	public float get_BlurFadeInTime() { }

	public float get_BlurIntensity() { }

	public int get_BlurQuality() { }

	public float get_BlurSpeed() { }

	public float get_BlurStartTime() { }

	public float get_BlurStrength() { }

	public float get_OverlayAlpha() { }

	public Texture2D get_OverlayAtlas() { }

	public float get_OverlayAtlasContrast() { }

	public float get_OverlayAtlasFrameRate() { }

	public bool get_OverlayAtlasRandomize() { }

	public int get_OverlayAtlasSeed() { }

	public Color get_OverlayBackgroundColor() { }

	public float get_OverlayDuration() { }

	public float get_OverlayFadeInTime() { }

	public float get_OverlayIntensity() { }

	public float get_OverlaySpeed() { }

	public float get_OverlayStartTime() { }

	public float get_OverlayStrength() { }

	public float get_PixelationDuration() { }

	public float get_PixelationFadeInTime() { }

	public float get_PixelationIntensity() { }

	public float get_PixelationSpeed() { }

	public float get_PixelationStartTime() { }

	public float get_PixelationStrength() { }

	public Shader get_Shader() { }

	public void set_Activate(bool value) { }

}

