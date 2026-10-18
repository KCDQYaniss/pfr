//Type is in global namespace

[AddComponentMenu("Colorful/Sharpen")]
[ExecuteInEditMode]
public class CC_Sharpen : CC_Base
{
	private static readonly int _px; //Field offset: 0x0
	private static readonly int _py; //Field offset: 0x4
	private static readonly int _strength; //Field offset: 0x8
	private static readonly int _clamp; //Field offset: 0xC
	private static readonly int _nightVisionRatio; //Field offset: 0x10
	private static readonly int _rampTex; //Field offset: 0x14
	private static readonly int _desatWeather; //Field offset: 0x18
	private static readonly int _desatHealth; //Field offset: 0x1C
	private static readonly int _desatMask; //Field offset: 0x20
	private static readonly int _rampOffset; //Field offset: 0x24
	private static readonly int _radius; //Field offset: 0x28
	private static readonly int _radiusFalloff; //Field offset: 0x2C
	[Range(0, 5)]
	public float strength; //Field offset: 0x38
	[Range(0, 1)]
	public float clamp; //Field offset: 0x3C
	public bool DoDesaturate; //Field offset: 0x40
	[CompilerGenerated]
	private DesaturateEffect <DesaturateEffectSettingsProvider>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <FailedToGetDesaturate>k__BackingField; //Field offset: 0x50
	public Texture textureRamp; //Field offset: 0x58
	public float rampOffsetR; //Field offset: 0x60
	public float rampOffsetG; //Field offset: 0x64
	public float rampOffsetB; //Field offset: 0x68
	public float WeatherDesaturate; //Field offset: 0x6C
	public float HealthDesaturate; //Field offset: 0x70
	public float MaskDesaturate; //Field offset: 0x74
	public Vector2 MinMaxRadius; //Field offset: 0x78
	[Range(0, 1)]
	public float Radius; //Field offset: 0x80
	[Range(0, 1)]
	public float RadiusFalloff; //Field offset: 0x84
	private readonly string _desaturateKeyword; //Field offset: 0x88

	public private DesaturateEffect DesaturateEffectSettingsProvider
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool FailedToGetDesaturate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static CC_Sharpen() { }

	public CC_Sharpen() { }

	[CompilerGenerated]
	public DesaturateEffect get_DesaturateEffectSettingsProvider() { }

	[CompilerGenerated]
	public bool get_FailedToGetDesaturate() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	[CompilerGenerated]
	private void set_DesaturateEffectSettingsProvider(DesaturateEffect value) { }

	[CompilerGenerated]
	private void set_FailedToGetDesaturate(bool value) { }

}

