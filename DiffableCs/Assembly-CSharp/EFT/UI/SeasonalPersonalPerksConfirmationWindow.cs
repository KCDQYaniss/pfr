namespace EFT.UI;

public sealed class SeasonalPersonalPerksConfirmationWindow : DialogWindow
{
	private const int SMALL_WINDOW_MAX_PERKS = 5; //Field offset: 0x0
	private const float SMALL_WINDOW_HEIGHT = 546; //Field offset: 0x0
	private const float LARGE_WINDOW_HEIGHT = 800; //Field offset: 0x0
	private const string POSITIVE_HEADER = "Perks/Season/Personal/Confirm/Positive{0}"; //Field offset: 0x0
	private const string NEGATIVE_HEADER = "Perks/Season/Personal/Confirm/Negative{0}"; //Field offset: 0x0
	private const string EMPTY_MESSAGE = "Perks/Season/Personal/Confirm/Empty"; //Field offset: 0x0
	private const string ACCEPT_BUTTON = "Perks/Season/Personal/Confirm/Accept"; //Field offset: 0x0
	private const string CANCEL_BUTTON = "Perks/Season/Personal/Confirm/Cancel"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0xD8
	[SerializeField]
	private GameObject _emptyState; //Field offset: 0xE0
	[SerializeField]
	private TextMeshProUGUI _emptyMessage; //Field offset: 0xE8
	[SerializeField]
	private GameObject _positiveGroup; //Field offset: 0xF0
	[SerializeField]
	private TextMeshProUGUI _positiveHeader; //Field offset: 0xF8
	[SerializeField]
	private Transform _positiveContainer; //Field offset: 0x100
	[SerializeField]
	private GameObject _negativeGroup; //Field offset: 0x108
	[SerializeField]
	private TextMeshProUGUI _negativeHeader; //Field offset: 0x110
	[SerializeField]
	private Transform _negativeContainer; //Field offset: 0x118
	[SerializeField]
	private SeasonalPersonalPerkConfirmationRow _rowTemplate; //Field offset: 0x120
	private UiElementPool _positiveRows; //Field offset: 0x128
	private UiElementPool _negativeRows; //Field offset: 0x130

	protected virtual bool DragEnabled
	{
		 get { } //Length: 3
	}

	public SeasonalPersonalPerksConfirmationWindow() { }

	public virtual void Close() { }

	protected virtual bool get_DragEnabled() { }

	private static void SetGroup(GameObject group, TextMeshProUGUI header, int count, string localizationKey) { }

	public DialogWindowContext Show(string title, string description, IReadOnlyCollection selectedPerks, IImageLoader imageLoader) { }

}

