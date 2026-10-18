namespace Cutscene;

public class CutsceneFakePlayerSteps : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <FakeFootStepsPlayingCoroutine>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CutsceneFakePlayerSteps <>4__this; //Field offset: 0x20
		private float <normalizedTime>5__2; //Field offset: 0x28

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
		public <FakeFootStepsPlayingCoroutine>d__8(int <>1__state) { }

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
	private float _timeBetweenSteps; //Field offset: 0x20
	[SerializeField]
	private int _maxStepsCount; //Field offset: 0x24
	private Coroutine _fakeFootStepsPlayingCoroutine; //Field offset: 0x28
	private Player _player; //Field offset: 0x30
	private int _currentStepsCount; //Field offset: 0x38

	public CutsceneFakePlayerSteps() { }

	[IteratorStateMachine(typeof(<FakeFootStepsPlayingCoroutine>d__8))]
	private IEnumerator FakeFootStepsPlayingCoroutine() { }

	private void OnDestroy() { }

	private void PlayFakeStepSound() { }

	public void ToggleFakeStepsSound(Player onPlayer, bool toggle) { }

}

