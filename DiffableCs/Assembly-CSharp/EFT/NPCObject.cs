namespace EFT;

public class NPCObject : MonoBehaviour
{
	[CompilerGenerated]
	private struct <PlayAction>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NPCObject <>4__this; //Field offset: 0x20
		public CombinedAnimationData animationData; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly Dictionary _npcs; //Field offset: 0x0
	[SerializeField]
	private ETraderType _npc; //Field offset: 0x20
	private SequenceReader _reader; //Field offset: 0x28
	[SerializeField]
	private UnityEvent _onEnter; //Field offset: 0x30
	[SerializeField]
	private UnityEvent _onExit; //Field offset: 0x38

	public ETraderType NPC
	{
		 get { } //Length: 4
	}

	private static NPCObject() { }

	public NPCObject() { }

	private void Awake() { }

	public static NPCObject Get(ETraderType source) { }

	public ETraderType get_NPC() { }

	public void GoIn(EftGamePlayerOwner playerOwner, Transform cameraTransform) { }

	public void GoOut() { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<PlayAction>d__8))]
	public Task PlayAction(CombinedAnimationData animationData) { }

}

