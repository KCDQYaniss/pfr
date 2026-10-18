namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[UsedByNativeCode]
public sealed class DetailPrototype
{
	internal static readonly Color DefaultHealthColor; //Field offset: 0x0
	internal static readonly Color DefaultDryColor; //Field offset: 0x10
	internal GameObject m_Prototype; //Field offset: 0x10
	internal Texture2D m_PrototypeTexture; //Field offset: 0x18
	internal Color m_HealthyColor; //Field offset: 0x20
	internal Color m_DryColor; //Field offset: 0x30
	internal float m_MinWidth; //Field offset: 0x40
	internal float m_MaxWidth; //Field offset: 0x44
	internal float m_MinHeight; //Field offset: 0x48
	internal float m_MaxHeight; //Field offset: 0x4C
	internal int m_NoiseSeed; //Field offset: 0x50
	internal float m_NoiseSpread; //Field offset: 0x54
	internal float m_Density; //Field offset: 0x58
	internal float m_HoleEdgePadding; //Field offset: 0x5C
	internal int m_RenderMode; //Field offset: 0x60
	internal int m_UsePrototypeMesh; //Field offset: 0x64
	internal int m_UseInstancing; //Field offset: 0x68
	internal int m_UseDensityScaling; //Field offset: 0x6C
	internal float m_AlignToGround; //Field offset: 0x70
	internal float m_PositionJitter; //Field offset: 0x74
	internal float m_TargetCoverage; //Field offset: 0x78

	public Color dryColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color healthyColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float maxHeight
	{
		 get { } //Length: 8
	}

	public float maxWidth
	{
		 get { } //Length: 8
	}

	public float minHeight
	{
		 get { } //Length: 8
	}

	public float minWidth
	{
		 get { } //Length: 8
	}

	public float noiseSpread
	{
		 get { } //Length: 8
	}

	public GameObject prototype
	{
		 get { } //Length: 7
	}

	public Texture2D prototypeTexture
	{
		 get { } //Length: 7
		 set { } //Length: 82
	}

	public DetailRenderMode renderMode
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public bool usePrototypeMesh
	{
		 get { } //Length: 10
	}

	private static DetailPrototype() { }

	public DetailPrototype() { }

	public virtual bool Equals(object obj) { }

	private bool Equals(DetailPrototype other) { }

	public Color get_dryColor() { }

	public Color get_healthyColor() { }

	public float get_maxHeight() { }

	public float get_maxWidth() { }

	public float get_minHeight() { }

	public float get_minWidth() { }

	public float get_noiseSpread() { }

	public GameObject get_prototype() { }

	public Texture2D get_prototypeTexture() { }

	public DetailRenderMode get_renderMode() { }

	public bool get_usePrototypeMesh() { }

	public virtual int GetHashCode() { }

	public void set_dryColor(Color value) { }

	public void set_healthyColor(Color value) { }

	public void set_prototypeTexture(Texture2D value) { }

	public void set_renderMode(DetailRenderMode value) { }

}

