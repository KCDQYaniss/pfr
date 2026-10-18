namespace EFT.UI;

public sealed class EftLoginScreen : LoginScreen
{
	internal sealed class EftLoginScreenController : EftScreenController, ILoginScreenController
	{
		[CompilerGenerated]
		private Action OnLogin; //Field offset: 0x58
		[CompilerGenerated]
		private Action OnRestore; //Field offset: 0x60
		[CompilerGenerated]
		private string <Login>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private string <Password>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private bool <SavePassword>k__BackingField; //Field offset: 0x78

		public override event Action OnLogin
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override event Action OnRestore
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public override string Login
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		protected virtual bool MainEnvironment
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public override string Password
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public override QueueScreen QueueScreen
		{
			 get { } //Length: 69
		}

		public override bool SavePassword
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public EftLoginScreenController(string login, string password, bool savePassword) { }

		[CompilerGenerated]
		public override void add_OnLogin(Action value) { }

		[CompilerGenerated]
		public override void add_OnRestore(Action value) { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		[CompilerGenerated]
		public override string get_Login() { }

		protected virtual bool get_MainEnvironment() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public override string get_Password() { }

		public override QueueScreen get_QueueScreen() { }

		[CompilerGenerated]
		public override bool get_SavePassword() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		public override void LogIn(string login, string password, bool savePassword, Action onError) { }

		[CompilerGenerated]
		public override void remove_OnLogin(Action value) { }

		[CompilerGenerated]
		public override void remove_OnRestore(Action value) { }

		internal void Restore() { }

		[CompilerGenerated]
		public void set_Login(string value) { }

		[CompilerGenerated]
		public void set_Password(string value) { }

		[CompilerGenerated]
		public void set_SavePassword(bool value) { }

		public override void SetNextButtonStatus(bool active) { }

	}


	public EftLoginScreen() { }

}

