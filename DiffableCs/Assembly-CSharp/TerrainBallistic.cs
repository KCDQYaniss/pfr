//Type is in global namespace

public class TerrainBallistic : BaseBallistic
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public ESurfaceSound terrainMaterial; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <Awake>b__0(BallisticCollider c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public TerrainBallistic <>4__this; //Field offset: 0x10
		public int i; //Field offset: 0x18
		public Func <>9__0; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal bool <OnValidate>b__0(BallisticCollider c) { }

	}

	private static GameObject _staticColliders; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly MaterialType[] <MaterialTypes>k__BackingField; //Field offset: 0x8
	public TerrainData TerrainData; //Field offset: 0x28
	public TextAsset TextureMixDataAsset; //Field offset: 0x30
	private int _terrains; //Field offset: 0x38
	private Vector3 _worldPosition; //Field offset: 0x3C
	private BallisticCollider[] _colliders; //Field offset: 0x48
	private TerrainTextureMixData _mixData; //Field offset: 0x50
	public ESurfaceSound[] TerrainMaterials; //Field offset: 0x58

	private static MaterialType[] MaterialTypes
	{
		[CompilerGenerated]
		private get { } //Length: 84
	}

	private static TerrainBallistic() { }

	public TerrainBallistic() { }

	[CompilerGenerated]
	private bool <Get>b__15_0(BallisticCollider b) { }

	public static void ApplyPresetValues(BallisticCollider bCollider) { }

	private void Awake() { }

	public virtual BallisticCollider Get(Vector3 pos) { }

	[CompilerGenerated]
	private static MaterialType[] get_MaterialTypes() { }

	private int GetMainTexture(Vector3 worldPos) { }

	public virtual ESurfaceSound GetSurfaceSound(Vector3 pos) { }

	public static bool IsNoneDefault(BallisticCollider bCollider) { }

	private void OnDestroy() { }

	private void OnValidate() { }

}

