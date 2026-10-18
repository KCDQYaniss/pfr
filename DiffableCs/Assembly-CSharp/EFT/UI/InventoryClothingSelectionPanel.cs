namespace EFT.UI;

[UsedImplicitly]
public class InventoryClothingSelectionPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public CustomizationSolver solver; //Field offset: 0x10
		public InventoryClothingSelectionPanel <>4__this; //Field offset: 0x18
		public List upperSuites; //Field offset: 0x20
		public CustomizationSuite selectedUpperSuite; //Field offset: 0x28
		public bool isInMatching; //Field offset: 0x30
		public List lowerSuites; //Field offset: 0x38
		public CustomizationSuite selectedLowerSuite; //Field offset: 0x40

		public <>c__DisplayClass4_0() { }

		internal string <Show>b__0(CustomizationSuite x) { }

		internal void <Show>b__1() { }

	}

	[SerializeField]
	private InventoryCustomizationSelector _lowerSelector; //Field offset: 0x70
	[SerializeField]
	private InventoryCustomizationSelector _upperSelector; //Field offset: 0x78
	private bool _dontCloseSelectorsForThisPress; //Field offset: 0x80
	private Action _onSuiteSelected; //Field offset: 0x88

	public InventoryClothingSelectionPanel() { }

	public virtual void Close() { }

	public void Show(List upperSuites, CustomizationSuite selectedUpperSuite, List lowerSuites, CustomizationSuite selectedLowerSuite, bool isInMatching, Action onSuiteSelected) { }

	private void Update() { }

}

