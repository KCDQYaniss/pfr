namespace Newtonsoft.Json.Serialization;

public sealed class ExtensionDataGetter : MulticastDelegate
{

	public ExtensionDataGetter(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

	public override IEnumerable EndInvoke(IAsyncResult result) { }

	[NullableContext(1)]
	public override IEnumerable Invoke(object o) { }

}

