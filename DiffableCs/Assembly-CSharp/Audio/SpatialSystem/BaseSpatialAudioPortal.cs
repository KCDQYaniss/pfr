namespace Audio.SpatialSystem;

public abstract class BaseSpatialAudioPortal : MonoBehaviour, ISpatialPortal
{
	[CompilerGenerated]
	private sealed class <ClosePortal>d__50 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public BaseSpatialAudioPortal <>4__this; //Field offset: 0x28
		public float start; //Field offset: 0x30
		private float <fadeTimePassed>5__2; //Field offset: 0x34

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ClosePortal>d__50(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <OpenPortal>d__49 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float duration; //Field offset: 0x20
		public BaseSpatialAudioPortal <>4__this; //Field offset: 0x28
		public float start; //Field offset: 0x30
		private float <fadeTimePassed>5__2; //Field offset: 0x34

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <OpenPortal>d__49(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum PortalState
	{
		Open = 0,
		Closed = 1,
		InProgressOpen = 2,
		InProgressClose = 3,
	}

	internal enum PortalType
	{
		Opening = 0,
		Static = 1,
		Window = 2,
	}

	private const byte CONNECTED_ROOMS_COUNT = 2; //Field offset: 0x0
	private const float MAX_ALLOWED_POSITION_OFFSET = 15; //Field offset: 0x0
	[Range(0, 1)]
	[SerializeField]
	[Tooltip("The level of portal transmission, 1 - full transmission like open portal, 0 - min transmission, like wall")]
	private float _transmission; //Field offset: 0x20
	[Tooltip("Represent portal depth, it's affected for outdoor ambient audible")]
	public float Depth; //Field offset: 0x24
	[Tooltip("Optionally give the portal a unique name for more informative debug messages.")]
	public string portalName; //Field offset: 0x28
	public PortalType portalType; //Field offset: 0x30
	public PortalState state; //Field offset: 0x34
	public BoxCollider portalCollider; //Field offset: 0x38
	[Range(0, 1)]
	public float traversalMaxCost; //Field offset: 0x40
	public bool ToOutdoor; //Field offset: 0x44
	public AnimationCurve openEnvelope; //Field offset: 0x48
	public AnimationCurve closeEnvelope; //Field offset: 0x50
	[Range(0, 10)]
	public float openFadeTime; //Field offset: 0x58
	[Range(0, 10)]
	public float closeFadeTime; //Field offset: 0x5C
	[SerializeField]
	private short _iD; //Field offset: 0x60
	[SerializeField]
	private List _connectedRooms; //Field offset: 0x68
	private bool _inProgressOpen; //Field offset: 0x70
	private bool _inProgressClose; //Field offset: 0x71
	private Coroutine _interactionCoroutine; //Field offset: 0x78
	private PortalState _prevFinalState; //Field offset: 0x80
	[CompilerGenerated]
	private float <PortalClosureLevel>k__BackingField; //Field offset: 0x84

	public SpatialAudioRoom BackRoom
	{
		 get { } //Length: 128
	}

	public SpatialAudioRoom FrontRoom
	{
		 get { } //Length: 128
	}

	public short ID
	{
		 get { } //Length: 5
	}

	public private float PortalClosureLevel
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	protected PortalState State
	{
		 get { } //Length: 5
		 set { } //Length: 286
	}

	protected BaseSpatialAudioPortal() { }

	private void Awake() { }

	public override Vector3 Center() { }

	[IteratorStateMachine(typeof(<ClosePortal>d__50))]
	private IEnumerator ClosePortal(float start, float duration) { }

	private void DisableMeshRenderer() { }

	public SpatialAudioRoom get_BackRoom() { }

	public SpatialAudioRoom get_FrontRoom() { }

	public short get_ID() { }

	[CompilerGenerated]
	public float get_PortalClosureLevel() { }

	protected PortalState get_State() { }

	public List GetConnectedRooms() { }

	public float GetPortalArea() { }

	public float2 GetPortalHalfSize() { }

	public Vector2 GetPortalSize() { }

	protected override Task Init() { }

	private void InvokeChangedEventOnFinalState(PortalState newState) { }

	public override bool IsOpen() { }

	protected bool IsPositionIdentical(Vector3 interactiveObjectPosition) { }

	protected override void OnAwake() { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<OpenPortal>d__49))]
	private IEnumerator OpenPortal(float start, float duration) { }

	[CompilerGenerated]
	private void set_PortalClosureLevel(float value) { }

	protected void set_State(PortalState value) { }

	public void SetConnectedRoom(SpatialAudioRoom room) { }

	private void SetName() { }

	private void SetPortalClosed(bool allowFade) { }

	protected void SetPortalOpen(bool allowFade) { }

	protected void SetPortalStatus(PortalState requiredState, bool allowFade) { }

	private void StopInteractionCoroutine() { }

	protected override void Subscribe() { }

	protected override void SyncState() { }

	protected override void Unsubscribe() { }

}

