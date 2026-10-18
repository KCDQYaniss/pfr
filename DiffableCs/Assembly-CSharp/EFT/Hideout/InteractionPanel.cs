namespace EFT.Hideout;

public sealed class InteractionPanel : AbstractPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ItemsProducerBase producer; //Field offset: 0x10
		public InteractionPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <ShowContents>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public InteractionAction action; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <InitButton>b__0() { }

	}

	[SerializeField]
	private DefaultUIButton _interactionButtonTemplate; //Field offset: 0xA8
	[SerializeField]
	private RectTransform _interactionButtonsContainer; //Field offset: 0xB0
	[SerializeField]
	private Dictionary _additionalInfo; //Field offset: 0xB8
	private ViewList _viewList; //Field offset: 0xC0

	public InteractionPanel() { }

	[CompilerGenerated]
	private DefaultUIButton <ShowContents>b__4_0(InteractionAction template) { }

	[CompilerGenerated]
	private Transform <ShowContents>b__4_1(InteractionAction container) { }

	private void InitButton(InteractionAction action, DefaultUIButton button) { }

	private void OnProductionComplete(ItemsProducerBase _, Item[] items, ProducingItemController producingItem) { }

	public virtual void SetInfo() { }

	public virtual Task ShowContents() { }

}

