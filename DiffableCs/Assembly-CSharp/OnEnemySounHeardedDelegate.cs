//Type is in global namespace

public sealed class OnEnemySounHeardedDelegate : MulticastDelegate
{

	public OnEnemySounHeardedDelegate(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(Vector3 pos, float dist, AISoundType type, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(Vector3 pos, float dist, AISoundType type) { }

}

