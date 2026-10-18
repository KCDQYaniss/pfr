namespace EFT.Interactive;

public sealed class TrainRequirement : ExfiltrationRequirement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ExfiltrationPoint point; //Field offset: 0x10
		public GameTimer gameTimer; //Field offset: 0x18
		public TrainRequirement <>4__this; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <Start>b__0(ETravelState state) { }

		internal void <Start>g__InitTrain|2() { }

		internal void <Start>g__LocomotiveInit|1(bool deferred = false) { }

	}

	private const string WAIT_ARRIVAL = "EXFILTRATION_WAIT_ARRIVAL"; //Field offset: 0x0
	private const string WAIT_DEPARTURE = "EXFILTRATION_WAIT_DEPARTURE"; //Field offset: 0x0
	private Action _unbind; //Field offset: 0x30
	private Locomotive Locomotive; //Field offset: 0x38

	public TrainRequirement() { }

	public virtual string GetLocalizedTip(string profileId) { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

	public virtual void OnDestroy() { }

	public virtual void Start(ExfiltrationPoint point) { }

}

