namespace ChatShared;

public sealed class Proxy4IChatMember : Proxy4Interface, IChatMember
{

	private Proxy4IChatMember(Delegate[] delegates) { }

	public Proxy4IChatMember(Delegate[] delegates, object obj) { }

	private override void ChatShared.IChatMember.Add(ChatRoomMember[] members) { }

	private override void ChatShared.IChatMember.Drop() { }

	private override void ChatShared.IChatMember.Receive(Message message) { }

	private override void ChatShared.IChatMember.ReceiveReplay(Message message, Message replayMessage) { }

	private override void ChatShared.IChatMember.Remove(string[] members) { }

	private override void ChatShared.IChatMember.SetBanned(string memberId, DateTime toDateTime) { }

	private override void ChatShared.IChatMember.SetUnbanned(string memberId) { }

	public static Proxy4IChatMember Create(Delegate[] delegates) { }

}

