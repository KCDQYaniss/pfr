//Type is in global namespace

public class FirefightAreaController : ISequenceEndSync
{
	private float _cooldown; //Field offset: 0x10
	private readonly List _activeSequenceEndTimes; //Field offset: 0x18
	private bool _disposed; //Field offset: 0x20
	private double _nextAllowedResponseTime; //Field offset: 0x28
	private double _busyUntil; //Field offset: 0x30
	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x38
	private readonly IPlaybackStrategySelector _playbackStrategySelector; //Field offset: 0x40
	private readonly IFirePlaybackStrategy _grenadeFireStrategy; //Field offset: 0x48
	private Action _unsubOnDestroy; //Field offset: 0x50
	private Vector3 _cachedForwardXZ; //Field offset: 0x58
	private Vector3 _cachedDirStart; //Field offset: 0x64
	private Vector3 _cachedDirEnd; //Field offset: 0x70
	private bool _sectorDirsCached; //Field offset: 0x7C
	private float _cachedApertureDeg; //Field offset: 0x80
	[CompilerGenerated]
	private readonly FirefightArea <FirefightArea>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private int <MaxActiveSequences>k__BackingField; //Field offset: 0x90

	public int ActiveSequenceCount
	{
		 get { } //Length: 65
	}

	public FirefightArea FirefightArea
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private int MaxActiveSequences
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public FirefightAreaController(FirefightArea firefightArea, AudioSourcePriorityCalculator priorityCalculator) { }

	private Vector3 ComputeNormalizedForward() { }

	public void Dispose() { }

	public int get_ActiveSequenceCount() { }

	[CompilerGenerated]
	public FirefightArea get_FirefightArea() { }

	[CompilerGenerated]
	public int get_MaxActiveSequences() { }

	private Vector3 GetRandomPositionInAreaSector() { }

	private void InitializeSectorCache() { }

	private void OnOtherAreaGunfire(FirefightDirectorGunfireEvent gunfireEvent) { }

	public override void ReportSequenceBusyUntil(double end, AudioEventType type) { }

	public override void ReportSequenceEnd(double end, AudioEventType type) { }

	[CompilerGenerated]
	private void set_MaxActiveSequences(int value) { }

	public void SetMaxActiveSequences(int slotsCount) { }

	public void Tick(float dt) { }

	private void TryScheduleGrenade(float dt, float density, CameraManager camManager) { }

}

