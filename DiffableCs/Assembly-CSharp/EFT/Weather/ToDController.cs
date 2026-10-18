namespace EFT.Weather;

public class ToDController
{
	private struct ComputeSphericalHarmonicsContainerJob : IJob
	{
		public float t; //Field offset: 0x0
		public float t01; //Field offset: 0x4
		public Color LightColor; //Field offset: 0x8
		public Quaternion DomeRotation; //Field offset: 0x18
		public float Cloudiness; //Field offset: 0x28

		public SphericalHarmonicsContainer CalculateSphericalHarmonics(float t, float t01) { }

		public override void Execute() { }

	}

	internal struct SphericalHarmonicsContainer
	{
		public SphericalHarmonicsL2 FullSH; //Field offset: 0x0
		public SphericalHarmonicsL2 SHWithoutTop; //Field offset: 0x6C

	}

	private static SphericalHarmonicsContainer _sphericalHarmonicsContainer; //Field offset: 0x0
	[Header("midnight(-1) sunrize/sunset(0) midday(1)")]
	public Vector2 RayleighMultiplierMinMax; //Field offset: 0x10
	public AnimationCurve RayleighMultiplier; //Field offset: 0x18
	public Vector2 MieMultiplierMinMax; //Field offset: 0x20
	public AnimationCurve MieMultiplier; //Field offset: 0x28
	[Header("1 - DirectionalityMult * Directionality")]
	public float DirectionalityMult; //Field offset: 0x30
	public AnimationCurve Directionality; //Field offset: 0x38
	public Vector2 BrightnessMinMax; //Field offset: 0x40
	public AnimationCurve Brightness; //Field offset: 0x48
	public float ScatteringBrightnessMultiplier; //Field offset: 0x50
	public AnimationCurve ScatteringBrightness; //Field offset: 0x58
	public float BrightnessOvercast; //Field offset: 0x60
	public Vector2 ContrastMinMax; //Field offset: 0x64
	public AnimationCurve Contrast; //Field offset: 0x70
	[MinMaxVec2(0, 1, -1)]
	[Space(16)]
	public Vector2 MoonLightMinMax; //Field offset: 0x78
	[Space(16)]
	public Gradient LightColor; //Field offset: 0x80
	[Header("SHAmbient")]
	public AmbientLight AmbientLightScript; //Field offset: 0x88
	public AmbientHighlight AmbientHighlightScript; //Field offset: 0x90
	public bool HighlightWithoutTopHarmonics; //Field offset: 0x98
	[Space(16)]
	public AnimationCurve TopHarmonicIntensity; //Field offset: 0xA0
	public AnimationCurve HorizontHarmonicIntensity; //Field offset: 0xA8
	public AnimationCurve BounceHarmonicIntensity; //Field offset: 0xB0
	public AnimationCurve ForwarHarmonicIntensity; //Field offset: 0xB8
	[Space(16)]
	public Gradient ForwarHarmonicMultiplyer; //Field offset: 0xC0
	public Gradient BackwardHarmonicMultiplyer; //Field offset: 0xC8
	[Space(16)]
	public Gradient AddTopAmbient; //Field offset: 0xD0
	public Gradient AddAmbient; //Field offset: 0xD8
	[Space(16)]
	public AnimationCurve AmbientBrightness; //Field offset: 0xE0
	public AnimationCurve AmbientSaturation; //Field offset: 0xE8
	public AnimationCurve AmbientContrast; //Field offset: 0xF0
	public Color CloudnessLightColor; //Field offset: 0xF8
	[CompilerGenerated]
	private SphericalHarmonicsL2 <SH>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private Color <TopHorizontSkyColor>k__BackingField; //Field offset: 0x174
	[CompilerGenerated]
	private Color <EnvironmentColor>k__BackingField; //Field offset: 0x184
	[CompilerGenerated]
	private float <HarmonicsDaylight>k__BackingField; //Field offset: 0x194
	private readonly Vector3[] _dirs; //Field offset: 0x198
	private readonly float[] _qualityUpdateIntervals; //Field offset: 0x1A0
	private JobHandle _computeSphericalHarmonicsContainerJobHandle; //Field offset: 0x1A8

	public Color EnvironmentColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 11
	}

	public float HarmonicsDaylight
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public private SphericalHarmonicsL2 SH
	{
		[CompilerGenerated]
		 get { } //Length: 91
		[CompilerGenerated]
		private set { } //Length: 88
	}

	public private Color TopHorizontSkyColor
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public ToDController() { }

	public static Color ContrastColor(Color color, float t) { }

	private static Color ContrastColor2(float light, Color color, float t) { }

	[CompilerGenerated]
	public Color get_EnvironmentColor() { }

	[CompilerGenerated]
	public float get_HarmonicsDaylight() { }

	[CompilerGenerated]
	public SphericalHarmonicsL2 get_SH() { }

	[CompilerGenerated]
	public Color get_TopHorizontSkyColor() { }

	private static Color LimitColor(Color color) { }

	public static Color SaturateColor(Color color, float t) { }

	[CompilerGenerated]
	public void set_EnvironmentColor(Color value) { }

	[CompilerGenerated]
	public void set_HarmonicsDaylight(float value) { }

	[CompilerGenerated]
	private void set_SH(SphericalHarmonicsL2 value) { }

	[CompilerGenerated]
	private void set_TopHorizontSkyColor(Color value) { }

	public void Update() { }

}

