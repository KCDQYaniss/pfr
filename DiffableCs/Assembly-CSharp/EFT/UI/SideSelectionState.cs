namespace EFT.UI;

public class SideSelectionState : EftScreenState
{
	[CompilerGenerated]
	private struct <ChangeState>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SideSelectionState <>4__this; //Field offset: 0x20
		public bool enabled; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HideState>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SideSelectionState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitPreview>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerProfilePreview preview; //Field offset: 0x20
		public Profile profile; //Field offset: 0x28
		public float update; //Field offset: 0x30
		public SideSelectionState <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SideSelectionState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private YieldAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowState>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SideSelectionState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class SelectSideNode
	{
		[SerializeField]
		private Image _icon; //Field offset: 0x10
		[SerializeField]
		private PlayerProfilePreview _preview; //Field offset: 0x18
		[SerializeField]
		private GameObject _description; //Field offset: 0x20
		private Color _iconAOnColor; //Field offset: 0x28
		private Color _iconOffColor; //Field offset: 0x38
		private float _selectAnimationTime; //Field offset: 0x48
		private float _translationAnimationTime; //Field offset: 0x4C

		public PlayerProfilePreview Preview
		{
			 get { } //Length: 5
		}

		public EPlayerSide Side
		{
			 get { } //Length: 29
		}

		public SelectSideNode() { }

		public PlayerProfilePreview get_Preview() { }

		public EPlayerSide get_Side() { }

		public void Init(Color iconAOnColor, Color iconOffColor, float selectionTime, float translationTime) { }

		public void SetSelected(bool selected, bool immediate) { }

		public void SetVisibility(bool visible, bool immediate) { }

	}

	[SerializeField]
	private CanvasGroup _descriptionCanvasGroup; //Field offset: 0x90
	[SerializeField]
	private Color _selectedIconColor; //Field offset: 0x98
	[SerializeField]
	private Color _deselectedIconColor; //Field offset: 0xA8
	[SerializeField]
	private List _selectSideNodes; //Field offset: 0xB8
	private PreliminaryProfileData _profileData; //Field offset: 0xC0
	private Dictionary _profiles; //Field offset: 0xC8
	private PlayerIconCreatorMaterialChanger _materialChanger; //Field offset: 0xD0
	private Task _prepareTask; //Field offset: 0xD8

	public SideSelectionState() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__2(bool enabled) { }

	private void ChangeSelectionActiveness(bool active) { }

	[AsyncStateMachine(typeof(<ChangeState>d__14))]
	protected virtual Task ChangeState(bool enabled) { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<HideState>d__13))]
	public virtual Task HideState() { }

	public void Init(PreliminaryProfileData profileData, Dictionary profiles, PlayerIconCreatorMaterialChanger materialChanger) { }

	[AsyncStateMachine(typeof(<InitPreview>d__11))]
	private Task InitPreview(PlayerProfilePreview preview, Profile profile, float update) { }

	private bool IsSelectedSide(EPlayerSide side) { }

	[AsyncStateMachine(typeof(<PrepareAsync>d__10))]
	private Task PrepareAsync() { }

	[AsyncStateMachine(typeof(<ShowState>d__12))]
	public virtual Task ShowState() { }

	private void SideClicked(EPlayerSide side) { }

}

