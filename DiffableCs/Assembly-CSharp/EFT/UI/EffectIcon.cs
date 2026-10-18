namespace EFT.UI;

public class EffectIcon : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_VariationBuffs>b__12_0(SimpleBuffDescription x) { }

	}

	[CompilerGenerated]
	private sealed class <Co_Blinking>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public EffectIcon <>4__this; //Field offset: 0x20
		public bool direction; //Field offset: 0x28
		private Color <color>5__2; //Field offset: 0x2C

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
		public <Co_Blinking>d__20(int <>1__state) { }

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
	private sealed class <Co_UpdateTooltip>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public EffectIcon <>4__this; //Field offset: 0x20

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
		public <Co_UpdateTooltip>d__19(int <>1__state) { }

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

	private const float TICK = 0.5; //Field offset: 0x0
	[SerializeField]
	private Image _icon; //Field offset: 0x70
	private DateTime _lastResponse; //Field offset: 0x78
	private SimpleTooltip _tooltip; //Field offset: 0x80
	private float _secondsLeft; //Field offset: 0x88
	private bool _blinking; //Field offset: 0x8C
	private EffectDescription _variation; //Field offset: 0x90
	private List _variationBuffs; //Field offset: 0x98
	private HoverTrigger _hoverTrigger; //Field offset: 0xA0
	private Coroutine _blinkingCoroutine; //Field offset: 0xA8
	private Coroutine _tooltipUpdateCoroutine; //Field offset: 0xB0

	private string VariationBuffs
	{
		private get { } //Length: 844
	}

	public EffectIcon() { }

	[CompilerGenerated]
	private void <Awake>b__13_0(PointerEventData arg) { }

	[CompilerGenerated]
	private void <Awake>b__13_1(PointerEventData _) { }

	[CompilerGenerated]
	private string <get_VariationBuffs>b__12_1(SimpleBuffDescription x) { }

	private void Awake() { }

	public void BuffsUpdatedHandler() { }

	public virtual void Close() { }

	[IteratorStateMachine(typeof(<Co_Blinking>d__20))]
	private IEnumerator Co_Blinking(bool direction) { }

	[IteratorStateMachine(typeof(<Co_UpdateTooltip>d__19))]
	private IEnumerator Co_UpdateTooltip() { }

	private string get_VariationBuffs() { }

	private void OnDestroy() { }

	public void Show(EffectDescription variation, SimpleTooltip tooltip, bool blinking) { }

	private bool TryOverrideFrostbiteIcon(Type type, out Sprite icon) { }

	private void Update() { }

}

