namespace EFT.Interactive;

[ScriptOrder(22000)]
public sealed class WindowBreakerManager : MonoBehaviour
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OnWindowHit; //Field offset: 0x0

	}

	private struct BrokenWindowDescription
	{
		public IBreakable Breakable; //Field offset: 0x0
		public Crack Crack; //Field offset: 0x8
		public Vector3 Position; //Field offset: 0x10
		public Vector3 Force; //Field offset: 0x1C
		public float Angle; //Field offset: 0x28

	}

	internal interface IBreakable
	{

		public void Break(Crack crack, in Vector3 position, in Vector3 force, float angle) { }

	}

	private const int STUCKPIECEQUANTITY = 5000; //Field offset: 0x0
	[CompilerGenerated]
	private static WindowBreakerManager <Instance>k__BackingField; //Field offset: 0x0
	private static readonly Queue _brokenWindowDescriptions; //Field offset: 0x8
	[SerializeField]
	private BrokenWindowPieceTemplate _stuckPiecePrefab; //Field offset: 0x20
	private Queue _pieces; //Field offset: 0x28

	public private static WindowBreakerManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 167
	}

	private static WindowBreakerManager() { }

	public WindowBreakerManager() { }

	private void Awake() { }

	public static BrokenWindowPiece CreateBrokenWindowPiece() { }

	private BrokenWindowPiece CreatePieceByTemplate() { }

	private void GenerateStuckPieces() { }

	[CompilerGenerated]
	public static WindowBreakerManager get_Instance() { }

	public BrokenWindowPiece GetBrokenWindowPiece() { }

	private void OnDestroy() { }

	private static void OnWindowHit(WindowBreaker windowBreaker, DamageInfo info, Crack brokenWindowCrack, float angle) { }

	public void ReturnToPool(BrokenWindowPiece piece) { }

	[CompilerGenerated]
	private static void set_Instance(WindowBreakerManager value) { }

	private void Update() { }

}

