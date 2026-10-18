namespace EFT.Dialogs;

public sealed class DialogButtonsContainer : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__6_2(AreaData area) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public DialogButtonsContainer <>4__this; //Field offset: 0x10
		public DialogStartData dialogStartData; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	[SerializeField]
	private DefaultUIButton _visitTraderButton; //Field offset: 0x70
	[SerializeField]
	private DefaultUIButton _radioButton; //Field offset: 0x78
	[SerializeField]
	private DefaultUIButton _visitOnLocationButton; //Field offset: 0x80
	private readonly BindableEvent _onDialogButtonClicked; //Field offset: 0x88

	public IBindableEvent OnDialogButtonClicked
	{
		 get { } //Length: 8
	}

	public DialogButtonsContainer() { }

	private void DisableRadioButton(string message) { }

	public IBindableEvent get_OnDialogButtonClicked() { }

	public void Show(DialogStartData dialogStartData) { }

}

