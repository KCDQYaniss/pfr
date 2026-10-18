//Type is in global namespace

[ExecuteInEditMode]
public class ScreenshotCreator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CaptureCutout>d__37 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ScreenshotCreator <>4__this; //Field offset: 0x20
		public int id; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CaptureCutout>d__37(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class CameraObject
	{
		internal enum Hotkey
		{
			Hotkey = 0,
			A = 1,
			B = 2,
			C = 3,
			D = 4,
			E = 5,
			F = 6,
			G = 7,
			H = 8,
			I = 9,
			J = 10,
			K = 11,
			L = 12,
			M = 13,
			N = 14,
			O = 15,
			P = 16,
			Q = 17,
			R = 18,
			S = 19,
			T = 20,
			U = 21,
			V = 22,
			W = 23,
			X = 24,
			Y = 25,
			Z = 26,
		}

		public GameObject cam; //Field offset: 0x10
		public bool deleteQuestion; //Field offset: 0x18
		public Hotkey hotkey; //Field offset: 0x1C

		public CameraObject() { }

	}

	internal enum CaptureMethod
	{
		CaptureScreenshot = 0,
		RenderTexture = 1,
		Cutout = 2,
	}

	internal enum FileType
	{
		PNG = 0,
		JPG = 1,
	}

	[HideInInspector]
	public Color signatureColor; //Field offset: 0x20
	public List list; //Field offset: 0x30
	[HideInInspector]
	public bool foldoutSettings; //Field offset: 0x38
	[Tooltip("The name of your screenshot or screenshot session. Camera name and current date will be added automatically.")]
	public string customName; //Field offset: 0x40
	public string customDirectory; //Field offset: 0x48
	[HideInInspector]
	public int lastCamID; //Field offset: 0x50
	[HideInInspector]
	public Camera lastCam; //Field offset: 0x58
	public bool includeCamName; //Field offset: 0x60
	public bool includeDate; //Field offset: 0x61
	public bool includeResolution; //Field offset: 0x62
	public FileType fileType; //Field offset: 0x64
	public CaptureMethod captureMethod; //Field offset: 0x68
	public bool singleCamera; //Field offset: 0x6C
	public float renderSizeMultiplier; //Field offset: 0x70
	public int captureSizeMultiplier; //Field offset: 0x74
	public Vector2 cutoutPosition; //Field offset: 0x78
	public Vector2 cutoutSize; //Field offset: 0x80
	private GUIStyle cutoutBoxStyle; //Field offset: 0x88
	public bool applicationPath; //Field offset: 0x90
	private Vector2 lastP; //Field offset: 0x94
	private Vector2 lastS; //Field offset: 0x9C
	private float timer; //Field offset: 0xA4

	public ScreenshotCreator() { }

	private void activateCameraID(int id) { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<CaptureCutout>d__37))]
	public IEnumerator CaptureCutout(int id) { }

	public void CaptureCutoutVoid(int id) { }

	public void CaptureRenderTexture(Camera attachedCam, int id) { }

	public void CaptureScreenshots(int id, bool fallback) { }

	private string checkSaveDirectory() { }

	private void clampCutoutBox() { }

	public void Create() { }

	private void cutoutEmptyCheck() { }

	public void Delete(int id) { }

	public string getFileName(int camID) { }

	public string getResolution() { }

	public string getSaveDirectory() { }

	private void initCutoutBoxStyle() { }

	private void LateUpdate() { }

	private void OnGUI() { }

	public void RequestDelete(int id) { }

}

