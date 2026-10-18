namespace ChatShared;

[ChatRPC]
[Obfuscation(Exclude = True)]
public interface IChatMember
{

	public void Add(ChatRoomMember[] members) { }

	public void Drop() { }

	public void Receive(Message message) { }

	public void ReceiveReplay(Message message, Message replayMessage) { }

	public void Remove(string[] members) { }

	public void SetBanned(string memberId, DateTime toDateTime) { }

	public void SetUnbanned(string memberId) { }

}

