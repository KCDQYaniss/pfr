namespace ChartAndGraph;

internal class ChartAdvancedSettings
{
	private static ChartAdvancedSettings mInstance; //Field offset: 0x0
	private static string[] FractionDigits; //Field offset: 0x8
	[Range(0, 7)]
	public int ValueFractionDigits; //Field offset: 0x10
	[Range(0, 7)]
	public int AxisFractionDigits; //Field offset: 0x14

	public static ChartAdvancedSettings Instance
	{
		 get { } //Length: 299
	}

	private static ChartAdvancedSettings() { }

	public ChartAdvancedSettings() { }

	public string FormatFractionDigits(int digits, double val) { }

	public static ChartAdvancedSettings get_Instance() { }

	private string getFormat(int value) { }

	private string InnerFormat(string format, double val) { }

}

