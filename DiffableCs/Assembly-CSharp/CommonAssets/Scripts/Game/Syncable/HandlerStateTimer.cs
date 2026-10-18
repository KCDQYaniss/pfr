namespace CommonAssets.Scripts.Game.Syncable;

[Obfuscation(Exclude = True)]
public class HandlerStateTimer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__10_0; //Field offset: 0x10
		public static Func <>9__10_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <OnValidate>b__10_0(HandlerStateBase go) { }

		internal bool <OnValidate>b__10_1(HandlerStateBase x) { }

		internal bool <ValidateTarget>b__8_0(HandlerStateBase x) { }

	}

	[SerializeField]
	private HandlerStateBase[] _handledStates; //Field offset: 0x20
	[SerializeField]
	private float _startDelaySeconds; //Field offset: 0x28
	[SerializeField]
	private float _workDurationSeconds; //Field offset: 0x2C
	[SerializeField]
	private bool _startOnAwake; //Field offset: 0x30
	[SerializeField]
	private bool _targetState; //Field offset: 0x31
	[SerializeField]
	private string _id; //Field offset: 0x38
	[SerializeField]
	private int _idHash; //Field offset: 0x40
	private Action _unsubOnDestroy; //Field offset: 0x48

	public HandlerStateTimer() { }

	private void Awake() { }

	private void HandlerGOStateTimerSyncEventHandler(HandlerGOStateTimerSyncEvent syncEvent) { }

	private void OnDestroy() { }

	private void OnValidate() { }

	private void SetState(bool state) { }

	private void Start() { }

	private bool ValidateID(string id) { }

	private bool ValidateTarget(HandlerStateBase[] targets) { }

}

