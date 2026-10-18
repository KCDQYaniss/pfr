namespace JBooth.MicroSplat;

[DisallowMultipleComponent]
[ExecuteInEditMode]
public class MicroSplatTerrain : MicroSplatObject
{
	internal sealed class MaterialSync : MulticastDelegate
	{

		public MaterialSync(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Material m, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Material m) { }

	}

	internal sealed class MaterialSyncAll : MulticastDelegate
	{

		public MaterialSyncAll(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private static readonly int _customControl0; //Field offset: 0x0
	private static readonly int _customControl1; //Field offset: 0x4
	private static readonly int _customControl2; //Field offset: 0x8
	private static readonly int _customControl3; //Field offset: 0xC
	private static readonly int _customControl4; //Field offset: 0x10
	private static readonly int _customControl5; //Field offset: 0x14
	private static readonly int _customControl6; //Field offset: 0x18
	private static readonly int _customControl7; //Field offset: 0x1C
	private static readonly int _diffuse; //Field offset: 0x20
	private static readonly int _uvScale; //Field offset: 0x24
	private static readonly int _detailNoiseScaleStrengthFade; //Field offset: 0x28
	private static readonly int _pomParams; //Field offset: 0x2C
	private static readonly int _parallaxParams; //Field offset: 0x30
	private static readonly int _tessData2; //Field offset: 0x34
	private static readonly int _perPixelNormal; //Field offset: 0x38
	[CompilerGenerated]
	private static MaterialSyncAll OnMaterialSyncAll; //Field offset: 0x40
	private static List sInstances; //Field offset: 0x48
	[CompilerGenerated]
	private MaterialSync OnMaterialSync; //Field offset: 0x70
	public Terrain terrain; //Field offset: 0x78
	public Shader baseMapShader; //Field offset: 0x80
	[HideInInspector]
	public Texture2D customControl0; //Field offset: 0x88
	[HideInInspector]
	public Texture2D customControl1; //Field offset: 0x90
	[HideInInspector]
	public Texture2D customControl2; //Field offset: 0x98
	[HideInInspector]
	public Texture2D customControl3; //Field offset: 0xA0
	[HideInInspector]
	public Texture2D customControl4; //Field offset: 0xA8
	[HideInInspector]
	public Texture2D customControl5; //Field offset: 0xB0
	[HideInInspector]
	public Texture2D customControl6; //Field offset: 0xB8
	[HideInInspector]
	public Texture2D customControl7; //Field offset: 0xC0
	public Vector3 patchBoundsMultiplier; //Field offset: 0xC8
	[HideInInspector]
	public bool reenabled; //Field offset: 0xD4

	public event MaterialSync OnMaterialSync
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public static event MaterialSyncAll OnMaterialSyncAll
	{
		[CompilerGenerated]
		 add { } //Length: 335
		[CompilerGenerated]
		 remove { } //Length: 335
	}

	private static MicroSplatTerrain() { }

	public MicroSplatTerrain() { }

	[CompilerGenerated]
	public void add_OnMaterialSync(MaterialSync value) { }

	[CompilerGenerated]
	public static void add_OnMaterialSyncAll(MaterialSyncAll value) { }

	private void Apply(Material material, MicroSplatKeywords keywords, MicroSplatPropData props) { }

	public void ApplySeasonMaterial() { }

	private void Awake() { }

	private void Cleanup() { }

	public virtual Bounds GetBounds() { }

	public virtual TerrainDescriptor GetTerrainDescriptor() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_OnMaterialSync(MaterialSync value) { }

	[CompilerGenerated]
	public static void remove_OnMaterialSyncAll(MaterialSyncAll value) { }

	private void Start() { }

	public void Sync() { }

	public static void SyncAll() { }

	public void UnloadUnusedSeasonMaterials() { }

}

