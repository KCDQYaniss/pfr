namespace UnityDiagnostics;

public class ValueDiffStatisticsMeasurer
{
	public readonly string GroupName; //Field offset: 0x10
	public readonly IMeasureStatistics MeasureStatistics; //Field offset: 0x18
	private float _startValue; //Field offset: 0x20

	public ValueDiffStatisticsMeasurer(string name, IMeasureStatistics measureStatistics) { }

	public void StartMeasure(float value) { }

	public void StopMeasure(float value) { }

}

