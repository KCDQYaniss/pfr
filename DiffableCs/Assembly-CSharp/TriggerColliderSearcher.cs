//Type is in global namespace

public class TriggerColliderSearcher : MonoBehaviour
{
	private class Core
	{
		[CompilerGenerated]
		private sealed class <Search>d__25 : IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public Core <>4__this; //Field offset: 0x20
			private AwaitMultiWorldsOverlapBoxAsyncData <awaitData>5__2; //Field offset: 0x28
			private Vector3 <lastPosition>5__3; //Field offset: 0x30
			private AwaitMultiWorldsOverlapBoxAsyncData <lastResult>5__4; //Field offset: 0x40
			private int <count>5__5; //Field offset: 0x48
			private int <enteredCollidersCount>5__6; //Field offset: 0x4C
			private int <i>5__7; //Field offset: 0x50

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
			public <Search>d__25(int <>1__state) { }

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

		private string _name; //Field offset: 0x10
		private Collider _collider; //Field offset: 0x18
		private LayerMask _castLayerMask; //Field offset: 0x20
		private Func _boundsGetter; //Field offset: 0x28
		public Transform OverrideTransformPosition; //Field offset: 0x30
		private EWorldType _physicsWorldTypeMask; //Field offset: 0x38
		private Collider[] _hits; //Field offset: 0x40
		private Collider[][] _hitsTempBuffer; //Field offset: 0x48
		private List _enteredColliders; //Field offset: 0x50
		private List _enteredCollidersWithStay; //Field offset: 0x58
		private Dictionary _colliderTriggers; //Field offset: 0x60
		private ListPool _listsCache; //Field offset: 0x68
		private List _componentsBuffer; //Field offset: 0x70
		[CompilerGenerated]
		private Action OnEnter; //Field offset: 0x78
		[CompilerGenerated]
		private Action OnExit; //Field offset: 0x80
		private IEnumerator _searchWorker; //Field offset: 0x88
		private long _coroutineTimeBreakerInterval; //Field offset: 0x90
		private Stopwatch _stopwatch; //Field offset: 0x98

		public event Action OnEnter
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public event Action OnExit
		{
			[CompilerGenerated]
			 add { } //Length: 278
			[CompilerGenerated]
			 remove { } //Length: 278
		}

		public Core(string name, Collider collider, float timeBreakerInterval = 9999) { }

		[CompilerGenerated]
		public void add_OnEnter(Action value) { }

		[CompilerGenerated]
		public void add_OnExit(Action value) { }

		public void Connect(Func boundsGetter) { }

		public void ManualUpdate(EWorldType physicsWorldTypeMask, LayerMask castLayerMask) { }

		private void PerformEnter(Collider collider) { }

		private void PerformExit(Collider collider, int index) { }

		private void PerformStay(Collider collider) { }

		[CompilerGenerated]
		public void remove_OnEnter(Action value) { }

		[CompilerGenerated]
		public void remove_OnExit(Action value) { }

		[IteratorStateMachine(typeof(<Search>d__25))]
		private IEnumerator Search() { }

		public void Shutdown() { }

	}

	public const int MAX_COLLIDERS = 512; //Field offset: 0x0
	public const int MAX_WORLDS_COLLIDERS = 8; //Field offset: 0x0
	[SerializeField]
	private Collider _collider; //Field offset: 0x20
	[SerializeField]
	private LayerMask _castLayerMask; //Field offset: 0x28
	private ICharacterController _characterController; //Field offset: 0x30
	private Transform _overrideTransformPosition; //Field offset: 0x38
	private Core _defaultCore; //Field offset: 0x40
	[CanBeNull]
	private Core _hoboCore; //Field offset: 0x48
	private List _cores; //Field offset: 0x50
	public bool IsEnabled; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsInited>k__BackingField; //Field offset: 0x59

	public event Action OnEnter
	{
		 add { } //Length: 608
		 remove { } //Length: 608
	}

	public event Action OnExit
	{
		 add { } //Length: 608
		 remove { } //Length: 608
	}

	public private bool IsInited
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Transform OverrideTransformPosition
	{
		 get { } //Length: 5
		 set { } //Length: 515
	}

	public TriggerColliderSearcher() { }

	[CompilerGenerated]
	private Bounds <ConnectToCharacterController>b__26_0() { }

	[CompilerGenerated]
	private Bounds <SetDisablerCullingObjectLayerEnabled>b__25_0() { }

	public void add_OnEnter(Action value) { }

	public void add_OnExit(Action value) { }

	public void ConnectToCharacterController(ICharacterController characterController) { }

	[CompilerGenerated]
	public bool get_IsInited() { }

	public Transform get_OverrideTransformPosition() { }

	public void Init(Collider collider, LayerMask castLayerMask) { }

	public void ManualUpdate(float deltaTime, bool isCloseToCamera = true) { }

	public void remove_OnEnter(Action value) { }

	public void remove_OnExit(Action value) { }

	[CompilerGenerated]
	private void set_IsInited(bool value) { }

	public void set_OverrideTransformPosition(Transform value) { }

	public void SetDisablerCullingObjectLayerEnabled(bool enabled) { }

}

