namespace EFT.Interactive;

public class SceneFlareLauncher : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LaunchFlareWIthDelay>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SceneFlareLauncher <>4__this; //Field offset: 0x20
		public Vector3 worldPosition; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private GameObject _flarePrefab; //Field offset: 0x20
	[SerializeField]
	private GameObject _flareSoundPrefab; //Field offset: 0x28
	[SerializeField]
	private Vector3 _flareDirection; //Field offset: 0x30
	[SerializeField]
	private float _flareShotDelaySeconds; //Field offset: 0x3C
	private int _flareShotDelayMilliseconds; //Field offset: 0x40

	public SceneFlareLauncher() { }

	private void Awake() { }

	public void LaunchFlare() { }

	public void LaunchFlare(Vector3 worldPosition) { }

	[AsyncStateMachine(typeof(<LaunchFlareWIthDelay>d__8))]
	private Task LaunchFlareWIthDelay(Vector3 worldPosition) { }

}

