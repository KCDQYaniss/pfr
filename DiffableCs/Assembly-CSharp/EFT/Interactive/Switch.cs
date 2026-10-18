namespace EFT.Interactive;

public class Switch : WorldInteractiveObject
{
	[CompilerGenerated]
	private sealed class <HandleTurnOff>d__36 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Switch <>4__this; //Field offset: 0x20

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
		public <HandleTurnOff>d__36(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <SmoothDoorOpenCoroutine>d__37 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Switch <>4__this; //Field offset: 0x20
		public EDoorState state; //Field offset: 0x28
		public bool isLocalInteraction; //Field offset: 0x29
		public float speed; //Field offset: 0x2C

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
		public <SmoothDoorOpenCoroutine>d__37(int <>1__state) { }

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

	internal class SwitchAndOperation
	{
		public Switch Switch; //Field offset: 0x10
		public EInteractionType Operation; //Field offset: 0x18

		public SwitchAndOperation() { }

	}

	[Header("-------------  Switch -----------")]
	[SerializeField]
	private bool _typeSpecificLogOnUse; //Field offset: 0x178
	[SerializeField]
	private string _specificLogOnUse; //Field offset: 0x180
	public bool DontAnimateRotation; //Field offset: 0x188
	public string ContextMenuTip; //Field offset: 0x190
	public float Delay; //Field offset: 0x198
	[Header("Exfiltration Zone")]
	public ExfiltrationPoint ExfiltrationPoint; //Field offset: 0x1A0
	public EExfiltrationStatus TargetStatus; //Field offset: 0x1A8
	public EExfiltrationStatus[] ConditionStatus; //Field offset: 0x1B0
	public string ExtractionZoneTip; //Field offset: 0x1B8
	[Header("Other Switches")]
	public SwitchAndOperation[] NextSwitches; //Field offset: 0x1C0
	public Switch PreviousSwitch; //Field offset: 0x1C8
	public bool AutoTurnOff; //Field offset: 0x1D0
	public int AutoTurnOffSecondsDelay; //Field offset: 0x1D4
	[Header("Door")]
	public Door Door; //Field offset: 0x1D8
	public EInteractionType Interaction; //Field offset: 0x1E0
	[Header("Lamps")]
	public LampController[] Lamps; //Field offset: 0x1E8
	[Header("Curve is played 1.5x faster. Consider!")]
	public AnimationCurve CustomProgressCurve; //Field offset: 0x1F0
	public Vector3 ShutPosition; //Field offset: 0x1F8
	public Vector3 OpenPosition; //Field offset: 0x204

	public virtual float AngleSyncForSync
	{
		 get { } //Length: 9
	}

	public virtual float CurrentAngle
	{
		 get { } //Length: 6
		 set { } //Length: 178
	}

	public bool HasAuthority
	{
		 get { } //Length: 62
	}

	public virtual float MaxAllowedAngleDesync
	{
		 get { } //Length: 9
	}

	public virtual AnimationCurve ProgressCurve
	{
		 get { } //Length: 8
	}

	public virtual string TypeKey
	{
		 get { } //Length: 49
	}

	public Switch() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator <>n__0(EDoorState state, bool isLocalInteraction, float speed) { }

	public bool CanOperateByExfiltration(int playerID) { }

	public virtual float get_AngleSyncForSync() { }

	public virtual float get_CurrentAngle() { }

	public bool get_HasAuthority() { }

	public virtual float get_MaxAllowedAngleDesync() { }

	public virtual AnimationCurve get_ProgressCurve() { }

	public virtual string get_TypeKey() { }

	public virtual InteractionParameters GetInteractionParameters(Vector3 playerPosition) { }

	public string GetTip() { }

	[IteratorStateMachine(typeof(<HandleTurnOff>d__36))]
	private IEnumerator HandleTurnOff() { }

	public virtual void Interact(InteractionResult interactionResult) { }

	protected virtual void Open() { }

	protected override void ProcessAngleAsShift(float value) { }

	protected virtual void ProcessOcclusion(BetterSource source, Vector3 position) { }

	protected virtual void set_CurrentAngle(float value) { }

	private void SetLampsState(EState state) { }

	[IteratorStateMachine(typeof(<SmoothDoorOpenCoroutine>d__37))]
	protected virtual IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1) { }

}

