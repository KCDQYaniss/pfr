namespace Diz.Jobs;

internal class ContinuationProfiler
{
	private static readonly Stopwatch _stopwatch; //Field offset: 0x0
	private Dictionary _samples; //Field offset: 0x10
	private SimpleAverage _currentCounter; //Field offset: 0x18
	public bool Enabled; //Field offset: 0x20

	private static ContinuationProfiler() { }

	public ContinuationProfiler() { }

	[Conditional("DEBUG")]
	public void BeginSample(string jobId, string jobStageId) { }

	[Conditional("DEBUG")]
	public void EndSample() { }

	private SimpleAverage GetCounter(string jobId, string jobStageId) { }

	public string GetReport() { }

}

