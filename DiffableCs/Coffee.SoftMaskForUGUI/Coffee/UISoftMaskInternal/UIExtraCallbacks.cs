namespace Coffee.UISoftMaskInternal;

internal static class UIExtraCallbacks
{
	[CompilerGenerated]
	private static class <>O
	{
		public static WillRenderCanvases <0>__OnAfterCanvasRebuild; //Field offset: 0x0

	}

	private static bool s_IsInitializedAfterCanvasRebuild; //Field offset: 0x0
	private static readonly FastAction s_AfterCanvasRebuildAction; //Field offset: 0x8
	private static readonly FastAction s_LateAfterCanvasRebuildAction; //Field offset: 0x10
	private static readonly FastAction s_BeforeCanvasRebuildAction; //Field offset: 0x18
	private static readonly FastAction s_OnScreenSizeChangedAction; //Field offset: 0x20
	private static Vector2Int s_LastScreenSize; //Field offset: 0x28

	public static event Action onAfterCanvasRebuild
	{
		 add { } //Length: 124
		 remove { } //Length: 124
	}

	public static event Action onBeforeCanvasRebuild
	{
		 add { } //Length: 124
		 remove { } //Length: 124
	}

	public static event Action onLateAfterCanvasRebuild
	{
		 add { } //Length: 124
		 remove { } //Length: 124
	}

	public static event Action onScreenSizeChanged
	{
		 add { } //Length: 124
		 remove { } //Length: 124
	}

	private static UIExtraCallbacks() { }

	public static void add_onAfterCanvasRebuild(Action value) { }

	public static void add_onBeforeCanvasRebuild(Action value) { }

	public static void add_onLateAfterCanvasRebuild(Action value) { }

	public static void add_onScreenSizeChanged(Action value) { }

	private static void InitializeAfterCanvasRebuild() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void InitializeOnLoad() { }

	private static void OnAfterCanvasRebuild() { }

	private static void OnBeforeCanvasRebuild() { }

	public static void remove_onAfterCanvasRebuild(Action value) { }

	public static void remove_onBeforeCanvasRebuild(Action value) { }

	public static void remove_onLateAfterCanvasRebuild(Action value) { }

	public static void remove_onScreenSizeChanged(Action value) { }

}

