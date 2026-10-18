//Type is in global namespace

[DisallowMultipleComponent]
[ExecuteInEditMode]
public class MicroSplatMeshTerrain : MicroSplatObject
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

	[CompilerGenerated]
	private static MaterialSyncAll OnMaterialSyncAll; //Field offset: 0x0
	private static List sInstances; //Field offset: 0x8
	[CompilerGenerated]
	private MaterialSync OnMaterialSync; //Field offset: 0x70
	public MeshRenderer[] meshTerrains; //Field offset: 0x78
	public Texture2D[] controlTextures; //Field offset: 0x80
	[HideInInspector]
	public Material meshBlendMat; //Field offset: 0x88
	[HideInInspector]
	public Material meshBlendMatInstance; //Field offset: 0x90
	public TerrainDescriptor terrainDescriptor; //Field offset: 0x98

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

	private static MicroSplatMeshTerrain() { }

	public MicroSplatMeshTerrain() { }

	[CompilerGenerated]
	public void add_OnMaterialSync(MaterialSync value) { }

	[CompilerGenerated]
	public static void add_OnMaterialSyncAll(MaterialSyncAll value) { }

	private void ApplyMeshBlendMap() { }

	private void Cleanup() { }

	public virtual Bounds GetBounds() { }

	private Material GetMeshBlendMatInstance() { }

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

	private void SyncMeshBlendMat() { }

}

