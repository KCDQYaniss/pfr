namespace EFT.UI;

public sealed class PlayerModelView : UIElement
{
	[CompilerGenerated]
	private struct <Show>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerModelView <>4__this; //Field offset: 0x20
		public Profile profile; //Field offset: 0x28
		public InventoryController inventoryController; //Field offset: 0x30
		public Action onCreated; //Field offset: 0x38
		public float update; //Field offset: 0x40
		public Nullable position; //Field offset: 0x44
		public bool animateWeapon; //Field offset: 0x54
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerModelView <>4__this; //Field offset: 0x20
		public Nullable position; //Field offset: 0x28
		public bool animateWeapon; //Field offset: 0x38
		public PlayerVisualRepresentation playerVisual; //Field offset: 0x40
		public InventoryController inventoryController; //Field offset: 0x48
		public float update; //Field offset: 0x50
		public Action onCreated; //Field offset: 0x58
		private CancellationTokenSource <cancellationTokenSource>5__2; //Field offset: 0x60
		private CancellationTokenRegistration <poolsRegistration>5__3; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private ProgressSpinner _progressSpinner; //Field offset: 0x70
	private readonly PlayerModelLoader _playerModelLoader; //Field offset: 0x78
	private CancellationTokenSource _loadingCancellation; //Field offset: 0x80
	private Vector3 _position; //Field offset: 0x88
	private bool _animateWeapon; //Field offset: 0x94
	private Vector3 _lastLossyScale; //Field offset: 0x98
	[CompilerGenerated]
	private bool <LoadingComplete>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private Action LoadingCompletedEvent; //Field offset: 0xA8

	public event Action LoadingCompletedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private bool LoadingComplete
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public MenuPlayerPoser ModelPlayerPoser
	{
		 get { } //Length: 27
	}

	public PlayerBody PlayerBody
	{
		 get { } //Length: 27
	}

	public PlayerModelView() { }

	[CompilerGenerated]
	private void <Show>b__19_0() { }

	[CompilerGenerated]
	private void <Show>b__19_1() { }

	[CompilerGenerated]
	public void add_LoadingCompletedEvent(Action value) { }

	public virtual void Close() { }

	private void Destroy() { }

	[CompilerGenerated]
	public bool get_LoadingComplete() { }

	public MenuPlayerPoser get_ModelPlayerPoser() { }

	public PlayerBody get_PlayerBody() { }

	private void OnLoadingCompleted() { }

	[CompilerGenerated]
	public void remove_LoadingCompletedEvent(Action value) { }

	private void ResetScaleCompensation() { }

	[CompilerGenerated]
	private void set_LoadingComplete(bool value) { }

	public void SetWeaponPatrol(bool enabled) { }

	[AsyncStateMachine(typeof(<Show>d__18))]
	public Task Show(Profile profile, InventoryController inventoryController = null, Action onCreated = null, float update = 0, Nullable position = null, bool animateWeapon = true) { }

	[AsyncStateMachine(typeof(<Show>d__19))]
	public Task Show(PlayerVisualRepresentation playerVisual, InventoryController inventoryController = null, Action onCreated = null, float update = 0, Nullable position = null, bool animateWeapon = true) { }

	public void Update() { }

}

