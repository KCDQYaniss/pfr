namespace EFT.UI.Settings;

public sealed class SettingsTooltip : Tooltip
{
	[CompilerGenerated]
	private sealed class <<Display>g__RebuildLayoutNextFrame|13_0>d : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SettingsTooltip <>4__this; //Field offset: 0x20

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
		public <<Display>g__RebuildLayoutNextFrame|13_0>d(int <>1__state) { }

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
	private CanvasGroup _canvas; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _titleLabel; //Field offset: 0xB0
	[SerializeField]
	private TMP_Text _textLabel; //Field offset: 0xB8
	[SerializeField]
	private GameObject _usageRoot; //Field offset: 0xC0
	[SerializeField]
	private TMP_Text _usageTextLabel; //Field offset: 0xC8
	[SerializeField]
	private Image _cpuImage; //Field offset: 0xD0
	[SerializeField]
	private Image _gpuImage; //Field offset: 0xD8
	[SerializeField]
	private Image _ramImage; //Field offset: 0xE0
	[SerializeField]
	private Color _green; //Field offset: 0xE8
	[SerializeField]
	private Color _orange; //Field offset: 0xF8
	[SerializeField]
	private Color _red; //Field offset: 0x108
	private readonly Vector2 _offset; //Field offset: 0x118

	public SettingsTooltip() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<Display>g__RebuildLayoutNextFrame|13_0>d))]
	private IEnumerator <Display>g__RebuildLayoutNextFrame|13_0() { }

	public virtual void Display() { }

	private Color GetUsageColor(EUsageStyle style) { }

	private void SetOptionData(SettingsTooltipData data) { }

	public void Show(SettingsTooltipData data) { }

	private void ValidateUsageProperty(Image image, bool active, Color color) { }

}

