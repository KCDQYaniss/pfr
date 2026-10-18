//Type is in global namespace

public class ValueChangeMeasurer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Counter <.ctor>b__11_0() { }

	}

	internal class Counter
	{
		public string Name; //Field offset: 0x10
		public double Result; //Field offset: 0x18
		public Counter Parent; //Field offset: 0x20
		private double _startValue; //Field offset: 0x28
		public bool IsInProgress; //Field offset: 0x30
		public bool IsValidResultValue; //Field offset: 0x31

		public Counter() { }

		public void FinishDiff(double value) { }

		public string GetFullName() { }

		public void Init(string name) { }

		public void Reset() { }

		public void StartDiff(double value, Counter parent = null) { }

	}

	private ObjectPool _countersPool; //Field offset: 0x10
	private Dictionary _counters; //Field offset: 0x18
	private StringBuilder _stringBuilder; //Field offset: 0x20

	public ValueChangeMeasurer() { }

	public void Clear() { }

	public void FinishDiff(string name, double value) { }

	public Counter GetCounter(string name) { }

	public Dictionary GetCounters() { }

	public string GetReport(bool fullName = true) { }

	public void Reset() { }

	public Counter StartDiff(string name, double value, Counter parent = null) { }

}

