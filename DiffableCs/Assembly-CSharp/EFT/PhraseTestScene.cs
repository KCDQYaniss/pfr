namespace EFT;

public class PhraseTestScene : MonoBehaviour
{
	[CompilerGenerated]
	private struct <PreloadBundles>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private OperationAwaiter <>u__1; //Field offset: 0x20
		private TaskAwaiter <>u__2; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PhraseTestScene <>4__this; //Field offset: 0x28
		private OperationAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string BEAR_SASHA_PHRASE_BUNDLE = "assets/content/audio/prefabs/phrases/bear/bearsashaphrasesounds.bundle"; //Field offset: 0x0
	[SerializeField]
	private Camera _camera; //Field offset: 0x20

	public PhraseTestScene() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<PreloadBundles>d__4))]
	private Task PreloadBundles() { }

	[AsyncStateMachine(typeof(<Run>d__3))]
	private void Run() { }

}

