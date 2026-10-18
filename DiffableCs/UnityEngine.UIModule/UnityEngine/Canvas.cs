namespace UnityEngine;

[NativeClass("UI::Canvas")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[RequireComponent(typeof(RectTransform))]
public sealed class Canvas : Behaviour
{
	internal sealed class WillRenderCanvases : MulticastDelegate
	{

		public WillRenderCanvases(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases preWillRenderCanvases; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action <externBeginRenderOverlays>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action <externRenderOverlaysBefore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action <externEndRenderOverlays>k__BackingField; //Field offset: 0x20

	public static event WillRenderCanvases preWillRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 266
		[CompilerGenerated]
		 remove { } //Length: 266
	}

	public static event WillRenderCanvases willRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 269
		[CompilerGenerated]
		 remove { } //Length: 269
	}

	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	internal static Action externBeginRenderOverlays
	{
		[CompilerGenerated]
		internal get { } //Length: 60
		[CompilerGenerated]
		internal set { } //Length: 151
	}

	internal static Action externEndRenderOverlays
	{
		[CompilerGenerated]
		internal get { } //Length: 60
		[CompilerGenerated]
		internal set { } //Length: 151
	}

	internal static Action externRenderOverlaysBefore
	{
		[CompilerGenerated]
		internal get { } //Length: 60
		[CompilerGenerated]
		internal set { } //Length: 151
	}

	public bool isRootCanvas
	{
		 get { } //Length: 78
	}

	public bool overrideSorting
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool pixelPerfect
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float planeDistance
	{
		 set { } //Length: 94
	}

	public float referencePixelsPerUnit
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public Vector2 renderingDisplaySize
	{
		 get { } //Length: 95
	}

	public RenderMode renderMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public int renderOrder
	{
		 get { } //Length: 78
	}

	public Canvas rootCanvas
	{
		 get { } //Length: 78
	}

	public float scaleFactor
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public int sortingLayerID
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public int sortingOrder
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public int targetDisplay
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public bool vertexColorAlwaysGammaSpace
	{
		 get { } //Length: 78
	}

	[NativeProperty("Camera", False, TargetType::Function (0))]
	public Camera worldCamera
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Canvas() { }

	[CompilerGenerated]
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	private static void EndRenderExtraOverlays(int displayIndex) { }

	public static void ForceUpdateCanvases() { }

	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	[CompilerGenerated]
	internal static Action get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	internal static Action get_externEndRenderOverlays() { }

	[CompilerGenerated]
	internal static Action get_externRenderOverlaysBefore() { }

	public bool get_isRootCanvas() { }

	public bool get_overrideSorting() { }

	public bool get_pixelPerfect() { }

	public float get_referencePixelsPerUnit() { }

	public Vector2 get_renderingDisplaySize() { }

	private void get_renderingDisplaySize_Injected(out Vector2 ret) { }

	public RenderMode get_renderMode() { }

	public int get_renderOrder() { }

	public Canvas get_rootCanvas() { }

	public float get_scaleFactor() { }

	public int get_sortingLayerID() { }

	public int get_sortingOrder() { }

	public int get_targetDisplay() { }

	public bool get_vertexColorAlwaysGammaSpace() { }

	public Camera get_worldCamera() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	public static Material GetETC1SupportedCanvasMaterial() { }

	[CompilerGenerated]
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	private static void SendWillRenderCanvases() { }

	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	[CompilerGenerated]
	internal static void set_externBeginRenderOverlays(Action value) { }

	[CompilerGenerated]
	internal static void set_externEndRenderOverlays(Action value) { }

	[CompilerGenerated]
	internal static void set_externRenderOverlaysBefore(Action value) { }

	public void set_overrideSorting(bool value) { }

	public void set_pixelPerfect(bool value) { }

	public void set_planeDistance(float value) { }

	public void set_referencePixelsPerUnit(float value) { }

	public void set_renderMode(RenderMode value) { }

	public void set_scaleFactor(float value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingOrder(int value) { }

	public void set_targetDisplay(int value) { }

	public void set_worldCamera(Camera value) { }

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	internal static void SetExternalCanvasEnabled(bool enabled) { }

}

