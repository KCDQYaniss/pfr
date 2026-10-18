namespace EFT.UI.DragAndDrop;

public class ItemViewLoadAmmoComponent : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private struct <StartAnimation>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemViewLoadAmmoComponent <>4__this; //Field offset: 0x20
		private float <progress>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image _loadMagazineLoader; //Field offset: 0x60
	[SerializeField]
	private GameObject _loadStopImage; //Field offset: 0x68
	[SerializeField]
	private ProgressSpinner _loadProgressSpinner; //Field offset: 0x70
	private float _oneAmmoDuration; //Field offset: 0x78
	private double _durationSeconds; //Field offset: 0x80
	private double _startTime; //Field offset: 0x88
	private double _startProgress; //Field offset: 0x90
	private CancellationTokenSource _taskCancellation; //Field offset: 0x98

	public ItemViewLoadAmmoComponent() { }

	public void Destroy() { }

	public void SetStopButtonStatus(bool active) { }

	public void Show(float oneAmmoDuration, int ammoTotal, int ammoDone = 0) { }

	[AsyncStateMachine(typeof(<StartAnimation>d__9))]
	private Task StartAnimation() { }

}

