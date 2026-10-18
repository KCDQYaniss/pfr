//Type is in global namespace

public class TestEffects : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Start>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TestEffects <>4__this; //Field offset: 0x20
		private OperationAwaiter <>u__1; //Field offset: 0x28
		private OperationAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public int ID; //Field offset: 0x20
	public Camera Camera; //Field offset: 0x28
	public Effects Effects; //Field offset: 0x30
	private LightPool _lightPool; //Field offset: 0x38

	public TestEffects() { }

	[AsyncStateMachine(typeof(<Start>d__4))]
	private Task Start() { }

	private void Update() { }

}

