namespace Audio.SpatialSystem;

[RequireComponent(typeof(BoxCollider))]
public class SpatialAudioPortal : BaseSpatialAudioPortal, IIdentifiable
{
	[CompilerGenerated]
	private struct <Init>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpatialAudioPortal <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public string DoorID; //Field offset: 0x88
	private Action _unsubscribeOnDestroy; //Field offset: 0x90
	private List _ids; //Field offset: 0x98

	public override IReadOnlyCollection Ids
	{
		 get { } //Length: 8
	}

	public SpatialAudioPortal() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	public override IReadOnlyCollection get_Ids() { }

	[AsyncStateMachine(typeof(<Init>d__6))]
	protected virtual Task Init() { }

	private void OnDoorInteracted(InteractiveObjectInteractionResultEvent resultEvent) { }

	private void OnHitWindow(WindowBreaker breaker, DamageInfo info, Crack crack, float damage) { }

	protected virtual void Subscribe() { }

	protected virtual void SyncState() { }

	protected virtual void Unsubscribe() { }

}

