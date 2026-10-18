namespace System.Threading.Channels;

[Nullable(0)]
[NullableContext(1)]
public abstract class ChannelReader`1
{

	protected ChannelReader`1() { }

	public abstract bool TryRead(out T item) { }

	[NullableContext(0)]
	public abstract ValueTask WaitToReadAsync(CancellationToken cancellationToken = null) { }

}

