//Type is in global namespace

public sealed class ChatSendDelegate : MulticastDelegate
{

	public ChatSendDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(DialogueChatMessage message, DialogueChatMessage replyToMessage, Action callback, AsyncCallback __callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(DialogueChatMessage message, DialogueChatMessage replyToMessage, Action callback) { }

}

