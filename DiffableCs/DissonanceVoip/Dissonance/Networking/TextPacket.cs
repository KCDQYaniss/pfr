namespace Dissonance.Networking;

internal struct TextPacket
{
	public readonly ushort Sender; //Field offset: 0x0
	public readonly ChannelType RecipientType; //Field offset: 0x4
	public readonly ushort Recipient; //Field offset: 0x8
	[CanBeNull]
	public readonly string Text; //Field offset: 0x10

	public TextPacket(ushort sender, ChannelType recipientType, ushort recipient, string text) { }

}

