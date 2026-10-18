namespace UnityEngine.Rendering;

public static class RenderPipelineManager
{
	internal static RenderPipelineAsset s_CurrentPipelineAsset; //Field offset: 0x0
	private static List s_Cameras; //Field offset: 0x8
	private static string s_CurrentPipelineType; //Field offset: 0x10
	private static RenderPipeline s_CurrentPipeline; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action beginFrameRendering; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action endFrameRendering; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action beginCameraRendering; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action endCameraRendering; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineTypeChanged; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineAssetChanged; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineCreated; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action activeRenderPipelineDisposed; //Field offset: 0x58

	public static event Action beginCameraRendering
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public static event Action beginFrameRendering
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public static event Action endCameraRendering
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public static event Action endFrameRendering
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	public private static RenderPipeline currentPipeline
	{
		 get { } //Length: 84
		private set { } //Length: 393
	}

	private static RenderPipelineManager() { }

	[CompilerGenerated]
	public static void add_beginCameraRendering(Action value) { }

	[CompilerGenerated]
	public static void add_beginFrameRendering(Action value) { }

	[CompilerGenerated]
	public static void add_endCameraRendering(Action value) { }

	[CompilerGenerated]
	public static void add_endFrameRendering(Action value) { }

	[RequiredByNativeCode]
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, Object renderRequest) { }

	public static RenderPipeline get_currentPipeline() { }

	[RequiredByNativeCode]
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	private static bool IsPipelineRequireCreation() { }

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	internal static void OnActiveRenderPipelineTypeChanged() { }

	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	[CompilerGenerated]
	public static void remove_beginCameraRendering(Action value) { }

	[CompilerGenerated]
	public static void remove_beginFrameRendering(Action value) { }

	[CompilerGenerated]
	public static void remove_endCameraRendering(Action value) { }

	[CompilerGenerated]
	public static void remove_endFrameRendering(Action value) { }

	private static void set_currentPipeline(RenderPipeline value) { }

}

