//Type is in global namespace

public class WaterSettings
{
	internal class TextureBlendSetting
	{
		public float Scale; //Field offset: 0x10
		public Vector2 MovementDirection; //Field offset: 0x14
		[Range(0, 1)]
		public float Blend; //Field offset: 0x1C

		public TextureBlendSetting() { }

		public Vector4 Pack() { }

	}

	private static readonly int _bumpMapID; //Field offset: 0x0
	private static readonly int _bumpMapDetailsID; //Field offset: 0x4
	private static readonly int _foamTexID; //Field offset: 0x8
	private static readonly int _depthValsID; //Field offset: 0xC
	private static readonly int _borderFadeDistValsID; //Field offset: 0x10
	private static readonly int _bumpinessID; //Field offset: 0x14
	private static readonly int _depthColorDeepID; //Field offset: 0x18
	private static readonly int _depthColorShallowID; //Field offset: 0x1C
	private static readonly int _foamValsID; //Field offset: 0x20
	private static readonly int _foamColorID; //Field offset: 0x24
	private static readonly int _reflectionColorID; //Field offset: 0x28
	private static readonly int _diffuseColorID; //Field offset: 0x2C
	private static readonly int _valsNormAID; //Field offset: 0x30
	private static readonly int _valsNormBID; //Field offset: 0x34
	private static readonly int _valsNormDID; //Field offset: 0x38
	private static readonly int _valsFoamAID; //Field offset: 0x3C
	private static readonly int _valsFoamBID; //Field offset: 0x40
	private static readonly int _additionalCubemapReflectionID; //Field offset: 0x44
	private static readonly int _rippleScaleID; //Field offset: 0x48
	private static readonly int _rippleBumpnessID; //Field offset: 0x4C
	private static readonly int _fresnelValsID; //Field offset: 0x50
	private static readonly int _rippleTexID; //Field offset: 0x54
	[Header("Textures")]
	[SerializeField]
	[Space]
	private Texture2D _rippleTexture; //Field offset: 0x10
	[SerializeField]
	private Texture _normals; //Field offset: 0x18
	[SerializeField]
	private Texture _normalsDetails; //Field offset: 0x20
	[SerializeField]
	private float _normalsDetailsMipMapBias; //Field offset: 0x28
	[SerializeField]
	private Texture _foam; //Field offset: 0x30
	[Header("Layers Settings")]
	[SerializeField]
	[Space(32)]
	private TextureBlendSetting _normalsA; //Field offset: 0x38
	[SerializeField]
	private TextureBlendSetting _normalsB; //Field offset: 0x40
	[SerializeField]
	private TextureBlendSetting _normalsDetails0; //Field offset: 0x48
	[SerializeField]
	[Space]
	private TextureBlendSetting _foamA; //Field offset: 0x50
	[SerializeField]
	private TextureBlendSetting _foamB; //Field offset: 0x58
	[Header("Depth Settings")]
	[SerializeField]
	[Space(32)]
	private float _borderFade; //Field offset: 0x60
	[SerializeField]
	private float _borderFadeDistStart; //Field offset: 0x64
	[SerializeField]
	private float _borderFadeDistRange; //Field offset: 0x68
	[SerializeField]
	private float _depthFade; //Field offset: 0x6C
	[SerializeField]
	private float _depthColorFade; //Field offset: 0x70
	[SerializeField]
	private float _depthRefractions; //Field offset: 0x74
	[ColorUsage(False)]
	[SerializeField]
	private Color _depthColorDeep; //Field offset: 0x78
	[ColorUsage(False)]
	[SerializeField]
	private Color _depthColorShallow; //Field offset: 0x88
	[Header("Other")]
	[SerializeField]
	[Space(32)]
	private float _bumpiness; //Field offset: 0x98
	[SerializeField]
	[Space]
	private float _rippleScale; //Field offset: 0x9C
	[SerializeField]
	private float _rippleBumpness; //Field offset: 0xA0
	[SerializeField]
	[Space]
	private float _foamSize; //Field offset: 0xA4
	[SerializeField]
	private float _foamIntensity; //Field offset: 0xA8
	[ColorUsage(False)]
	[SerializeField]
	private Color _foamColor; //Field offset: 0xAC
	[Range(0, 1)]
	[SerializeField]
	[Space]
	private float _fresnelIntensity; //Field offset: 0xBC
	[SerializeField]
	private float _fresnelPower; //Field offset: 0xC0
	[SerializeField]
	[Space]
	private float _additionalCubemapReflectionMinWetting; //Field offset: 0xC4
	[SerializeField]
	private float _additionalCubemapReflectionMaxWetting; //Field offset: 0xC8
	[SerializeField]
	private AnimationCurve _reflectionWettingFunc; //Field offset: 0xD0
	[SerializeField]
	private Color _reflectionColor; //Field offset: 0xD8
	[SerializeField]
	private Color _diffuseColor; //Field offset: 0xE8
	[CompilerGenerated]
	private bool <IsDirty>k__BackingField; //Field offset: 0xF8

	public float AdditionalCubemapReflectionMaxWetting
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float AdditionalCubemapReflectionMinWetting
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float BorderFade
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float BorderFadeDistRange
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float BorderFadeDistStart
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float Bumpiness
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public Color DepthColorDeep
	{
		 get { } //Length: 11
		 set { } //Length: 15
	}

	public float DepthColorFade
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public Color DepthColorShallow
	{
		 get { } //Length: 14
		 set { } //Length: 18
	}

	public float DepthFade
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float DepthRefractions
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public Color DiffuseColor
	{
		 get { } //Length: 14
		 set { } //Length: 18
	}

	public Texture Foam
	{
		 get { } //Length: 76
		 set { } //Length: 98
	}

	public TextureBlendSetting FoamA
	{
		 get { } //Length: 5
		 set { } //Length: 98
	}

	public TextureBlendSetting FoamB
	{
		 get { } //Length: 5
		 set { } //Length: 98
	}

	public Color FoamColor
	{
		 get { } //Length: 14
		 set { } //Length: 18
	}

	public float FoamIntensity
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public float FoamSize
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public float FresnelIntensity
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public float FresnelPower
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public private bool IsDirty
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Texture Normals
	{
		 get { } //Length: 5
		 set { } //Length: 98
	}

	public TextureBlendSetting NormalsA
	{
		 get { } //Length: 5
		 set { } //Length: 98
	}

	public TextureBlendSetting NormalsB
	{
		 get { } //Length: 5
		 set { } //Length: 98
	}

	public Texture NormalsDetails
	{
		 get { } //Length: 5
		 set { } //Length: 98
	}

	public TextureBlendSetting NormalsDetails0
	{
		 get { } //Length: 5
		 set { } //Length: 98
	}

	public float NormalsDetailsMipMapBias
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public Color ReflectionColor
	{
		 get { } //Length: 14
		 set { } //Length: 18
	}

	public AnimationCurve ReflectionWettingFunc
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public float RippleBumpness
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public float RippleScale
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public Texture2D RippleTexture
	{
		 get { } //Length: 5
		 set { } //Length: 98
	}

	private static WaterSettings() { }

	public WaterSettings() { }

	public float get_AdditionalCubemapReflectionMaxWetting() { }

	public float get_AdditionalCubemapReflectionMinWetting() { }

	public float get_BorderFade() { }

	public float get_BorderFadeDistRange() { }

	public float get_BorderFadeDistStart() { }

	public float get_Bumpiness() { }

	public Color get_DepthColorDeep() { }

	public float get_DepthColorFade() { }

	public Color get_DepthColorShallow() { }

	public float get_DepthFade() { }

	public float get_DepthRefractions() { }

	public Color get_DiffuseColor() { }

	public Texture get_Foam() { }

	public TextureBlendSetting get_FoamA() { }

	public TextureBlendSetting get_FoamB() { }

	public Color get_FoamColor() { }

	public float get_FoamIntensity() { }

	public float get_FoamSize() { }

	public float get_FresnelIntensity() { }

	public float get_FresnelPower() { }

	[CompilerGenerated]
	public bool get_IsDirty() { }

	public Texture get_Normals() { }

	public TextureBlendSetting get_NormalsA() { }

	public TextureBlendSetting get_NormalsB() { }

	public Texture get_NormalsDetails() { }

	public TextureBlendSetting get_NormalsDetails0() { }

	public float get_NormalsDetailsMipMapBias() { }

	public Color get_ReflectionColor() { }

	public AnimationCurve get_ReflectionWettingFunc() { }

	public float get_RippleBumpness() { }

	public float get_RippleScale() { }

	public Texture2D get_RippleTexture() { }

	public void set_AdditionalCubemapReflectionMaxWetting(float value) { }

	public void set_AdditionalCubemapReflectionMinWetting(float value) { }

	public void set_BorderFade(float value) { }

	public void set_BorderFadeDistRange(float value) { }

	public void set_BorderFadeDistStart(float value) { }

	public void set_Bumpiness(float value) { }

	public void set_DepthColorDeep(Color value) { }

	public void set_DepthColorFade(float value) { }

	public void set_DepthColorShallow(Color value) { }

	public void set_DepthFade(float value) { }

	public void set_DepthRefractions(float value) { }

	public void set_DiffuseColor(Color value) { }

	public void set_Foam(Texture value) { }

	public void set_FoamA(TextureBlendSetting value) { }

	public void set_FoamB(TextureBlendSetting value) { }

	public void set_FoamColor(Color value) { }

	public void set_FoamIntensity(float value) { }

	public void set_FoamSize(float value) { }

	public void set_FresnelIntensity(float value) { }

	public void set_FresnelPower(float value) { }

	[CompilerGenerated]
	private void set_IsDirty(bool value) { }

	public void set_Normals(Texture value) { }

	public void set_NormalsA(TextureBlendSetting value) { }

	public void set_NormalsB(TextureBlendSetting value) { }

	public void set_NormalsDetails(Texture value) { }

	public void set_NormalsDetails0(TextureBlendSetting value) { }

	public void set_NormalsDetailsMipMapBias(float value) { }

	public void set_ReflectionColor(Color value) { }

	public void set_ReflectionWettingFunc(AnimationCurve value) { }

	public void set_RippleBumpness(float value) { }

	public void set_RippleScale(float value) { }

	public void set_RippleTexture(Texture2D value) { }

	public void Update(MaterialPropertyBlock block) { }

	public void Validate() { }

	public void Wet(MaterialPropertyBlock block) { }

}

