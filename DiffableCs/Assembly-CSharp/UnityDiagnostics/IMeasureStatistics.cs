namespace UnityDiagnostics;

public interface IMeasureStatistics
{

	public double Average
	{
		 get { } //Length: 0
	}

	public double LastValue
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public void AddMeasurement(MeasurementData measurementData) { }

	public double get_Average() { }

	public double get_LastValue() { }

	public string get_Name() { }

}

