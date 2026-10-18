namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
public static class CustomRenderTextureManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action textureLoaded; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action textureUnloaded; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action updateTriggered; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action initializeTriggered; //Field offset: 0x18

	[RequiredByNativeCode]
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[RequiredByNativeCode]
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

	internal static void InvokeTriggerInitialize(CustomRenderTexture crt) { }

	internal static void InvokeTriggerUpdate(CustomRenderTexture crt, int updateCount) { }

}

