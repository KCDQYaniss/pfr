namespace EFT.Quests;

public sealed class ShootableQuestLocationObject : QuestLocationObject
{
	[CompilerGenerated]
	private sealed class <HideAfterDelay>d__23 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ShootableQuestLocationObject <>4__this; //Field offset: 0x20

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
		public <HideAfterDelay>d__23(int <>1__state) { }

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

	private const float HIDE_DELAY_SECONDS = 35; //Field offset: 0x0
	[SerializeField]
	private BallisticCollider _ballisticCollider; //Field offset: 0x60
	[SerializeField]
	private GameObject _solidObject; //Field offset: 0x68
	[SerializeField]
	private GameObject _fragmentedObject; //Field offset: 0x70
	[SerializeField]
	private float _breakForceMultiplier; //Field offset: 0x78
	[SerializeField]
	private List _rigidbodies; //Field offset: 0x80
	private bool _isBroken; //Field offset: 0x88
	private Vector3 _lastLocalHitPoint; //Field offset: 0x8C
	private Vector3 _lastLocalHitDirection; //Field offset: 0x98
	private Coroutine _hideCoroutine; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnBroken; //Field offset: 0xB0

	public event Action OnBroken
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public BallisticCollider BallisticCollider
	{
		 get { } //Length: 5
	}

	public ShootableQuestLocationObject() { }

	[CompilerGenerated]
	public void add_OnBroken(Action value) { }

	public void Awake() { }

	private void BreakLocal(Vector3 hitPoint, Vector3 hitDirection) { }

	private void DisableHitColliders() { }

	public BallisticCollider get_BallisticCollider() { }

	[IteratorStateMachine(typeof(<HideAfterDelay>d__23))]
	private IEnumerator HideAfterDelay() { }

	private void InitializeClientBreak() { }

	private void OnDestroy() { }

	private void OnHit(DamageInfo damageInfo) { }

	private void PlayBreakPhysics(Vector3 force, Vector3 position, float forceMultiplier) { }

	[CompilerGenerated]
	public void remove_OnBroken(Action value) { }

	public virtual void SetQuestObjectActiveState(bool state) { }

}

