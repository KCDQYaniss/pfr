namespace Meta.XR.Acoustics;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
public sealed class ProgressCallback : MulticastDelegate
{

	public ProgressCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(IntPtr userData, string description, float progress, AsyncCallback callback, object object) { }

	public override bool EndInvoke(IAsyncResult result) { }

	public override bool Invoke(IntPtr userData, string description, float progress) { }

}

