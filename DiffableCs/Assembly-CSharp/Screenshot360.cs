//Type is in global namespace

public class Screenshot360 : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SaveRenderedResult>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int counter; //Field offset: 0x20
		public Screenshot360[] comp360; //Field offset: 0x28

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
		public <SaveRenderedResult>d__8(int <>1__state) { }

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

	private class HiddenGO
	{
		public GameObject HiddenGameObject; //Field offset: 0x10
		public bool IsActive; //Field offset: 0x18

		public HiddenGO(GameObject obj) { }

		public void AfterScreenshot() { }

	}

	private static List _hiddenGOs; //Field offset: 0x0
	public string _saveToFilePath; //Field offset: 0x20
	private RenderTexture _renderTexture; //Field offset: 0x28
	private Camera _cam; //Field offset: 0x30

	private static Screenshot360() { }

	public Screenshot360() { }

	private static void AddHiddenObject(Type monoBehaviourType) { }

	private static void AddHiddenObject(GameObject go) { }

	private static Camera GetCamera() { }

	private static void HideUnneededObjects() { }

	public static void Make360Screenshot(int cubemapSize, bool alignToHorizon) { }

	public void ReadAndStoreResults() { }

	[IteratorStateMachine(typeof(<SaveRenderedResult>d__8))]
	private static IEnumerator SaveRenderedResult(Screenshot360[] comp360, int counter) { }

	public void Setup(int resolution, string saveToFile, Vector3 direction, Vector3 up, int cameraDepth, PrismEffects masterPrismEffect, PostProcessLayer ppLayer) { }

	private void SetupCameraPostEffects() { }

	private static void ShowPreviouslyHiddenObjects() { }

}

