namespace UnityDiagnostics;

public class AvarageMeasureStatistics : IMeasureStatistics
{
	private double _lastValue; //Field offset: 0x10
	private readonly AverageDouble _averageDouble; //Field offset: 0x18
	private readonly string _name; //Field offset: 0x20

	public override double Average
	{
		 get { } //Length: 67
	}

	public override double LastValue
	{
		 get { } //Length: 6
	}

	public override string Name
	{
		 get { } //Length: 5
	}

	public AvarageMeasureStatistics(string name) { }

	public AvarageMeasureStatistics(string name, int valuesForAverageCalculation) { }

	public override void AddMeasurement(MeasurementData measurementData) { }

	public override double get_Average() { }

	public override double get_LastValue() { }

	public override string get_Name() { }

}

