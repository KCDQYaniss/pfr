namespace Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineStoryboard.html")]
[SaveDuringPlay]
public class CinemachineStoryboard : CinemachineExtension
{
	[CompilerGenerated]
	private static class <>O
	{
		public static UnityAction <0>__StaticBlendingHandler; //Field offset: 0x0

	}

	private class CanvasInfo
	{
		public GameObject mCanvas; //Field offset: 0x10
		public Canvas mCanvasComponent; //Field offset: 0x18
		public CinemachineBrain mCanvasParent; //Field offset: 0x20
		public RectTransform mViewport; //Field offset: 0x28
		public RawImage mRawImage; //Field offset: 0x30

		public CanvasInfo() { }

	}

	internal enum FillStrategy
	{
		BestFit = 0,
		CropImageToFit = 1,
		StretchToFit = 2,
	}

	internal enum StoryboardRenderMode
	{
		ScreenSpaceOverlay = 0,
		ScreenSpaceCamera = 1,
	}

	[Tooltip("If checked, all storyboards are globally muted")]
	public static bool s_StoryboardGlobalMute; //Field offset: 0x0
	[Tooltip("If checked, the specified image will be displayed as an overlay over the virtual camera's output")]
	public bool m_ShowImage; //Field offset: 0x30
	[Tooltip("The image to display")]
	public Texture m_Image; //Field offset: 0x38
	[Tooltip("How to handle differences between image aspect and screen aspect")]
	public FillStrategy m_Aspect; //Field offset: 0x40
	[Range(0, 1)]
	[Tooltip("The opacity of the image.  0 is transparent, 1 is opaque")]
	public float m_Alpha; //Field offset: 0x44
	[Tooltip("The screen-space position at which to display the image.  Zero is center")]
	public Vector2 m_Center; //Field offset: 0x48
	[Tooltip("The screen-space rotation to apply to the image")]
	public Vector3 m_Rotation; //Field offset: 0x50
	[Tooltip("The screen-space scaling to apply to the image")]
	public Vector2 m_Scale; //Field offset: 0x5C
	[Tooltip("If checked, X and Y scale are synchronized")]
	public bool m_SyncScale; //Field offset: 0x64
	[Tooltip("If checked, Camera transform will not be controlled by this virtual camera")]
	public bool m_MuteCamera; //Field offset: 0x65
	[Range(-1, 1)]
	[Tooltip("Wipe the image on and off horizontally")]
	public float m_SplitView; //Field offset: 0x68
	[Tooltip("The render mode of the canvas on which the storyboard is drawn.")]
	public StoryboardRenderMode m_RenderMode; //Field offset: 0x6C
	[Tooltip("Allows ordering canvases to render on top or below other canvases.")]
	public int m_SortingOrder; //Field offset: 0x70
	[Tooltip("How far away from the camera is the Canvas generated.")]
	public float m_PlaneDistance; //Field offset: 0x74
	private List mCanvasInfo; //Field offset: 0x78

	private string CanvasName
	{
		private get { } //Length: 292
	}

	public CinemachineStoryboard() { }

	private void CameraUpdatedCallback(CinemachineBrain brain) { }

	protected virtual void ConnectToVcam(bool connect) { }

	private void CreateCanvas(CanvasInfo ci) { }

	private void DestroyCanvas() { }

	private string get_CanvasName() { }

	[RuntimeInitializeOnLoadMethod]
	private static void InitializeModule() { }

	private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound) { }

	private void PlaceImage(CanvasInfo ci, float alpha) { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	private static void StaticBlendingHandler(CinemachineBrain brain) { }

	private void UpdateRenderCanvas() { }

}

