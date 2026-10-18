namespace ChatShared;

[ChatRPC]
[Obfuscation(Exclude = True)]
public interface IChatHandle
{

	public void Close(Action callback) { }

	public void Replay(string text, string replayMessageId) { }

	public void Send(string text) { }

}

