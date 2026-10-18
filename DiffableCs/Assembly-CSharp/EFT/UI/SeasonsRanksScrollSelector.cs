namespace EFT.UI;

public class SeasonsRanksScrollSelector : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public SeasonsRanksScrollSelector <>4__this; //Field offset: 0x10
		public int index; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal void <DoSelectElement>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public RectTransform item; //Field offset: 0x10
		public SeasonsRanksScrollSelector <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_1
	{
		public float middleX; //Field offset: 0x10
		public float edgeDist; //Field offset: 0x14
		public Vector2 sizeDelta; //Field offset: 0x18
		public <>c__DisplayClass17_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass17_1() { }

		internal void <DoMoveItem>b__0() { }

	}

	[SerializeField]
	private SeasonsRanksScrollSelectorItem _viewTemplate; //Field offset: 0x70
	[SerializeField]
	private Transform _root; //Field offset: 0x78
	[SerializeField]
	private List _anchors; //Field offset: 0x80
	[SerializeField]
	private List _sprites; //Field offset: 0x88
	[SerializeField]
	private Vector2 _highlightSize; //Field offset: 0x90
	[SerializeField]
	private Vector2 _normalSize; //Field offset: 0x98
	[SerializeField]
	private AnimationCurve _sizeCurve; //Field offset: 0xA0
	[SerializeField]
	private float _tweenTime; //Field offset: 0xA8
	private List _instances; //Field offset: 0xB0
	private int _selectedIndex; //Field offset: 0xB8
	private int[] _itemPositions; //Field offset: 0xC0
	private Tween _activeTween; //Field offset: 0xC8

	private int MiddleTransformIndex
	{
		private get { } //Length: 75
	}

	public SeasonsRanksScrollSelector() { }

	private void Clear() { }

	private Tween DoMoveItem(int itemIndex, int delta) { }

	private void DoSelectElement(int index) { }

	private int get_MiddleTransformIndex() { }

	private void SelectElement(int index) { }

	public void Show(int selectedIndex) { }

}

