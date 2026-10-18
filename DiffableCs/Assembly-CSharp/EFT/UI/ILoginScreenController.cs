namespace EFT.UI;

public interface ILoginScreenController
{

	public event Action OnLogin
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnRestore
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string Login
	{
		 get { } //Length: 0
	}

	public string Password
	{
		 get { } //Length: 0
	}

	public QueueScreen QueueScreen
	{
		 get { } //Length: 0
	}

	public bool SavePassword
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnLogin(Action value) { }

	[CompilerGenerated]
	public void add_OnRestore(Action value) { }

	public string get_Login() { }

	public string get_Password() { }

	public QueueScreen get_QueueScreen() { }

	public bool get_SavePassword() { }

	public void LogIn(string login, string password, bool savePassword, Action onError) { }

	[CompilerGenerated]
	public void remove_OnLogin(Action value) { }

	[CompilerGenerated]
	public void remove_OnRestore(Action value) { }

	public void SetNextButtonStatus(bool active) { }

	public void ShowScreen(EScreenState state) { }

}

