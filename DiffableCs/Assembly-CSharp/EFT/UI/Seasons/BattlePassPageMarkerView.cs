namespace EFT.UI.Seasons;

public sealed class BattlePassPageMarkerView : UIElement
{
	internal enum EPageMarkerState
	{
		Previous = 0,
		Current = 1,
		Next = 2,
	}

	private readonly BindableEvent _onClick; //Field offset: 0x70
	[SerializeField]
	private Button _button; //Field offset: 0x78
	[SerializeField]
	private Dictionary _states; //Field offset: 0x80

	public IBindableEvent OnClick
	{
		 get { } //Length: 5
	}

	public BattlePassPageMarkerView() { }

	public IBindableEvent get_OnClick() { }

	public void SetSelectionState(EPageMarkerState state) { }

	public void Show() { }

}

