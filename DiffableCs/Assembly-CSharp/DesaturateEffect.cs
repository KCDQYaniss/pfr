//Type is in global namespace

[AddComponentMenu("Image Effects/Desaturate")]
[ExecuteInEditMode]
[Obfuscation(Exclude = True)]
public class DesaturateEffect : ImageEffectBase
{
	private static readonly int _nightVisionRatio; //Field offset: 0x0
	private static readonly int _rampTex; //Field offset: 0x4
	private static readonly int _desatWeather; //Field offset: 0x8
	private static readonly int _desatHealth; //Field offset: 0xC
	private static readonly int _desatMask; //Field offset: 0x10
	private static readonly int _rampOffset; //Field offset: 0x14
	private static readonly int _radius; //Field offset: 0x18
	private static readonly int _radiusFalloff; //Field offset: 0x1C
	public Texture textureRamp; //Field offset: 0x38
	public float rampOffsetR; //Field offset: 0x40
	public float rampOffsetG; //Field offset: 0x44
	public float rampOffsetB; //Field offset: 0x48
	[FormerlySerializedAs("desaturateAmount")]
	public float WeatherDesaturate; //Field offset: 0x4C
	public float HealthDesaturate; //Field offset: 0x50
	public float MaskDesaturate; //Field offset: 0x54
	public Vector2 MinMaxRadius; //Field offset: 0x58
	[Range(0, 1)]
	public float Radius; //Field offset: 0x60
	[Range(0, 1)]
	public float RadiusFalloff; //Field offset: 0x64

	private static DesaturateEffect() { }

	public DesaturateEffect() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

