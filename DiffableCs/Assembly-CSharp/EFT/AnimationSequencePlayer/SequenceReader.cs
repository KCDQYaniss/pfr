namespace EFT.AnimationSequencePlayer;

public sealed class SequenceReader : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Play>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SequenceReader <>4__this; //Field offset: 0x20
		public CombinedAnimationData animationData; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[TextArea(4, 32)]
	public string json; //Field offset: 0x20
	private Animator _animator; //Field offset: 0x28
	private ULipSyncCurvesPlayer _lipSyncPlayer; //Field offset: 0x30
	private AnimationDictionary _animationDictionary; //Field offset: 0x38
	private SecondaryAnimationDictionary _secondaryAnimationDictionary; //Field offset: 0x40
	private LipSyncDictionary _lipSyncDictionary; //Field offset: 0x48

	public SequenceReader() { }

	private void Awake() { }

	private bool ParseJson(out CombinedAnimationData animationData) { }

	[ContextMenu("Play")]
	public void Play() { }

	[AsyncStateMachine(typeof(<Play>d__9))]
	public Task Play(CombinedAnimationData animationData) { }

}

