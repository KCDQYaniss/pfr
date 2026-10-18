namespace EFT.UI;

public class ItemOnGrid : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public ItemOnGrid <>4__this; //Field offset: 0x10
		public ItemIcon itemIcon; //Field offset: 0x18
		public bool examined; //Field offset: 0x20

		public <>c__DisplayClass1_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	protected Image Icon; //Field offset: 0x70

	public ItemOnGrid() { }

	public void Show(Item item, bool correctSize = true, bool examined = true) { }

}

