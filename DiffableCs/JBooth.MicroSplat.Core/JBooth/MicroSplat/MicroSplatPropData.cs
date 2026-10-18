namespace JBooth.MicroSplat;

public class MicroSplatPropData : ScriptableObject
{
	internal enum PerTexColor
	{
		Tint = 4,
		SSSRTint = 72,
		TraxTint = 84,
	}

	internal enum PerTexFloat
	{
		InterpolationContrast = 5,
		NormalStrength = 8,
		Smoothness = 9,
		AO = 10,
		Metallic = 11,
		Brightness = 12,
		Contrast = 13,
		Porosity = 14,
		Foam = 15,
		DetailNoiseStrength = 16,
		DistanceNoiseStrength = 17,
		DistanceResample = 18,
		DisplacementMip = 19,
		GeoTexStrength = 20,
		GeoTintStrength = 21,
		GeoNormalStrength = 22,
		GlobalSmoothMetalAOStength = 23,
		DisplacementStength = 24,
		DisplacementBias = 25,
		DisplacementOffset = 26,
		GlobalEmisStength = 27,
		NoiseNormal0Strength = 28,
		NoiseNormal1Strength = 29,
		NoiseNormal2Strength = 30,
		WindParticulateStrength = 31,
		SnowAmount = 32,
		GlitterAmount = 33,
		GeoHeightFilter = 34,
		GeoHeightFilterStrength = 35,
		TriplanarMode = 36,
		TriplanarContrast = 37,
		StochatsicEnabled = 38,
		Saturation = 39,
		TextureClusterContrast = 40,
		TextureClusterBoost = 41,
		HeightOffset = 42,
		HeightContrast = 43,
		AntiTileArrayNormalStrength = 56,
		AntiTileArrayDetailStrength = 57,
		AntiTileArrayDistanceStrength = 58,
		DisplaceShaping = 59,
		UVRotation = 64,
		TriplanarRotationX = 65,
		TriplanarRotationY = 66,
		FuzzyShadingCore = 68,
		FuzzyShadingEdge = 69,
		FuzzyShadingPower = 70,
		SSSThickness = 75,
		CurveInterpolator = 76,
		TraxDigDepth = 80,
		TraxOpacity = 81,
		TraxNormalStrength = 82,
		NoiseHeightFrequency = 88,
		NoiseHeightAmplitude = 89,
		NoiseUVFrequency = 90,
		NoiseUVAmplitude = 91,
		ColorIntensity = 92,
		ScatterBlendMode = 98,
		ScatterAlphaMult = 99,
		ScatterDistanceFade = 104,
		RimPower = 105,
	}

	internal enum PerTexVector2
	{
		SplatUVScale = 0,
		SplatUVOffset = 2,
	}

	public const int sMaxAttributes = 32; //Field offset: 0x0
	[HideInInspector]
	public Color[] values; //Field offset: 0x18
	[HideInInspector]
	public Texture2D propTex; //Field offset: 0x20
	[HideInInspector]
	public AnimationCurve geoCurve; //Field offset: 0x28
	[HideInInspector]
	public Texture2D geoTex; //Field offset: 0x30
	[HideInInspector]
	public AnimationCurve geoSlopeFilter; //Field offset: 0x38
	[HideInInspector]
	public Texture2D geoSlopeTex; //Field offset: 0x40
	[HideInInspector]
	public AnimationCurve globalSlopeFilter; //Field offset: 0x48
	[HideInInspector]
	public Texture2D globalSlopeTex; //Field offset: 0x50
	[HideInInspector]
	public int maxTextures; //Field offset: 0x58

	public MicroSplatPropData() { }

	private void ClearPropTex() { }

	public Texture2D GetGeoCurve() { }

	public Texture2D GetGeoSlopeFilter() { }

	public Texture2D GetGlobalSlopeFilter() { }

	public Texture2D GetTexture() { }

	public Color GetValue(int x, int y) { }

	public void RevisionData() { }

	public void SetValue(int x, int y, Color c) { }

	public void SetValue(int x, int y, int channel, float value) { }

	public void SetValue(int x, int y, int channel, Vector2 value) { }

	public void SetValue(int textureIndex, PerTexFloat channel, float value) { }

	public void SetValue(int textureIndex, PerTexColor channel, Color value) { }

	public void SetValue(int textureIndex, PerTexVector2 channel, Vector2 value) { }

}

