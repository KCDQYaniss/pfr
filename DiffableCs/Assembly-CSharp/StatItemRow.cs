//Type is in global namespace

public class StatItemRow : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <Set>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public StatItemRow <>4__this; //Field offset: 0x20
		public Sprite iconSprite; //Field offset: 0x28
		public MonoBehaviour monoContext; //Field offset: 0x30
		public string statValue; //Field offset: 0x38
		public string statName; //Field offset: 0x40

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
		public <Set>d__9(int <>1__state) { }

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

	private const float TEXT_ANIMATION_DURATION_BASE = 0.2; //Field offset: 0x0
	[SerializeField]
	private TMP_Text _statNameLabel; //Field offset: 0x20
	[SerializeField]
	private TMP_Text _statValueLabel; //Field offset: 0x28
	[SerializeField]
	private Image _statImage; //Field offset: 0x30
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x38

	private static float TextAnimationDuration
	{
		private get { } //Length: 9
	}

	public StatItemRow() { }

	[CompilerGenerated]
	private void <Set>b__9_0(string v) { }

	[CompilerGenerated]
	private void <Set>b__9_1(string v) { }

	private static float get_TextAnimationDuration() { }

	public void Prepare() { }

	[IteratorStateMachine(typeof(<Set>d__9))]
	public IEnumerator Set(string statName, string statValue, Sprite iconSprite, MonoBehaviour monoContext) { }

	public void SetVisible(bool isVisible) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

