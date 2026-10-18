namespace UnityDiagnostics;

public class TimeMeasurer
{
	public readonly string GroupName; //Field offset: 0x10
	public readonly IMeasureStatistics MeasureStatistics; //Field offset: 0x18
	private readonly Stopwatch _stopwatch; //Field offset: 0x20
	private bool _isActive; //Field offset: 0x28
	private long _elapsedTicks; //Field offset: 0x30

	public double CurrentMilliseconds
	{
		 get { } //Length: 140
	}

	public TimeMeasurer(string name, IMeasureStatistics measureStatistics) { }

	public void AddMeasurement() { }

	public double get_CurrentMilliseconds() { }

	public long GetCurrentElapsedTicks() { }

	public void StartMeasure() { }

	public void StopMeasure(bool summarize = false) { }

}

