namespace EFT.UI;

public sealed class MasteringPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public MasteringPanel <>4__this; //Field offset: 0x10
		public KeyValuePair mastering; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private TextMeshProUGUI _level; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _name; //Field offset: 0x78
	[SerializeField]
	private TextMeshProUGUI _type; //Field offset: 0x80
	[SerializeField]
	private Image _initialProgressFill; //Field offset: 0x88
	[SerializeField]
	private MasteringIcon _masteringIcon; //Field offset: 0x90
	[SerializeField]
	private Sprite _masteringFillSprite; //Field offset: 0x98

	public MasteringPanel() { }

	public void Show(KeyValuePair mastering) { }

}

