//Type is in global namespace

public class BulletSimulator : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CreateAssetsSystem>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private OperationAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BulletSimulator <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private BallisticsCalculator _ballisticsCalculator; //Field offset: 0x20
	private Shot _shot; //Field offset: 0x28
	private Text _textLabel; //Field offset: 0x30
	[Header("Ammo data")]
	public AmmoTemplate AmmoTemplate; //Field offset: 0x38
	public Ammo Ammo; //Field offset: 0x40
	[Header("Aiming data")]
	public float MaxDistance; //Field offset: 0x48
	public float CurrentDistance; //Field offset: 0x4C
	public float DistanceStep; //Field offset: 0x50
	[Header("Simulation data")]
	public float SimulationStep; //Field offset: 0x54
	public float SimulationTime; //Field offset: 0x58
	public float MarkerScaleStep; //Field offset: 0x5C
	private GameObject TargetMarker; //Field offset: 0x60

	public BulletSimulator() { }

	[AsyncStateMachine(typeof(<CreateAssetsSystem>d__14))]
	private static Task CreateAssetsSystem() { }

	private void CreateBallisticsCalculator() { }

	private void CreateTargetMarker() { }

	private void CreateUI() { }

	private void HandleInput() { }

	public void OnDrawGizmos() { }

	public void OnShotFinishedHandler(Shot shot) { }

	private void SetCurrentDistanse(float value) { }

	private void ShowDistance() { }

	public void SimulateShot() { }

	[AsyncStateMachine(typeof(<Start>d__12))]
	private Task Start() { }

	public void Update() { }

	private void UpdateTargetMarker() { }

}

