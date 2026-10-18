namespace ChatShared;

public sealed class Proxy4IChatsSession : Proxy4Interface, IChatsSession
{

	private Proxy4IChatsSession(Delegate[] delegates) { }

	public Proxy4IChatsSession(Delegate[] delegates, object obj) { }

	private override void ChatShared.IChatsSession.Ban(string profileId, TimeSpan timeSpan, string description, Callback callback) { }

	private override void ChatShared.IChatsSession.Close(Action callback) { }

	private override void ChatShared.IChatsSession.Start(IChatMember member, Callback callback) { }

	private override void ChatShared.IChatsSession.Start(IChatMember member, string chatId, Callback callback) { }

	private override void ChatShared.IChatsSession.Unban(string profileId, string description, Callback callback) { }

	public static Proxy4IChatsSession Create(Delegate[] delegates) { }

}

