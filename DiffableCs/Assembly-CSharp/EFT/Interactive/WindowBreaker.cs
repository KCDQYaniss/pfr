namespace EFT.Interactive;

[ExecuteInEditMode]
[ScriptOrder(22001)]
public sealed class WindowBreaker : MonoBehaviour, IMapEditable, IBreakable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__91_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateMesh>b__91_0(Piece x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public WindowBreaker <>4__this; //Field offset: 0x10
		public int id; //Field offset: 0x18
		public BrokenWindowPiece piece; //Field offset: 0x20

		public <>c__DisplayClass88_0() { }

		internal void <UpdateToStuck>b__0(DamageInfo info) { }

		internal void <UpdateToStuck>b__1(Vector3 p, Vector3 d) { }

	}

	[CompilerGenerated]
	private struct <PieceDestroyTask>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Piece stuckPiece; //Field offset: 0x20
		public WindowBreaker <>4__this; //Field offset: 0x28
		public Vector3 position; //Field offset: 0x30
		public Vector3 force; //Field offset: 0x3C
		public float destroyTime; //Field offset: 0x48
		private Transform <stuckTransform>5__2; //Field offset: 0x50
		private Vector3 <randomRotation>5__3; //Field offset: 0x58
		private Vector3 <basePosition>5__4; //Field offset: 0x64
		private float <time>5__5; //Field offset: 0x70
		private YieldAwaiter <>u__1; //Field offset: 0x74

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class Piece
	{
		public string Id; //Field offset: 0x10
		public BrokenWindowPiece Description; //Field offset: 0x18
		public Vector2 Center; //Field offset: 0x60
		public MeshPiece MeshPiece; //Field offset: 0x68
		public bool Stuck; //Field offset: 0x70
		public bool Edge; //Field offset: 0x71
		public float Mass; //Field offset: 0x74

		public Piece() { }

	}

	internal enum RotationAngle
	{
		Random = 0,
		Square90 = 1,
		HorizontalRectangle180 = 2,
		VerticalRectangle180 = 3,
	}

	[CompilerGenerated]
	private static Action OnWindowHitAction; //Field offset: 0x0
	private const float GRAVACC = 9.81; //Field offset: 0x0
	private const string WINDOW_GAG_KEY = "window"; //Field offset: 0x0
	private static readonly List PiecesList; //Field offset: 0x8
	private static readonly float[] SwapArray; //Field offset: 0x10
	public string Id; //Field offset: 0x20
	public bool BrakeByDefault; //Field offset: 0x28
	public Collider ObstructiveCollider; //Field offset: 0x30
	public BallisticCollider GlassBallisticCollider; //Field offset: 0x38
	private MeshCollider _collider; //Field offset: 0x40
	[CompilerGenerated]
	private Nullable <FirstHitPosition>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnBroken; //Field offset: 0x58
	private int _cachedSeed; //Field offset: 0x60
	private Bounds _intactBoundsSnapshot; //Field offset: 0x64
	public WindowBreakingConfig BrokenWindow; //Field offset: 0x80
	public Material Material; //Field offset: 0x88
	public Renderer Renderer; //Field offset: 0x90
	[FormerlySerializedAs("RotationAngle")]
	[Header("Window")]
	public RotationAngle AngleMode; //Field offset: 0x98
	public float MinThickness; //Field offset: 0x9C
	public float ThicknessMultyplier; //Field offset: 0xA0
	public float EdgesWidth; //Field offset: 0xA4
	public float CracksScale; //Field offset: 0xA8
	[Header("Part")]
	public float MassMultyplier; //Field offset: 0xAC
	public float AirDrag; //Field offset: 0xB0
	public float TimeUntilPartDie; //Field offset: 0xB4
	[Header("Shots")]
	public float FirstShotRadius; //Field offset: 0xB8
	public float ShotRadius; //Field offset: 0xBC
	public float FirstShotSoundVolume; //Field offset: 0xC0
	public Vector2 TorqueRandomMinMaxCoefs; //Field offset: 0xC4
	public float InstantExplosionCoef; //Field offset: 0xCC
	public float ShotDirectionCoef; //Field offset: 0xD0
	[HideInInspector]
	[SerializeField]
	[Space(32)]
	private int AxisX; //Field offset: 0xD4
	[HideInInspector]
	[SerializeField]
	[Space(32)]
	private int AxisY; //Field offset: 0xD8
	[HideInInspector]
	[SerializeField]
	[Space(32)]
	private int AxisZ; //Field offset: 0xDC
	[HideInInspector]
	[SerializeField]
	private Vector2 UvMult; //Field offset: 0xE0
	[HideInInspector]
	[SerializeField]
	private Vector2 UvAdd; //Field offset: 0xE8
	[HideInInspector]
	[SerializeField]
	private Vector2 ZSurfs; //Field offset: 0xF0
	[HideInInspector]
	[SerializeField]
	private Vector4 Box; //Field offset: 0xF8
	[HideInInspector]
	[SerializeField]
	private Quaternion Rotation; //Field offset: 0x108
	[HideInInspector]
	[SerializeField]
	private bool NeedToSwap; //Field offset: 0x118
	private int _localUniquePieceCounter; //Field offset: 0x11C
	private float _silent; //Field offset: 0x120
	private Piece[] _pieces; //Field offset: 0x128
	private MeshFilter _stuckMeshFilter; //Field offset: 0x130
	private Vector2 _add; //Field offset: 0x138
	private Vector2 _gagRadius; //Field offset: 0x140
	private Mesh _mesh; //Field offset: 0x148

	public event Action OnBroken
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public static event Action OnWindowHitAction
	{
		[CompilerGenerated]
		 add { } //Length: 347
		[CompilerGenerated]
		 remove { } //Length: 347
	}

	public bool AvailableToSync
	{
		 get { } //Length: 81
	}

	private override GameObject EFT.Interactive.IMapEditable.GameObject
	{
		private get { } //Length: 78
	}

	private override string EFT.Interactive.IMapEditable.IdEditable
	{
		private get { } //Length: 5
		private set { } //Length: 82
	}

	public private Nullable FirstHitPosition
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private bool HasPieces
	{
		private get { } //Length: 28
	}

	public bool IsDamaged
	{
		 get { } //Length: 51
	}

	public int NetId
	{
		 get { } //Length: 71
	}

	private int Seed
	{
		private get { } //Length: 130
	}

	public override string TypeKey
	{
		 get { } //Length: 49
	}

	private static WindowBreaker() { }

	public WindowBreaker() { }

	[CompilerGenerated]
	public void add_OnBroken(Action value) { }

	[CompilerGenerated]
	public static void add_OnWindowHitAction(Action value) { }

	private void AnalyzeDependencies() { }

	private void AnalyzeMesh() { }

	private void Awake() { }

	private void AwakeClient() { }

	private void BlowUp(in Vector3 force, int piecesToDestroy) { }

	private void Break(Crack crack, in Vector3 position, in Vector3 force, float angle, bool isStatic = false, bool instantFall = false) { }

	private void BreakByHit(in DamageInfo info, bool instantFall) { }

	private void BreakStatic() { }

	private void CleanPieces() { }

	private static Mesh CombineStuckPieces(Piece[] pieces, Vector2 add, int axisX, int axisY, int axisZ, Vector2 zSurfs) { }

	private static void DestroyPiece(Piece piece) { }

	private override GameObject EFT.Interactive.IMapEditable.get_GameObject() { }

	private override string EFT.Interactive.IMapEditable.get_IdEditable() { }

	private override void EFT.Interactive.IMapEditable.set_IdEditable(string value) { }

	private override void EFT.Interactive.WindowBreakerManager.IBreakable.Break(Crack crack, in Vector3 position, in Vector3 force, float angle) { }

	private void FillDependencies() { }

	public bool get_AvailableToSync() { }

	[CompilerGenerated]
	public Nullable get_FirstHitPosition() { }

	private bool get_HasPieces() { }

	public bool get_IsDamaged() { }

	public int get_NetId() { }

	private int get_Seed() { }

	public override string get_TypeKey() { }

	private float GetAngle() { }

	private Crack GetCrack() { }

	public Bounds GetIntactBounds() { }

	private Piece[] GetPieces(Crack crack, Vector2 add, Vector2 shift, float angle, float scale) { }

	private BrokenWindowPiece GetStuckPieceDescription(Piece piece, Vector2 add) { }

	private static Vector3 GetVectorBySeed(int seed, float min, float max) { }

	private bool IsBrokenByExplosion(IExplosiveItem item, float distance) { }

	public void MakeHit(in DamageInfo hitInfo, bool instantFall = false) { }

	private static bool NeedToSwapCalc(Vector2 v0, Vector2 v1, Vector2 uv0, Vector2 uv1) { }

	private void OnPieceHit(in DamageInfo info, int id) { }

	private void OnPieceHitByPlayer(Vector3 hitpoint, Vector3 direction, int id) { }

	private void OnValidate() { }

	private void OnWindowHit(DamageInfo hitInfo) { }

	[AsyncStateMachine(typeof(<PieceDestroyTask>d__90))]
	private Task PieceDestroyTask(Piece stuckPiece, float destroyTime, Vector3 position, Vector3 force) { }

	private void PlayHitSound(in Vector3 hitPoint) { }

	private void PlayPieceSound(in Vector3 hitPoint) { }

	[CompilerGenerated]
	public void remove_OnBroken(Action value) { }

	[CompilerGenerated]
	public static void remove_OnWindowHitAction(Action value) { }

	[CompilerGenerated]
	private void set_FirstHitPosition(Nullable value) { }

	public void TryToBlowUp(IExplosiveItem grenadeItem, in Vector3 grenadePosition) { }

	private void UnsubscribeCollider() { }

	private void UpdateMesh() { }

	private void UpdateToFalling(Piece piece, bool wasStuck, in Vector3 position, in Vector3 force, bool instantFall = false) { }

	private void UpdateToStuck(BrokenWindowPiece piece, int id) { }

}

