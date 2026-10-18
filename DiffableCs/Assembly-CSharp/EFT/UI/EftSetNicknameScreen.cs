namespace EFT.UI;

public sealed class EftSetNicknameScreen : SetNicknameScreen
{
	internal sealed class EftSetNicknameScreenController : EftSequenceScreenController, ISetNicknameScreenController
	{
		[CompilerGenerated]
		private Action OnNickNameSubmitted; //Field offset: 0x60
		[CompilerGenerated]
		private Action OnNicknameError; //Field offset: 0x68
		[CompilerGenerated]
		private readonly string <ReservedNickname>k__BackingField; //Field offset: 0x70

		public override event Action OnNicknameError
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		public override event Action OnNickNameSubmitted
		{
			[CompilerGenerated]
			 add { } //Length: 262
			[CompilerGenerated]
			 remove { } //Length: 262
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public override string ReservedNickname
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public EftSetNicknameScreenController(string reservedNickname) { }

		[CompilerGenerated]
		public override void add_OnNicknameError(Action value) { }

		[CompilerGenerated]
		public override void add_OnNickNameSubmitted(Action value) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public override string get_ReservedNickname() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public override void remove_OnNicknameError(Action value) { }

		[CompilerGenerated]
		public override void remove_OnNickNameSubmitted(Action value) { }

		public override void ShowNicknameError(ENicknameError error) { }

		public override void SubmitNickname(string nickname) { }

	}


	public EftSetNicknameScreen() { }

	private void Accept() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

