namespace UnityDiagnostics;

public class IncrementalMeasurer
{
	public readonly string GroupName; //Field offset: 0x10
	private int _counter; //Field offset: 0x18
	private bool _isActive; //Field offset: 0x1C
	public readonly IMeasureStatistics MeasureStatistics; //Field offset: 0x20

	public IncrementalMeasurer(string groupName, IMeasureStatistics measureStatistics) { }

	public void Increment() { }

	public void StartCounting() { }

	public void StopCounting() { }

}

