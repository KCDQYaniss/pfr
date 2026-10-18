namespace ZLogger.Formatters;

public sealed class MessageTemplateFormatter : MulticastDelegate
{

	public MessageTemplateFormatter(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(in MessageTemplate template, in LogInfo info, AsyncCallback callback, object object) { }

	public override void EndInvoke(in MessageTemplate template, in LogInfo info, IAsyncResult result) { }

	public override void Invoke(in MessageTemplate template, in LogInfo info) { }

}

