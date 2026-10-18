namespace Dissonance;

public sealed class RoomChannels : Channels
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


	internal RoomChannels(IChannelPriorityProvider priorityProvider) { }

	protected virtual RoomChannel CreateChannel(ushort subscriptionId, string channelId, ChannelProperties properties) { }

}

