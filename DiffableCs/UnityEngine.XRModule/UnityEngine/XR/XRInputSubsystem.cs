namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action trackingOriginUpdated; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action boundaryChanged; //Field offset: 0x28

	public XRInputSubsystem() { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

}

