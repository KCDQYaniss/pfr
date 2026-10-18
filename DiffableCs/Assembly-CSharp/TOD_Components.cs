//Type is in global namespace

[ExecuteInEditMode]
public class TOD_Components : MonoBehaviour
{
	public GameObject Sun; //Field offset: 0x20
	public GameObject Moon; //Field offset: 0x28
	public GameObject Atmosphere; //Field offset: 0x30
	public GameObject Clear; //Field offset: 0x38
	public GameObject Space; //Field offset: 0x40
	public GameObject Light; //Field offset: 0x48
	[CompilerGenerated]
	private Transform <DomeTransform>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Transform <SunTransform>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Transform <MoonTransform>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Transform <LightTransform>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Transform <SpaceTransform>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Renderer <SpaceRenderer>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Renderer <AtmosphereRenderer>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Renderer <ClearRenderer>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Renderer <CloudRenderer>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private Renderer <SunRenderer>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private Renderer <MoonRenderer>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private MeshFilter <SpaceMeshFilter>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private MeshFilter <AtmosphereMeshFilter>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private MeshFilter <ClearMeshFilter>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private MeshFilter <CloudMeshFilter>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private MeshFilter <SunMeshFilter>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private MeshFilter <MoonMeshFilter>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private Material <SpaceMaterial>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private Material <AtmosphereMaterial>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private Material <ClearMaterial>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private Material <CloudMaterial>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private Material <SunMaterial>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Material <MoonMaterial>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private Light <LightSource>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private TOD_Sky <Sky>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private TOD_Time <Time>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private TOD_Camera <Camera>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private TOD_Rays <Rays>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private TOD_Scattering <Scattering>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private MBOIT_Scattering <MBOITScattering>k__BackingField; //Field offset: 0x138

	public Material AtmosphereMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MeshFilter AtmosphereMeshFilter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Renderer AtmosphereRenderer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TOD_Camera Camera
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Material ClearMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MeshFilter ClearMeshFilter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Renderer ClearRenderer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Material CloudMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MeshFilter CloudMeshFilter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Renderer CloudRenderer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Transform DomeTransform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Light LightSource
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Transform LightTransform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MBOIT_Scattering MBOITScattering
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Material MoonMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MeshFilter MoonMeshFilter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Renderer MoonRenderer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Transform MoonTransform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TOD_Rays Rays
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TOD_Scattering Scattering
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TOD_Sky Sky
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Material SpaceMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MeshFilter SpaceMeshFilter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Renderer SpaceRenderer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Transform SpaceTransform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Material SunMaterial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MeshFilter SunMeshFilter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Renderer SunRenderer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Transform SunTransform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TOD_Time Time
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TOD_Components() { }

	[CompilerGenerated]
	public Material get_AtmosphereMaterial() { }

	[CompilerGenerated]
	public MeshFilter get_AtmosphereMeshFilter() { }

	[CompilerGenerated]
	public Renderer get_AtmosphereRenderer() { }

	[CompilerGenerated]
	public TOD_Camera get_Camera() { }

	[CompilerGenerated]
	public Material get_ClearMaterial() { }

	[CompilerGenerated]
	public MeshFilter get_ClearMeshFilter() { }

	[CompilerGenerated]
	public Renderer get_ClearRenderer() { }

	[CompilerGenerated]
	public Material get_CloudMaterial() { }

	[CompilerGenerated]
	public MeshFilter get_CloudMeshFilter() { }

	[CompilerGenerated]
	public Renderer get_CloudRenderer() { }

	[CompilerGenerated]
	public Transform get_DomeTransform() { }

	[CompilerGenerated]
	public Light get_LightSource() { }

	[CompilerGenerated]
	public Transform get_LightTransform() { }

	[CompilerGenerated]
	public MBOIT_Scattering get_MBOITScattering() { }

	[CompilerGenerated]
	public Material get_MoonMaterial() { }

	[CompilerGenerated]
	public MeshFilter get_MoonMeshFilter() { }

	[CompilerGenerated]
	public Renderer get_MoonRenderer() { }

	[CompilerGenerated]
	public Transform get_MoonTransform() { }

	[CompilerGenerated]
	public TOD_Rays get_Rays() { }

	[CompilerGenerated]
	public TOD_Scattering get_Scattering() { }

	[CompilerGenerated]
	public TOD_Sky get_Sky() { }

	[CompilerGenerated]
	public Material get_SpaceMaterial() { }

	[CompilerGenerated]
	public MeshFilter get_SpaceMeshFilter() { }

	[CompilerGenerated]
	public Renderer get_SpaceRenderer() { }

	[CompilerGenerated]
	public Transform get_SpaceTransform() { }

	[CompilerGenerated]
	public Material get_SunMaterial() { }

	[CompilerGenerated]
	public MeshFilter get_SunMeshFilter() { }

	[CompilerGenerated]
	public Renderer get_SunRenderer() { }

	[CompilerGenerated]
	public Transform get_SunTransform() { }

	[CompilerGenerated]
	public TOD_Time get_Time() { }

	public void Initialize() { }

	[CompilerGenerated]
	public void set_AtmosphereMaterial(Material value) { }

	[CompilerGenerated]
	public void set_AtmosphereMeshFilter(MeshFilter value) { }

	[CompilerGenerated]
	public void set_AtmosphereRenderer(Renderer value) { }

	[CompilerGenerated]
	public void set_Camera(TOD_Camera value) { }

	[CompilerGenerated]
	public void set_ClearMaterial(Material value) { }

	[CompilerGenerated]
	public void set_ClearMeshFilter(MeshFilter value) { }

	[CompilerGenerated]
	public void set_ClearRenderer(Renderer value) { }

	[CompilerGenerated]
	public void set_CloudMaterial(Material value) { }

	[CompilerGenerated]
	public void set_CloudMeshFilter(MeshFilter value) { }

	[CompilerGenerated]
	public void set_CloudRenderer(Renderer value) { }

	[CompilerGenerated]
	public void set_DomeTransform(Transform value) { }

	[CompilerGenerated]
	public void set_LightSource(Light value) { }

	[CompilerGenerated]
	public void set_LightTransform(Transform value) { }

	[CompilerGenerated]
	public void set_MBOITScattering(MBOIT_Scattering value) { }

	[CompilerGenerated]
	public void set_MoonMaterial(Material value) { }

	[CompilerGenerated]
	public void set_MoonMeshFilter(MeshFilter value) { }

	[CompilerGenerated]
	public void set_MoonRenderer(Renderer value) { }

	[CompilerGenerated]
	public void set_MoonTransform(Transform value) { }

	[CompilerGenerated]
	public void set_Rays(TOD_Rays value) { }

	[CompilerGenerated]
	public void set_Scattering(TOD_Scattering value) { }

	[CompilerGenerated]
	public void set_Sky(TOD_Sky value) { }

	[CompilerGenerated]
	public void set_SpaceMaterial(Material value) { }

	[CompilerGenerated]
	public void set_SpaceMeshFilter(MeshFilter value) { }

	[CompilerGenerated]
	public void set_SpaceRenderer(Renderer value) { }

	[CompilerGenerated]
	public void set_SpaceTransform(Transform value) { }

	[CompilerGenerated]
	public void set_SunMaterial(Material value) { }

	[CompilerGenerated]
	public void set_SunMeshFilter(MeshFilter value) { }

	[CompilerGenerated]
	public void set_SunRenderer(Renderer value) { }

	[CompilerGenerated]
	public void set_SunTransform(Transform value) { }

	[CompilerGenerated]
	public void set_Time(TOD_Time value) { }

}

