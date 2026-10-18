namespace ChatShared;

public sealed class Proxy4IChatHandle : Proxy4Interface, IChatHandle
{

	private Proxy4IChatHandle(Delegate[] delegates) { }

	public Proxy4IChatHandle(Delegate[] delegates, object obj) { }

	private override void ChatShared.IChatHandle.Close(Action callback) { }

	private override void ChatShared.IChatHandle.Replay(string text, string replayMessageId) { }

	private override void ChatShared.IChatHandle.Send(string text) { }

	public static Proxy4IChatHandle Create(Delegate[] delegates) { }

}

