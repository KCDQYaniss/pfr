namespace EFT.UI;

public sealed class InteractionButton : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public AvailableInteractionState interaction; //Field offset: 0x10
		public InteractionAction action; //Field offset: 0x18
		public InteractionButton <>4__this; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal void <Show>b__0() { }

	}

	private static readonly Color SelectedColor; //Field offset: 0x0
	private static readonly Color DisabledColor; //Field offset: 0x10
	private static readonly Color NormalColor; //Field offset: 0x20
	[SerializeField]
	private CustomTextMeshProUGUI _text; //Field offset: 0x70
	[SerializeField]
	private Image _image; //Field offset: 0x78

	private static InteractionButton() { }

	public InteractionButton() { }

	public void Show(AvailableInteractionState interaction, InteractionAction action) { }

}

