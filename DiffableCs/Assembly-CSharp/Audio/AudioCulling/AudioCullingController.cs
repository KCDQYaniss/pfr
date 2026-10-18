namespace Audio.AudioCulling;

public class AudioCullingController : IAudioCullingController, IDisposable
{
	[CompilerGenerated]
	private sealed class <Work>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AudioCullingController <>4__this; //Field offset: 0x20
		private int <updatedCount>5__2; //Field offset: 0x28
		private int <i>5__3; //Field offset: 0x2C

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
		public <Work>d__10(int <>1__state) { }

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

	private readonly int _maxUpdatePerFrame; //Field offset: 0x10
	private readonly float _sqrCullDistanceOffset; //Field offset: 0x14
	private readonly Transform _listenerTransform; //Field offset: 0x18
	private readonly List _cullingObjects; //Field offset: 0x20
	private Coroutine _workCoroutine; //Field offset: 0x28
	private bool _isWorking; //Field offset: 0x30

	public AudioCullingController(Transform listenerTransform, int maxUpdatePerFrame = 10, float cullDistanceOffset = 25) { }

	public override void Dispose() { }

	public override void Register(IAudioCullingObject cullingObject) { }

	private void StartWorkCoroutine() { }

	private void StopWorkCoroutine() { }

	public override void Unregister(IAudioCullingObject cullingObject) { }

	[IteratorStateMachine(typeof(<Work>d__10))]
	private IEnumerator Work() { }

}

