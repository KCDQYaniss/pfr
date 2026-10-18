namespace System.Threading.Channels;

[Nullable(0)]
[NullableContext(2)]
public class ChannelClosedException : InvalidOperationException
{

	public ChannelClosedException() { }

	public ChannelClosedException(Exception innerException) { }

	[NullableContext(1)]
	protected ChannelClosedException(SerializationInfo info, StreamingContext context) { }

}

