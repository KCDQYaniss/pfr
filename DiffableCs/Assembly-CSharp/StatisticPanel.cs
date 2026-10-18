//Type is in global namespace

public class StatisticPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public FinalStatsArgs args; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <SetEditionIcon>b__0(IconsData t) { }

	}

	[CompilerGenerated]
	private sealed class <TypeText>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action setter; //Field offset: 0x20
		public float duration; //Field offset: 0x28
		public string text; //Field offset: 0x30
		private float <elapsedTime>5__2; //Field offset: 0x38
		private int <textLength>5__3; //Field offset: 0x3C
		private int <charsShown>5__4; //Field offset: 0x40

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
		public <TypeText>d__14(int <>1__state) { }

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
	private sealed class <TypeTextBySymbol>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action setter; //Field offset: 0x20
		public string text; //Field offset: 0x28
		public Nullable customSecDelay; //Field offset: 0x30
		private int <textLength>5__2; //Field offset: 0x38
		private int <charsShown>5__3; //Field offset: 0x3C

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
		public <TypeTextBySymbol>d__15(int <>1__state) { }

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
	private Image _finalImage; //Field offset: 0x20
	[SerializeField]
	private TMP_Text _finalHeader; //Field offset: 0x28
	[SerializeField]
	private TMP_Text _finalCaption; //Field offset: 0x30
	[SerializeField]
	private TMP_Text _endingAchieved; //Field offset: 0x38
	[SerializeField]
	private TMP_Text _userName; //Field offset: 0x40
	[SerializeField]
	private Image _userSideIcon; //Field offset: 0x48
	[SerializeField]
	private Image _userEditionIcon; //Field offset: 0x50
	[SerializeField]
	private float _animDuration; //Field offset: 0x58
	[SerializeField]
	private Sprite _usecSprite; //Field offset: 0x60
	[SerializeField]
	private Sprite _bearSprite; //Field offset: 0x68
	[SerializeField]
	private ChatSpecialIconSettings _iconsSettings; //Field offset: 0x70

	public StatisticPanel() { }

	[CompilerGenerated]
	private void <FillAnimated>b__13_0(string val) { }

	[CompilerGenerated]
	private void <FillAnimated>b__13_1(string val) { }

	[CompilerGenerated]
	private void <FillAnimated>b__13_2(string val) { }

	[CompilerGenerated]
	private void <FillAnimated>b__13_3(string val) { }

	public void Fill(FinalStatsArgs args) { }

	public void FillAnimated(FinalStatsArgs args) { }

	private void SetEditionIcon(FinalStatsArgs args) { }

	[IteratorStateMachine(typeof(<TypeText>d__14))]
	public static IEnumerator TypeText(string text, float duration, Action setter) { }

	[IteratorStateMachine(typeof(<TypeTextBySymbol>d__15))]
	public static IEnumerator TypeTextBySymbol(string text, Action setter, Nullable customSecDelay = null) { }

}

