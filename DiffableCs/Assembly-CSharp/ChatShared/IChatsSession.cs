namespace ChatShared;

[ChatRPC]
[Obfuscation(Exclude = True)]
public interface IChatsSession
{

	public void Ban(string profileId, TimeSpan timeSpan, string description, Callback callback) { }

	public void Close(Action callback) { }

	public void Start(IChatMember member, Callback callback) { }

	public void Start(IChatMember member, string chatId, Callback callback) { }

	public void Unban(string profileId, string description, Callback callback) { }

}

