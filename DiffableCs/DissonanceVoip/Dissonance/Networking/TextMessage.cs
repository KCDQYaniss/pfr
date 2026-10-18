namespace Dissonance.Networking;

public struct TextMessage
{
	public readonly string Sender; //Field offset: 0x0
	public readonly ChannelType RecipientType; //Field offset: 0x8
	public readonly string Recipient; //Field offset: 0x10
	public readonly string Message; //Field offset: 0x18

	public TextMessage(string sender, ChannelType recipientType, string recipient, string message) { }

}

