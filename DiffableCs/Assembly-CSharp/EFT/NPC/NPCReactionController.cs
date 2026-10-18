namespace EFT.NPC;

public class NPCReactionController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Reaction <.ctor>b__27_0() { }

	}

	[CompilerGenerated]
	private sealed class <ReactionsStateMachine>d__23 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NPCReactionController <>4__this; //Field offset: 0x20

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
		public <ReactionsStateMachine>d__23(int <>1__state) { }

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

	private enum EProcessQueueState
	{
		Waiting = 0,
		HandlingQueue = 1,
	}

	internal class ObjectWithID
	{
		public int ID; //Field offset: 0x10
		public GameObject gameObject; //Field offset: 0x18

		public ObjectWithID() { }

	}

	[SerializeField]
	private Animator _npcAnimator; //Field offset: 0x20
	[SerializeField]
	private NPCGlobalEventsReacting _eventsReacting; //Field offset: 0x28
	[SerializeField]
	private NPCAnimationsEventReceiver _animatorEventsReceiver; //Field offset: 0x30
	[SerializeField]
	private List _objectsForToggleVisibility; //Field offset: 0x38
	private LipSyncPlayer _lipSyncPlayer; //Field offset: 0x40
	private ObjectPool _reactionsPool; //Field offset: 0x48
	private Queue _reactionsQueue; //Field offset: 0x50
	private EProcessQueueState _currentState; //Field offset: 0x58
	private WaitForEndOfFrame _waitEndFrame; //Field offset: 0x60
	private Reaction _currentReaction; //Field offset: 0x68
	private Coroutine _reactionsStateMachineCoroutine; //Field offset: 0x70
	private Dictionary _objectsForToggleVisibilityDict; //Field offset: 0x78
	private bool _audioReactionIsPlaying; //Field offset: 0x80
	private Action _actionOnEndPlayAudioReactionFromAnimation; //Field offset: 0x88
	[HideInInspector]
	public int CurrentIdleAnimationNumber; //Field offset: 0x90

	public NPCReactionController() { }

	[CompilerGenerated]
	private void <OnCurrentAnimationReactionEnded>b__20_1() { }

	[CompilerGenerated]
	private void <OnCurrentAnimationReactionEnded>g__OnEndAnimReaction|20_0() { }

	[CompilerGenerated]
	private void <ReactionsStateMachine>b__23_0(string clipName) { }

	[CompilerGenerated]
	private void <ReactionsStateMachine>b__23_1() { }

	public void AddReactionInQueue(int eventID, ReactionOnEvent eventReaction) { }

	private void Awake() { }

	private void OnCurrentAnimationReactionEnded() { }

	private void OnCurrentAudioReactionEnded() { }

	private void OnDestroy() { }

	private void OnNeedChangeObjectVisibility(int objectID, bool visible) { }

	private void OnSomeAudioReactionStartedPlay() { }

	private void OnSomeAudioReactionStopped() { }

	[IteratorStateMachine(typeof(<ReactionsStateMachine>d__23))]
	private IEnumerator ReactionsStateMachine() { }

	public void TestChangeIdleAnimationNumber() { }

}

