//Type is in global namespace

public class ProgressAggregator`1 : IProgress
{
	private readonly int _systemCount; //Field offset: 0x0
	private readonly T[] _progress; //Field offset: 0x0
	private readonly CancellationToken _cancellationToken; //Field offset: 0x0
	private readonly INumericOperations _numericOperations; //Field offset: 0x0
	private readonly Action _handler; //Field offset: 0x0

	public ProgressAggregator`1(int systemCount, INumericOperations numericOps, Action handler, CancellationToken cancellationToken = null) { }

	public override void Report(T value) { }

	public void UpdateProgress(int systemIndex, T progressValue) { }

}

