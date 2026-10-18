//Type is in global namespace

public class LightKeeperEyesBlinking : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <BlinkingCoroutine>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LightKeeperEyesBlinking <>4__this; //Field offset: 0x20
		private float <blinkTime>5__2; //Field offset: 0x28
		private float <normalizedTime>5__3; //Field offset: 0x2C
		private float <upLeftBlendShapeStartValue>5__4; //Field offset: 0x30
		private float <upRightBlendShapeStartValue>5__5; //Field offset: 0x34
		private float <leftEyeMulti>5__6; //Field offset: 0x38
		private float <rightEyeMulti>5__7; //Field offset: 0x3C
		private float <growingNormalizedTime>5__8; //Field offset: 0x40

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
		public <BlinkingCoroutine>d__15(int <>1__state) { }

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

	[SerializeField]
	private SkinnedMeshRenderer _headMesh; //Field offset: 0x20
	[SerializeField]
	private LightKeeperEyeTargetFollower _eyeTargetFollower; //Field offset: 0x28
	[SerializeField]
	private float minDelayBetweenBlinking; //Field offset: 0x30
	[SerializeField]
	private float maxDelayBetweenBlinking; //Field offset: 0x34
	[SerializeField]
	private float minBlinkTime; //Field offset: 0x38
	[SerializeField]
	private float maxBlinkTime; //Field offset: 0x3C
	[SerializeField]
	private float minTimeForClosedEyes; //Field offset: 0x40
	[SerializeField]
	private float maxTimeForClosedEyes; //Field offset: 0x44
	[SerializeField]
	private string leftEyeBlinkShape; //Field offset: 0x48
	[SerializeField]
	private string rightEyeBlinkShape; //Field offset: 0x50
	private Dictionary blendShapeNamesWithIDs; //Field offset: 0x58
	private Coroutine _blinkingCoroutine; //Field offset: 0x60
	private WaitForSeconds wfs; //Field offset: 0x68

	public LightKeeperEyesBlinking() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<BlinkingCoroutine>d__15))]
	private IEnumerator BlinkingCoroutine() { }

	private void OnDestroy() { }

}

