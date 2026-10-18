namespace ZLogger.Formatters;

public sealed class JsonLogInfoFormatter : MulticastDelegate
{

	public JsonLogInfoFormatter(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Utf8JsonWriter jsonWriter, in LogInfo info, AsyncCallback callback, object object) { }

	public override void EndInvoke(in LogInfo info, IAsyncResult result) { }

	[NullableContext(1)]
	public override void Invoke(Utf8JsonWriter jsonWriter, in LogInfo info) { }

}

