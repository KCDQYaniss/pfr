namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
public static class XRDevice
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action deviceLoaded; //Field offset: 0x0

	[RequiredByNativeCode]
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }

}

