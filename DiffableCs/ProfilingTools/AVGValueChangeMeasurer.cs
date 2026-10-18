//Type is in global namespace

public class AVGValueChangeMeasurer
{
	internal class Counter
	{
		[CompilerGenerated]
		private string <Name>k__BackingField; //Field offset: 0x10
		private double _startValue; //Field offset: 0x18
		private double[] _values; //Field offset: 0x20
		private int _currentIndex; //Field offset: 0x28

		public private string Name
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public Counter(string name, int measureForAVG) { }

		public void Add(double value) { }

		public double AVG() { }

		public void FinishDiff(double value) { }

		[CompilerGenerated]
		public string get_Name() { }

		public double LastValue() { }

		[CompilerGenerated]
		private void set_Name(string value) { }

		public void StartDiff(double value) { }

	}

	private int _measureForAVG; //Field offset: 0x10
	private readonly Dictionary _counters; //Field offset: 0x18

	public AVGValueChangeMeasurer(int measureForAVG) { }

	public string AVGStats() { }

	public void Clear() { }

	public void FinishDiff(string name, double value) { }

	private Counter GetCounter(string name) { }

	public Dictionary GetCounters() { }

	public string LastValues() { }

	public void StartDiff(string name, double value) { }

}

