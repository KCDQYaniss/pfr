namespace EFT.CameraControl;

[ExecuteAlways]
public class OpticSight : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <FadeDecorLensRoutine>d__18 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float targetOpacity; //Field offset: 0x20
		public OpticSight <>4__this; //Field offset: 0x28
		private float <startTime>5__2; //Field offset: 0x30
		private float <delta>5__3; //Field offset: 0x34

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
		public <FadeDecorLensRoutine>d__18(int <>1__state) { }

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

	private static readonly int _switchToSightId; //Field offset: 0x0
	private float _decorLensOpacity; //Field offset: 0x20
	private Coroutine _fadeRoutine; //Field offset: 0x28
	public Renderer LensRenderer; //Field offset: 0x30
	public Renderer DecorLensRenderer; //Field offset: 0x38
	public Transform ScopeTransform; //Field offset: 0x40
	[SerializeField]
	public float DistanceToCamera; //Field offset: 0x48
	[SerializeField]
	public ScopeData ScopeData; //Field offset: 0x50
	[SerializeField]
	public float DecorLensFadeDuration; //Field offset: 0x58
	[SerializeField]
	public float DecorLensFadeMin; //Field offset: 0x5C
	[SerializeField]
	public float DecorLensFadeMax; //Field offset: 0x60
	[SerializeField]
	[Tooltip("ALARM! Consumes a lot of CPU!")]
	public bool IsThermalSightAvailableAt45Degrees; //Field offset: 0x64
	public IScopeCameraData CameraData; //Field offset: 0x68

	private static OpticSight() { }

	public OpticSight() { }

	public void Awake() { }

	[ContextMenu("Calc Distance")]
	public void CalcDistance() { }

	private void FadeDecorLens(float targetOpacity) { }

	[IteratorStateMachine(typeof(<FadeDecorLensRoutine>d__18))]
	private IEnumerator FadeDecorLensRoutine(float targetOpacity) { }

	public void LensFade(bool isHide = true) { }

	public void LookAt(Vector3 point, Vector3 worldUp) { }

	private void OnDisable() { }

	private void OnEnable() { }

}

