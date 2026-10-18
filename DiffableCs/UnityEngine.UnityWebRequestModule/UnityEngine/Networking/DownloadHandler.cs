namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable
{
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; //Field offset: 0x10

	public byte[] data
	{
		 get { } //Length: 20
	}

	public string text
	{
		 get { } //Length: 20
	}

	[VisibleToOtherModules]
	internal DownloadHandler() { }

	[RequiredByNativeCode]
	protected override void CompleteContent() { }

	internal static void CreateNativeArrayForNativeData(ref NativeArray data, byte* bytes, int length) { }

	public override void Dispose() { }

	internal static void DisposeNativeArray(ref NativeArray data) { }

	protected virtual void Finalize() { }

	public byte[] get_data() { }

	public string get_text() { }

	protected static T GetCheckedDownloader(UnityWebRequest www) { }

	private string GetContentType() { }

	protected override byte[] GetData() { }

	protected override NativeArray GetNativeData() { }

	[RequiredByNativeCode]
	protected override float GetProgress() { }

	protected override string GetText() { }

	private Encoding GetTextEncoder() { }

	[NativeThrows]
	[VisibleToOtherModules]
	internal static byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

	internal static NativeArray InternalGetNativeArray(DownloadHandler dh, ref NativeArray nativeArray) { }

	[Obsolete("Use ReceiveContentLengthHeader")]
	protected override void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	protected override void ReceiveContentLengthHeader(ulong contentLength) { }

	[RequiredByNativeCode]
	protected override bool ReceiveData(byte[] data, int dataLength) { }

	[NativeMethod(IsThreadSafe = True)]
	private void Release() { }

}

