namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	internal UploadHandler() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[NativeMethod(IsThreadSafe = True)]
	private void Release() { }

}

