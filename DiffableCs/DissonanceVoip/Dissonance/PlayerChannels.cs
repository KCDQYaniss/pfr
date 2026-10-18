namespace Dissonance;

public sealed class PlayerChannels : Channels
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__0_0; //Field offset: 0x8
		public static Action <>9__0_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__0_0(string id, ChannelProperties _) { }

		internal void <.ctor>b__0_1(string id, ChannelProperties _) { }

	}


	internal PlayerChannels(IChannelPriorityProvider priorityProvider) { }

	protected virtual PlayerChannel CreateChannel(ushort subscriptionId, string channelId, ChannelProperties properties) { }

}

