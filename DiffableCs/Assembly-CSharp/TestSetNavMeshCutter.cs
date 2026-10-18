//Type is in global namespace

public class TestSetNavMeshCutter : MonoBehaviour
{
	[CompilerGenerated]
	private struct <DoTestAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TestSetNavMeshCutter <>4__this; //Field offset: 0x20
		private NavMeshPath <path>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Transform From; //Field offset: 0x20
	public Transform To; //Field offset: 0x28
	public Transform CutterPlace; //Field offset: 0x30
	public NavMeshObstacle LastObstacle; //Field offset: 0x38

	public TestSetNavMeshCutter() { }

	public void DoTest() { }

	[AsyncStateMachine(typeof(<DoTestAsync>d__5))]
	public Task DoTestAsync() { }

}

