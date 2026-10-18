namespace EFT.UI;

[UsedImplicitly]
public sealed class DialogPlayerLineView : UIElement
{
	[SerializeField]
	[UsedImplicitly]
	private Graphic _background; //Field offset: 0x70
	[SerializeField]
	[UsedImplicitly]
	private Button _button; //Field offset: 0x78
	[SerializeField]
	[UsedImplicitly]
	private TMP_Text _text; //Field offset: 0x80
	private readonly BindableEvent _onClick; //Field offset: 0x88

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	public DialogPlayerLineView() { }

	public IBindableEvent get_OnClick() { }

	public void Show(DialogLineTemplate line) { }

}

