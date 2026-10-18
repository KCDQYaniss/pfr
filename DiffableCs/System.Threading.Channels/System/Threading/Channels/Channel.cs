namespace System.Threading.Channels;

[Nullable(0)]
[NullableContext(1)]
public static class Channel
{

	public static Channel CreateBounded(BoundedChannelOptions options) { }

	public static Channel CreateBounded(BoundedChannelOptions options, Action itemDropped) { }

	public static Channel CreateUnbounded(UnboundedChannelOptions options) { }

}

