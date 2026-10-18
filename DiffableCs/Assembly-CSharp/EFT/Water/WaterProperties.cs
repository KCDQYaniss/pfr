namespace EFT.Water;

public class WaterProperties
{
	internal class DynamicWaterFoam
	{
		public bool Enabled; //Field offset: 0x10
		public Texture2D Texture; //Field offset: 0x18
		public Vector2 Direction; //Field offset: 0x20
		public Vector4 Tiling; //Field offset: 0x28
		public Vector4 Speed; //Field offset: 0x38
		public Vector2 Intensity; //Field offset: 0x48

		public DynamicWaterFoam() { }

	}

	internal class UnderwaterAbsorption
	{
		public float MaxHeight; //Field offset: 0x10
		[Range(0, 8)]
		public float Height; //Field offset: 0x14
		[Range(0, 1)]
		public float Strength; //Field offset: 0x18
		[Range(0, 0.4)]
		public float Depth; //Field offset: 0x1C
		[Range(0, 1)]
		public float Cancellation; //Field offset: 0x20
		[Range(0, 1)]
		public float ColorStrength; //Field offset: 0x24

		public UnderwaterAbsorption() { }

	}

	internal class UnderwaterColor
	{
		public Color SpecularColor; //Field offset: 0x10
		public Color FogColor; //Field offset: 0x20
		[Range(0, 1)]
		public float Smoothness; //Field offset: 0x30
		[Range(0, 1)]
		public float FresnelPower; //Field offset: 0x34
		[Range(0, 12)]
		public float ReflectionPower; //Field offset: 0x38
		[Range(0, 1)]
		public float AdditionalLightDamping; //Field offset: 0x3C
		[Range(1, 10)]
		public float UnderwaterSurfaceTranslucency; //Field offset: 0x40

		public UnderwaterColor() { }

	}

	internal class UnderwaterDepth
	{
		public Vector3 Attenuation; //Field offset: 0x10
		[Range(0, 4)]
		public float Distance; //Field offset: 0x1C
		[Range(0, 4)]
		public float Density; //Field offset: 0x20
		[Range(1.1, 1.4)]
		public float WaterIOR; //Field offset: 0x24
		[Range(0.001, 6)]
		public float InvFade; //Field offset: 0x28
		public float MaxFogLightDepth; //Field offset: 0x2C
		public float MaxDirLightDepth; //Field offset: 0x30
		[Range(0, 1)]
		public float NormalInfluenceXZ; //Field offset: 0x34
		[Range(0, 1)]
		public float NormalInfluenceY; //Field offset: 0x38

		public UnderwaterDepth() { }

	}

	internal class UnderwaterRefraction
	{
		public float Intensity; //Field offset: 0x10
		public float Scale; //Field offset: 0x14
		public float Speed; //Field offset: 0x18

		public UnderwaterRefraction() { }

	}

	internal class UnderwaterScattering
	{
		public Color TranslucencyColor; //Field offset: 0x10
		[Range(0.1, 16)]
		public float Power; //Field offset: 0x20
		[Range(0.01, 0.5)]
		public float NormalInfluence; //Field offset: 0x24
		[Range(0.001, 1)]
		public float Occlusion; //Field offset: 0x28
		[Range(0, 2)]
		public float Intensity; //Field offset: 0x2C

		public UnderwaterScattering() { }

	}

	private static Material _waterSurfaceMaterial; //Field offset: 0x0
	private static Material _waterMaskMaterial; //Field offset: 0x8
	private static Material _underwaterMaterial; //Field offset: 0x10
	private static Material _blurMaterial; //Field offset: 0x18
	private static Shader _waterSurfaceShader; //Field offset: 0x20
	private static Shader _waterMaskShader; //Field offset: 0x28
	private static Shader _underwaterShader; //Field offset: 0x30
	private static Shader _blurShader; //Field offset: 0x38
	[SerializeField]
	private ERenderResolution _renderResolution; //Field offset: 0x10
	[SerializeField]
	private bool _enableUnderwater; //Field offset: 0x14
	[SerializeField]
	private float _waterLevel; //Field offset: 0x18
	[Range(2, 8)]
	[SerializeField]
	private int _blurIteration; //Field offset: 0x1C
	[SerializeField]
	[Space]
	private DynamicWaterFoam _dynamicWaterFoam; //Field offset: 0x20
	[SerializeField]
	private UnderwaterColor _underwaterColor; //Field offset: 0x28
	[SerializeField]
	private UnderwaterDepth _underwaterDepth; //Field offset: 0x30
	[SerializeField]
	private UnderwaterScattering _underwaterScattering; //Field offset: 0x38
	[SerializeField]
	private UnderwaterAbsorption _underwaterAbsorption; //Field offset: 0x40
	[SerializeField]
	private UnderwaterRefraction _underwaterRefraction; //Field offset: 0x48

	public int BlurIteration
	{
		 get { } //Length: 4
	}

	public Material BlurMaterial
	{
		 get { } //Length: 823
	}

	public bool EnableUnderwater
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public DynamicWaterFoam GetDynamicWaterFoam
	{
		 get { } //Length: 5
	}

	public UnderwaterAbsorption GetUnderwaterAbsorption
	{
		 get { } //Length: 5
	}

	public UnderwaterColor GetUnderwaterColor
	{
		 get { } //Length: 5
	}

	public UnderwaterDepth GetUnderwaterDepth
	{
		 get { } //Length: 76
	}

	public UnderwaterRefraction GetUnderwaterRefraction
	{
		 get { } //Length: 5
	}

	public UnderwaterScattering GetUnderwaterScattering
	{
		 get { } //Length: 5
	}

	public ERenderResolution RenderResolution
	{
		 get { } //Length: 164
	}

	public Material UnderwaterMaterial
	{
		 get { } //Length: 823
	}

	public float WaterLevel
	{
		 get { } //Length: 6
	}

	public Material WaterMaskMaterial
	{
		 get { } //Length: 823
	}

	public Material WaterSurfaceMaterial
	{
		 get { } //Length: 822
	}

	public WaterProperties() { }

	public void Dispose() { }

	public int get_BlurIteration() { }

	public Material get_BlurMaterial() { }

	public bool get_EnableUnderwater() { }

	public DynamicWaterFoam get_GetDynamicWaterFoam() { }

	public UnderwaterAbsorption get_GetUnderwaterAbsorption() { }

	public UnderwaterColor get_GetUnderwaterColor() { }

	public UnderwaterDepth get_GetUnderwaterDepth() { }

	public UnderwaterRefraction get_GetUnderwaterRefraction() { }

	public UnderwaterScattering get_GetUnderwaterScattering() { }

	public ERenderResolution get_RenderResolution() { }

	public Material get_UnderwaterMaterial() { }

	public float get_WaterLevel() { }

	public Material get_WaterMaskMaterial() { }

	public Material get_WaterSurfaceMaterial() { }

	public void set_EnableUnderwater(bool value) { }

}

