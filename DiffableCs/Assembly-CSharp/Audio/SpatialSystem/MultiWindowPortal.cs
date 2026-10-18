namespace Audio.SpatialSystem;

[RequireComponent(typeof(BoxCollider))]
public class MultiWindowPortal : BaseSpatialAudioPortal, IIdentifiable
{
	[CompilerGenerated]
	private struct <Init>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MultiWindowPortal <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class WindowData
	{
		public string windowID; //Field offset: 0x10
		public float occupiedRatio; //Field offset: 0x18
		public float traversalCost; //Field offset: 0x1C
		public Vector2 size; //Field offset: 0x20
		public float area; //Field offset: 0x28
		public float depth; //Field offset: 0x2C
		[HideInInspector]
		public Vector3 colliderCenter; //Field offset: 0x30
		[HideInInspector]
		public Quaternion colliderRotation; //Field offset: 0x3C

		public WindowData() { }

	}

	[SerializeField]
	private List _serializedWindowsData; //Field offset: 0x88
	[SerializeField]
	private float _totalOccupiedArea; //Field offset: 0x90
	[SerializeField]
	private float _totalOccupiedRatio; //Field offset: 0x94
	[SerializeField]
	private float _freeAreaTraversalCost; //Field offset: 0x98
	[SerializeField]
	private float _totalTraversalMaxCost; //Field offset: 0x9C
	[SerializeField]
	private float _totalDepth; //Field offset: 0xA0
	[SerializeField]
	private float _freeAreaDepth; //Field offset: 0xA4
	[SerializeField]
	private Vector2 _freeAreaSize; //Field offset: 0xA8
	[SerializeField]
	private float _freeArea; //Field offset: 0xB0
	[SerializeField]
	private float _totalArea; //Field offset: 0xB4
	[SerializeField]
	private Vector2 _totalAreaSize; //Field offset: 0xB8
	private Dictionary _windowsMap; //Field offset: 0xC0

	public override IReadOnlyCollection Ids
	{
		 get { } //Length: 76
	}

	public MultiWindowPortal() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	public override IReadOnlyCollection get_Ids() { }

	[AsyncStateMachine(typeof(<Init>d__17))]
	protected virtual Task Init() { }

	private void OnWindowHit(WindowBreaker breaker, DamageInfo info, Crack crack, float damage) { }

	private void RiseChangedEventOnHit() { }

	protected virtual void Subscribe() { }

	protected virtual void SyncState() { }

	protected virtual void Unsubscribe() { }

	private void UpdateDepthOnWindowHit(WindowData data) { }

	private void UpdateFreeAreaSizeOnHit(WindowData data) { }

	private void UpdateTraversalCostOnWindowHit(WindowData data) { }

}

