namespace EFT.UI;

public class SearchButton : Button
{
	private const string SEARCHING_TEXT = "SEARCHING..."; //Field offset: 0x0
	private const string SEARCH_TEXT = "SEARCH"; //Field offset: 0x0
	[SerializeField]
	private TMP_Text _buttonCaption; //Field offset: 0x108
	[SerializeField]
	private GameObject _loader; //Field offset: 0x110
	[SerializeField]
	private GameObject _searchIcon; //Field offset: 0x118
	[SerializeField]
	private Button _stopSearchButton; //Field offset: 0x120
	private bool _isSearching; //Field offset: 0x128
	private readonly BindableEvent _onSearchStatusChanged; //Field offset: 0x130

	public BindableEvent OnSearchStatusChanged
	{
		 get { } //Length: 8
	}

	public SearchButton() { }

	[CompilerGenerated]
	private void <Awake>b__10_0() { }

	[CompilerGenerated]
	private void <Awake>b__10_1() { }

	protected virtual void Awake() { }

	public void Close() { }

	public BindableEvent get_OnSearchStatusChanged() { }

	public void SetEnabled(bool value) { }

	public void SetSearchStatus(bool active, bool changeButtonEnabling = true) { }

	public void Show() { }

}

