namespace UnityDiagnostics;

public class AvgMeasurer
{
	public readonly string GroupName; //Field offset: 0x10
	public readonly IMeasureStatistics MeasureStatistics; //Field offset: 0x18
	private double _transitionalSum; //Field offset: 0x20
	private int _transitionalCount; //Field offset: 0x28

	public AvgMeasurer(string name, IMeasureStatistics measureStatistics) { }

	public void AddValue(double value) { }

	public void Commit() { }

}

