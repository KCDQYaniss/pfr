namespace GPUInstancer;

public class PrefabsWithoutGameObjects : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <UpdateColors>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PrefabsWithoutGameObjects <>4__this; //Field offset: 0x20

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
		public <UpdateColors>d__20(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <UpdatePositions>d__18 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PrefabsWithoutGameObjects <>4__this; //Field offset: 0x20

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
		public <UpdatePositions>d__18(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <UpdateScale>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PrefabsWithoutGameObjects <>4__this; //Field offset: 0x20

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
		public <UpdateScale>d__19(int <>1__state) { }

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

	public GPUInstancerPrefabManager prefabManager; //Field offset: 0x20
	public GPUInstancerPrefab prefab; //Field offset: 0x28
	public int bufferSize; //Field offset: 0x30
	public Button addSphere; //Field offset: 0x38
	public Button removeSphere; //Field offset: 0x40
	public Button clearSphere; //Field offset: 0x48
	public Text sphereCountText; //Field offset: 0x50
	public Text positionUpdateFrequencyText; //Field offset: 0x58
	public Text scaleUpdateFrequencyText; //Field offset: 0x60
	public Text colorUpdateFrequencyText; //Field offset: 0x68
	private Matrix4x4[] _matrix4x4Array; //Field offset: 0x70
	private int sphereCount; //Field offset: 0x78
	private float positionUpdateFrequency; //Field offset: 0x7C
	private float scaleUpdateFrequency; //Field offset: 0x80
	private float colorUpdateFrequency; //Field offset: 0x84
	private Vector4[] variationData; //Field offset: 0x88
	private string bufferName; //Field offset: 0x90

	public PrefabsWithoutGameObjects() { }

	private void AddMatrix4x4ToArray(int instanceCount) { }

	public void AddSpheres() { }

	private void Awake() { }

	private void CheckButtonsAvailablity() { }

	public void ClearSpheres() { }

	private void RemoveMatrix4x4FromArray(int instanceCount) { }

	public void RemoveSpheres() { }

	public void SetColorUpdateFrequency(float updateInterval) { }

	public void SetPositionUpdateFrequency(float updateInterval) { }

	public void SetScaleUpdateFrequency(float updateInterval) { }

	[IteratorStateMachine(typeof(<UpdateColors>d__20))]
	private IEnumerator UpdateColors() { }

	[IteratorStateMachine(typeof(<UpdatePositions>d__18))]
	private IEnumerator UpdatePositions() { }

	[IteratorStateMachine(typeof(<UpdateScale>d__19))]
	private IEnumerator UpdateScale() { }

}

