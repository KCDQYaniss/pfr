namespace UI.Hideout;

public sealed class HideoutCustomizationSimpleOptionsPanel : HideoutCustomizationOptionsPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public HideoutCustomizationGlobalOffer offer; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <CreateCellsGrid>b__0(HideoutCustomizationItem i) { }

		internal bool <CreateCellsGrid>b__1(HideoutCustomizationItem i) { }

	}


	public HideoutCustomizationSimpleOptionsPanel() { }

	private void CreateCellsGrid(IEnumerable globalOffers, MongoID selectedItemId, IEnumerable availableCustomizations) { }

	protected virtual void OnCellSelected(HideoutCustomizationCell selectedCell) { }

	public void Show(EHideoutCustomizationType customizationType, MongoID selectedItemId, IEnumerable globalOffers, HideoutCustomizationIcons icons, IEnumerable availableCustomizations, Action slotClickHandler) { }

}

