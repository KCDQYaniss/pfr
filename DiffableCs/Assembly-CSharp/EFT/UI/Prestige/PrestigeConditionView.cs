namespace EFT.UI.Prestige;

[UsedImplicitly]
public sealed class PrestigeConditionView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public PrestigeConditionCounterView counterView; //Field offset: 0x10
		public PrestigeConditionView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private PrestigeConditionCounterView _counterTemplate; //Field offset: 0x70
	[SerializeField]
	private Transform _counterContainer; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _conditionName; //Field offset: 0x80
	[SerializeField]
	private Image _background; //Field offset: 0x88
	[SerializeField]
	private Color _colorReady; //Field offset: 0x90
	[SerializeField]
	private Color _colorNotReady; //Field offset: 0xA0
	private readonly List _countersViews; //Field offset: 0xB0
	private readonly Queue _countersPool; //Field offset: 0xB8

	public PrestigeConditionView() { }

	private void CounterChangedHandler() { }

	public void Show(PrestigeLevel prestige, IEnumerable conditions) { }

}

