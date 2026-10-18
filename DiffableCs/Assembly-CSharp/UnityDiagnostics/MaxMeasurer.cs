namespace UnityDiagnostics;

public class MaxMeasurer
{
	public readonly string GroupName; //Field offset: 0x10
	public readonly IMeasureStatistics MeasureStatistics; //Field offset: 0x18
	private double _transitionalMax; //Field offset: 0x20

	public MaxMeasurer(string name, IMeasureStatistics measureStatistics) { }

	public void AddValue(double value) { }

	public void Commit() { }

}

