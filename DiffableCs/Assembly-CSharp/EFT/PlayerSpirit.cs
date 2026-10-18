namespace EFT;

[DisallowMultipleComponent]
public class PlayerSpirit : PlayerSpiritBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Item <HasActiveLightMode>b__17_0(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <HideUnusedPartOnNextFrameWorker>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerSpirit <>4__this; //Field offset: 0x20

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
		public <HideUnusedPartOnNextFrameWorker>d__14(int <>1__state) { }

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

	private const int _playerStillVisibleFrameCountThreshold = 10; //Field offset: 0x0
	protected SpriteRenderer _spiritDebugImage; //Field offset: 0x128
	protected readonly Vector3 _unseenPlace; //Field offset: 0x130
	protected readonly List _slotIdsWithVisibleWeapons; //Field offset: 0x140
	private int _playerStillVisibleFrameCount; //Field offset: 0x148

	public PlayerSpirit() { }

	[CompilerGenerated]
	private bool <HasActiveLightMode>b__16_0(Slot slot) { }

	protected bool CanSwitchToSpirit() { }

	public void ConnectToPlayerEvents() { }

	protected bool HasActiveLightMode() { }

	protected bool HasActiveLightMode(Weapon weapon) { }

	public void HideUnusedPart() { }

	public void HideUnusedPartOnNextFrame() { }

	[IteratorStateMachine(typeof(<HideUnusedPartOnNextFrameWorker>d__14))]
	protected IEnumerator HideUnusedPartOnNextFrameWorker() { }

	public virtual void Init(Player player, Vector3 position, bool isBodyAnimatorUpdating, Mode characterControllerMode, Mode disconnectedCharacterControllerMode) { }

	protected void InitDebugImage() { }

	protected void InventoryControllerOnAddItemEvent(AddItemEventArgs addItemEventArgs) { }

	private void OnRenderObject() { }

	public virtual void PlayerSync() { }

	public void RecheckSwitch() { }

	public void Switch(bool toSpirit) { }

	protected void TranslateAnimatorState(IAnimator animatorRecipient, IAnimator animatorDonor, EUpdateMode updateMode) { }

	protected void TranslateStateToPlayer() { }

	protected void TranslateStateToSpirit() { }

}

