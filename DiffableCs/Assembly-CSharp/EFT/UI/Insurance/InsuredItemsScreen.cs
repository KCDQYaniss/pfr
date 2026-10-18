namespace EFT.UI.Insurance;

public class InsuredItemsScreen : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__5_0(InsuredItem item, InsuredItemPanel view) { }

	}

	[SerializeField]
	private TextMeshProUGUI _insuredItemsCount; //Field offset: 0x70
	[SerializeField]
	private InsuredItemPanel _insuredItemPanel; //Field offset: 0x78
	[SerializeField]
	private RectTransform _insuredItemsContainer; //Field offset: 0x80
	private BindableViewList _viewList; //Field offset: 0x88
	private InsuranceCompany _insurance; //Field offset: 0x90

	public InsuredItemsScreen() { }

	private void SetInsuredItemsCountLabel() { }

	public void Show(InsuranceCompany insurance) { }

}

