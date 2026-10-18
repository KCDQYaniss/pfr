namespace EFT.Game.Spawning;

[ExecuteInEditMode]
public sealed class SpawnPointMarker : MonoBehaviour, ISpawnPointCollider, IPositionPoint
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <TryCreate>b__25_0(SpawnPointMarker marker) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public SpawnPointParams params; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <Create>b__0(BotZone x) { }

	}

	[SerializeField]
	private SpawnPoint _spawnPoint; //Field offset: 0x20
	[SerializeField]
	private Collider _collider; //Field offset: 0x28
	private string _debugInfo; //Field offset: 0x30
	public Color Color; //Field offset: 0x38

	public BotZone BotZone
	{
		 get { } //Length: 27
		 set { } //Length: 107
	}

	public int CorePointId
	{
		 get { } //Length: 26
	}

	public string Id
	{
		 get { } //Length: 27
		 set { } //Length: 107
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public EPlayerSideMask Sides
	{
		 get { } //Length: 26
		 set { } //Length: 26
	}

	public ISpawnPoint SpawnPoint
	{
		 get { } //Length: 5
	}

	public SpawnPointMarker() { }

	[CompilerGenerated]
	internal static void <FixParams>g__LogFix|23_0(string message) { }

	public static SpawnPointMarker Create(SpawnPointParams params, GameObject go) { }

	public static SpawnPointMarker Create(SpawnPointParams params, Transform parent = null) { }

	private string CreateDebugInfo() { }

	public SpawnPointParams CreateSpawnPointParams() { }

	public override string DebugInfo() { }

	private void DrawCollider() { }

	private void DrawTall() { }

	private override bool EFT.Game.Spawning.ISpawnPointCollider.Contains(Vector3 point) { }

	public bool FixCollider(ISpawnColliderParams params) { }

	public bool FixParams(in SpawnPointParams params, AbstractLogger logger) { }

	public BotZone get_BotZone() { }

	public int get_CorePointId() { }

	public string get_Id() { }

	public override Vector3 get_Position() { }

	public EPlayerSideMask get_Sides() { }

	public ISpawnPoint get_SpawnPoint() { }

	public void OnDrawGizmos() { }

	public void OnDrawGizmosSelected() { }

	public void set_BotZone(BotZone value) { }

	public void set_Id(string value) { }

	public void set_Sides(EPlayerSideMask value) { }

	public void Start() { }

	public static void TryCreate(SpawnPointParams[] parameters, Transform parent = null) { }

}

