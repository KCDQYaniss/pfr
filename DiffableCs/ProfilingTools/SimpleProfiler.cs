//Type is in global namespace

public sealed class SimpleProfiler
{
	internal struct SampleReport
	{
		public string name; //Field offset: 0x0
		public double value; //Field offset: 0x8

		public SampleReport(string name, double value) { }

	}

	[IsReadOnly]
	internal struct Token : IDisposable
	{
		private readonly SimpleProfiler _simpleProfiler; //Field offset: 0x0
		private readonly Counter _counter; //Field offset: 0x8

		public Token(SimpleProfiler simpleProfiler, Counter counter) { }

		public override void Dispose() { }

	}

	private readonly Stopwatch _stopwatch; //Field offset: 0x10
	private readonly StringBuilder _stringBuilder; //Field offset: 0x18
	private readonly ValueChangeMeasurer _measurer; //Field offset: 0x20
	private Counter _currentCounter; //Field offset: 0x28
	private bool _hasSamples; //Field offset: 0x30

	public SimpleProfiler() { }

	public void BeginSample(string name) { }

	private Counter BeginSampleInternal(string name) { }

	public Token BeginSampleWithToken(string name) { }

	public void Clear() { }

	public void EndSample(string name) { }

	public void EndSample() { }

	private void EndSampleInternal(Counter counter) { }

	[CanBeNull]
	public List GetSamples(bool fullSampleName) { }

	public string GetStringReport() { }

	private double GetTime() { }

	public void PrintReport() { }

	public void Reset() { }

	private static double TickToMs(double ticks) { }

}

