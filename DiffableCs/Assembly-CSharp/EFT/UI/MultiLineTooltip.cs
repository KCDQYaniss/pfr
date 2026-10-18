namespace EFT.UI;

public sealed class MultiLineTooltip : Tooltip
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <CreateRows>b__6_0(MultiLineRow s) { }

	}

	[SerializeField]
	private MultiLineRow _multiLineRow; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _header; //Field offset: 0xB0
	[SerializeField]
	private Image _headerIcon; //Field offset: 0xB8
	private readonly List _rowsSpawned; //Field offset: 0xC0

	public MultiLineTooltip() { }

	private void CreateRows(int rowsNeededCount, List rowList) { }

	private void FillRows(SingleLineInfo[] singleLineInfo, List rowList) { }

	private void SetHeader(string header, Sprite icon) { }

	public void Show(MultiLineInfo multiLineInfo, Vector2 offset = null, Sprite headerSprite = null, Nullable headerColor = null, Nullable maxWidth = null) { }

}

