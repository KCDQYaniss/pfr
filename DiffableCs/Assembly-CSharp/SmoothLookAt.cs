//Type is in global namespace

public class SmoothLookAt : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <LookAtRotation>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SmoothLookAt <>4__this; //Field offset: 0x20
		private bool <rotationStarted>5__2; //Field offset: 0x28

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
		public <LookAtRotation>d__19(int <>1__state) { }

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
	private sealed class <ReturnToStartRotation>d__17 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SmoothLookAt <>4__this; //Field offset: 0x20
		private Quaternion <startRotation>5__2; //Field offset: 0x28
		private float <normalizedTime>5__3; //Field offset: 0x38

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
		public <ReturnToStartRotation>d__17(int <>1__state) { }

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
	private float _lerpToTargetRotationSpeed; //Field offset: 0x20
	[SerializeField]
	private float _angleDifForStartRotation; //Field offset: 0x24
	[SerializeField]
	private float _angleDifForStopRotation; //Field offset: 0x28
	[SerializeField]
	private bool _returnStartRotationOnEnd; //Field offset: 0x2C
	[SerializeField]
	private float _returnToStartRotationTime; //Field offset: 0x30
	private Transform _transformForRotation; //Field offset: 0x38
	private Transform _transformToLookAt; //Field offset: 0x40
	private Vector3 _realLookTargetDir; //Field offset: 0x48
	private Vector3 _lerpedLookTargetDir; //Field offset: 0x54
	private Coroutine _lookAtRotationCoroutine; //Field offset: 0x60
	private Coroutine _returnRotationCoroutine; //Field offset: 0x68
	private Quaternion _localRotationOnStart; //Field offset: 0x70

	public SmoothLookAt() { }

	public float GetTimeToLookAt() { }

	private void HardStopAllRotations() { }

	[IteratorStateMachine(typeof(<LookAtRotation>d__19))]
	private IEnumerator LookAtRotation() { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<ReturnToStartRotation>d__17))]
	private IEnumerator ReturnToStartRotation() { }

	public void SetTransformForRotation(Transform forRotation) { }

	public void SetTransformToLookAt(Transform toLookAt) { }

	public void ToggleWorking(bool enable) { }

}

