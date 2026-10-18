namespace EFT.UI;

public sealed class StatGroupView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__5_0(StatInfo statItem, StatItemView statItemView) { }

	}

	[SerializeField]
	private GameObject _headerGameObject; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _caption; //Field offset: 0x78
	[SerializeField]
	private Image _icon; //Field offset: 0x80
	[SerializeField]
	private Transform _itemsContainer; //Field offset: 0x88
	[SerializeField]
	private StatItemView _statItemViewTemplate; //Field offset: 0x90

	public StatGroupView() { }

	public void Show(StatGroup statGroup) { }

}

