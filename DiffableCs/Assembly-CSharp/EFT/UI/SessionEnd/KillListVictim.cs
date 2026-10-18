namespace EFT.UI.SessionEnd;

public sealed class KillListVictim : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Awake>b__17_0() { }

	}

	private const string HEADSHOT = "Headshot"; //Field offset: 0x0
	private const string REGULAR_KILL = "Killed"; //Field offset: 0x0
	private const string UNKNOWN_WEAPON = "Unknown weapon"; //Field offset: 0x0
	private const string PMC = "Pmc"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _number; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _locationName; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _timestamp; //Field offset: 0x80
	[SerializeField]
	private CustomTextMeshProUGUI _name; //Field offset: 0x88
	[SerializeField]
	private CustomTextMeshProUGUI _level; //Field offset: 0x90
	[SerializeField]
	private CustomTextMeshProUGUI _faction; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _status; //Field offset: 0xA0
	[SerializeField]
	private ComplementaryButton _showProfileButton; //Field offset: 0xA8
	[SerializeField]
	private ReportPanel _reportPanel; //Field offset: 0xB0
	[SerializeField]
	private GameObject _separator; //Field offset: 0xB8
	[SerializeField]
	private Color _pmcColor; //Field offset: 0xC0
	[SerializeField]
	private Color _scavColor; //Field offset: 0xD0
	private string _accountId; //Field offset: 0xE0

	public KillListVictim() { }

	private void Awake() { }

	public void Show(VictimStats victim, bool knownName, int number, IEftSession session) { }

	private void ShowPlayerProfile(bool _) { }

}

