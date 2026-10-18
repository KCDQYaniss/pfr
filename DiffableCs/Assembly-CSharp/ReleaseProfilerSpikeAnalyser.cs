//Type is in global namespace

public sealed class ReleaseProfilerSpikeAnalyser : IDisposable
{
	internal struct SpikeSample
	{
		public double Time; //Field offset: 0x0
		public List Samples; //Field offset: 0x8

	}

	private readonly double _triggerValue; //Field offset: 0x10
	private readonly int _maxRecords; //Field offset: 0x18
	private readonly Stopwatch _stopwatch; //Field offset: 0x20
	[CompilerGenerated]
	private readonly List <SpikeSamples>k__BackingField; //Field offset: 0x28

	public List SpikeSamples
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ReleaseProfilerSpikeAnalyser(double triggerValue, int maxRecords = 2147483647) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public List get_SpikeSamples() { }

}

