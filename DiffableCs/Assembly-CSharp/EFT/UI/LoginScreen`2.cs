namespace EFT.UI;

public abstract class LoginScreen`2 : BaseScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__12_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__12_0() { }

	}

	[SerializeField]
	private QueueScreen _queuePanel; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProInputField _loginInput; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProInputField _passwordInput; //Field offset: 0x0
	[SerializeField]
	private Toggle _passwordToggle; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _errorLabel; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _nextButton; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _exitButton; //Field offset: 0x0
	[SerializeField]
	private GameObject _blockPanel; //Field offset: 0x0
	private string _password; //Field offset: 0x0
	private bool _canProceed; //Field offset: 0x0

	public QueueScreen QueueScreen
	{
		 get { } //Length: 8
	}

	protected LoginScreen`2() { }

	private void Awake() { }

	public QueueScreen get_QueueScreen() { }

	private static string GetDateTimeFromUnixStamp(double unix) { }

	private void LoginWithParametersFromInspector(string login, string password) { }

	private void Next() { }

	private void SetBlockStatus(bool value) { }

	public void SetNextButtonStatus(bool status) { }

	public virtual void Show(TController controller) { }

	private void Show(string login, string password, bool saveToggle) { }

	private void ShowError(string err, double banTime) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

