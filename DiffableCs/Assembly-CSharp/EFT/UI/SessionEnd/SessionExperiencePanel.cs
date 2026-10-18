namespace EFT.UI.SessionEnd;

public class SessionExperiencePanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <AnimateExperience>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SessionExperiencePanel <>4__this; //Field offset: 0x20
		public int target; //Field offset: 0x28
		public Profile profile; //Field offset: 0x30
		private float <startTime>5__2; //Field offset: 0x38

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
		public <AnimateExperience>d__6(int <>1__state) { }

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

	private const float ANIMATION_DURATION = 4; //Field offset: 0x0
	[SerializeField]
	private PlayerExperiencePanel _playerExperiencePanel; //Field offset: 0x20
	private int _baseTotal; //Field offset: 0x28
	private float _currentValue; //Field offset: 0x2C
	private Coroutine _animationCoroutine; //Field offset: 0x30

	public SessionExperiencePanel() { }

	[IteratorStateMachine(typeof(<AnimateExperience>d__6))]
	private IEnumerator AnimateExperience(Profile profile, int target) { }

	public void Set(Profile profile, int baseExperience, int newExperience) { }

}

