namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandlerRaw.h")]
public sealed class UploadHandlerRaw : UploadHandler
{
	private NativeArray m_Payload; //Field offset: 0x18

	public UploadHandlerRaw(byte[] data) { }

	public UploadHandlerRaw(NativeArray data, bool transferOwnership) { }

	private static IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength) { }

	public virtual void Dispose() { }

}

