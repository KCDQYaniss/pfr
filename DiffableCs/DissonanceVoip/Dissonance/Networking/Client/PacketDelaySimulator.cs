namespace Dissonance.Networking.Client;

internal class PacketDelaySimulator
{
	private readonly Random _rnd; //Field offset: 0x10

	public PacketDelaySimulator() { }

	private static bool IsOrderedReliable(MessageTypes header) { }

	public bool ShouldLose(ArraySegment packet) { }

}

