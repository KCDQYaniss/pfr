namespace EFT;

public class PlayerCameraFovChanger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <ChangeFovCoroutine>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerCameraFovChanger <>4__this; //Field offset: 0x20
		public float from; //Field offset: 0x28
		public float to; //Field offset: 0x2C
		private float <normalizedTime>5__2; //Field offset: 0x30

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
		public <ChangeFovCoroutine>d__9(int <>1__state) { }

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

	[Header("Use only two keys")]
	[SerializeField]
	private AnimationCurve _changeFovCurve; //Field offset: 0x20
	[SerializeField]
	private float _changingTime; //Field offset: 0x28
	private float _normalFov; //Field offset: 0x2C
	private Camera _targetCamera; //Field offset: 0x30
	private Coroutine _changeFovCoroutine; //Field offset: 0x38
	private readonly float MAGIC_MULTIPLIER_FOR_BETTER_EXPIRIENCE; //Field offset: 0x40

	public PlayerCameraFovChanger() { }

	public void ChangeFov(float targetFov, float changeTime) { }

	public void ChangeFov(float targetFov) { }

	[IteratorStateMachine(typeof(<ChangeFovCoroutine>d__9))]
	private IEnumerator ChangeFovCoroutine(float from, float to) { }

	private void OnDestroy() { }

	public void ReturnFov(float changeTime) { }

}

