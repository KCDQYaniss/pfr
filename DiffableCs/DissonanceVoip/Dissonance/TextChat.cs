namespace Dissonance;

public sealed class TextChat
{
	private readonly Func _getNetwork; //Field offset: 0x10
	[CompilerGenerated]
	private Action MessageReceived; //Field offset: 0x18

	public event Action MessageReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	internal TextChat(Func getNetwork) { }

	[CompilerGenerated]
	public void add_MessageReceived(Action value) { }

	internal void OnMessageReceived(TextMessage obj) { }

	[CompilerGenerated]
	public void remove_MessageReceived(Action value) { }

	public void Send(string roomName, string message) { }

	public void Whisper(string playerName, string message) { }

}

