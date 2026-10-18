namespace Diz.Utils;

public class SimpleProgress`1 : IProgress
{
	private readonly Action _handler; //Field offset: 0x0
	private readonly CancellationToken _cancellationToken; //Field offset: 0x0

	public SimpleProgress`1(Action handler, CancellationToken cancellationToken = null) { }

	public override void Report(T value) { }

}

