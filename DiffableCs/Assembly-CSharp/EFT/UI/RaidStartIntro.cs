namespace EFT.UI;

public sealed class RaidStartIntro : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public RaidStartIntro <>4__this; //Field offset: 0x10
		public string playerName; //Field offset: 0x18
		public string location; //Field offset: 0x20
		public Action <>9__3; //Field offset: 0x28
		public Action <>9__2; //Field offset: 0x30
		public Action <>9__1; //Field offset: 0x38

		public <>c__DisplayClass16_0() { }

		internal void <ShowIntro>b__0() { }

		internal void <ShowIntro>b__1() { }

		internal void <ShowIntro>b__2() { }

		internal void <ShowIntro>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <Co_SlowlyFade>d__18 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RaidStartIntro <>4__this; //Field offset: 0x20

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
		public <Co_SlowlyFade>d__18(int <>1__state) { }

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
	private sealed class <Co_StepByStep>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string to; //Field offset: 0x20
		public CustomTextMeshProUGUI label; //Field offset: 0x28
		private string <displayedString>5__2; //Field offset: 0x30
		private int <i>5__3; //Field offset: 0x38

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
		public <Co_StepByStep>d__19(int <>1__state) { }

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
	private sealed class <Co_StepByStepTime>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RaidStartIntro <>4__this; //Field offset: 0x20
		public CustomTextMeshProUGUI label; //Field offset: 0x28
		private string <displayedString>5__2; //Field offset: 0x30
		private int <i>5__3; //Field offset: 0x38

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
		public <Co_StepByStepTime>d__20(int <>1__state) { }

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

	private const float DISPLAY_INFO_DELAY = 0.3; //Field offset: 0x0
	private const float FADE_DELAY = 4; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _raidNumberLabel; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _dayLabel; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _nameLabel; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _locationLabel; //Field offset: 0x90
	private string _currentLocationTime; //Field offset: 0x98
	private DateTime _registrationDate; //Field offset: 0xA0
	private GameDateTime _locationTime; //Field offset: 0xA8
	private bool _registrationDateDisplayed; //Field offset: 0xB0
	private float _currentAlpha; //Field offset: 0xB4
	private float _alphaMultiplier; //Field offset: 0xB8

	public float AlphaMultiplier
	{
		 get { } //Length: 9
		 set { } //Length: 122
	}

	public RaidStartIntro() { }

	[IteratorStateMachine(typeof(<Co_SlowlyFade>d__18))]
	private IEnumerator Co_SlowlyFade() { }

	[IteratorStateMachine(typeof(<Co_StepByStep>d__19))]
	private IEnumerator Co_StepByStep(CustomTextMeshProUGUI label, string to) { }

	[IteratorStateMachine(typeof(<Co_StepByStepTime>d__20))]
	private IEnumerator Co_StepByStepTime(CustomTextMeshProUGUI label) { }

	public float get_AlphaMultiplier() { }

	private void Reset() { }

	public void set_AlphaMultiplier(float value) { }

	public void ShowIntro(long raidNumber, DateTime registrationDate, GameDateTime locationTime, EPlayerSide side, string playerName, string location) { }

	private void Update() { }

}

