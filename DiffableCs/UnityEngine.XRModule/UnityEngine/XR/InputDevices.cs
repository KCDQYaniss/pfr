namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[UsedByNativeCode]
public class InputDevices
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action deviceConnected; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action deviceDisconnected; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action deviceConfigChanged; //Field offset: 0x10

	[RequiredByNativeCode]
	private static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change) { }

}

