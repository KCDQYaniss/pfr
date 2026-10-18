namespace EFT.Network;

public class SnapshotInterpolator`1
{
	private SnapshotInterpolatorOptions _options; //Field offset: 0x0
	private int _remoteFramerate; //Field offset: 0x0
	private float _remoteDeltaTime; //Field offset: 0x0
	private readonly int _driftEmaDuration; //Field offset: 0x0
	private ExponentialMovingAverage _deliveryTimeEma; //Field offset: 0x0
	private ExponentialMovingAverage _driftEma; //Field offset: 0x0
	private double _localTimeline; //Field offset: 0x0
	private double _localTimescale; //Field offset: 0x0
	private double _bufferTimeMultiplier; //Field offset: 0x0
	public SortedList snapshots; //Field offset: 0x0

	public double BufferMax
	{
		 get { } //Length: 13
	}

	public double BufferTime
	{
		 get { } //Length: 17
	}

	public double BufferTimeMultiplier
	{
		 get { } //Length: 9
	}

	public SnapshotInterpolator`1(int remoteFramerate, SnapshotInterpolatorOptions options) { }

	public void Add(T message) { }

	public double get_BufferMax() { }

	public double get_BufferTime() { }

	public double get_BufferTimeMultiplier() { }

	public T Interpolate(float deltaTime, Func interpolateFunc) { }

	public void Reset() { }

	public void SetRemoteFramerate(int framerate) { }

	public bool TryInterpolate(float deltaTime, Func interpolateFunc, out T snapshot) { }

}

