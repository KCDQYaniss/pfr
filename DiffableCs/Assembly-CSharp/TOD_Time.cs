//Type is in global namespace

public class TOD_Time : MonoBehaviour
{
	private const string DateFormat = "d"; //Field offset: 0x0
	public bool LockCurrentTime; //Field offset: 0x20
	public GameDateTime GameDateTime; //Field offset: 0x28
	[TOD_Min(1)]
	[Tooltip("Length of one day in minutes.")]
	public float DayLengthInMinutes; //Field offset: 0x30
	[Tooltip("Set the date to the current device date on start.")]
	public bool UseDeviceDate; //Field offset: 0x34
	[Tooltip("Set the time to the current device time on start.")]
	public bool UseDeviceTime; //Field offset: 0x35
	[Tooltip("Apply the time curve when progressing time.")]
	public bool UseTimeCurve; //Field offset: 0x36
	[Tooltip("Time progression curve.")]
	public AnimationCurve TimeCurve; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnGameTimeUpdated; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnMinute; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnHour; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnDay; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnMonth; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnYear; //Field offset: 0x68
	private bool _isTaxonomyDateCached; //Field offset: 0x70
	private AnimationCurve timeCurve; //Field offset: 0x78
	private AnimationCurve timeCurveInverse; //Field offset: 0x80
	private DateTime _taxonomyTodDateTime; //Field offset: 0x88

	public event Action OnDay
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnGameTimeUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnHour
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnMinute
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnMonth
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnYear
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public TOD_Time() { }

	[CompilerGenerated]
	public void add_OnDay(Action value) { }

	[CompilerGenerated]
	public void add_OnGameTimeUpdated(Action value) { }

	[CompilerGenerated]
	public void add_OnHour(Action value) { }

	[CompilerGenerated]
	public void add_OnMinute(Action value) { }

	[CompilerGenerated]
	public void add_OnMonth(Action value) { }

	[CompilerGenerated]
	public void add_OnYear(Action value) { }

	public void AddHours(float hours, bool adjust = true) { }

	public void AddSeconds(float seconds) { }

	public float ApplyTimeCurve(float deltaTime) { }

	private void ApproximateCurve(AnimationCurve source, out AnimationCurve approxCurve, out AnimationCurve approxInverse) { }

	private void CalculateLinearTangents(Keyframe[] keys) { }

	protected void FixedUpdate() { }

	private DateTime GetTaxonomyTodSkyDate() { }

	public void RefreshTimeCurve() { }

	[CompilerGenerated]
	public void remove_OnDay(Action value) { }

	[CompilerGenerated]
	public void remove_OnGameTimeUpdated(Action value) { }

	[CompilerGenerated]
	public void remove_OnHour(Action value) { }

	[CompilerGenerated]
	public void remove_OnMinute(Action value) { }

	[CompilerGenerated]
	public void remove_OnMonth(Action value) { }

	[CompilerGenerated]
	public void remove_OnYear(Action value) { }

	protected void Start() { }

}

