namespace EFT.NPC;

public class NPCFootStepsSoundPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CheckWalkCoroutine>d__8 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NPCFootStepsSoundPlayer <>4__this; //Field offset: 0x20

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
		public <CheckWalkCoroutine>d__8(int <>1__state) { }

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
	private Animator _npcAnimator; //Field offset: 0x20
	[SerializeField]
	private AudioSource _stepAudioSource; //Field offset: 0x28
	[SerializeField]
	private List _footstepClips; //Field offset: 0x30
	private bool _footStepPlayed; //Field offset: 0x38
	private Coroutine _checkWalkCoroutine; //Field offset: 0x40

	public NPCFootStepsSoundPlayer() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<CheckWalkCoroutine>d__8))]
	private IEnumerator CheckWalkCoroutine() { }

	private void OnDestroy() { }

	private void PlayStepSound() { }

}

