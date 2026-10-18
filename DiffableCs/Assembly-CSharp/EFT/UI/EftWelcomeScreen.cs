namespace EFT.UI;

public sealed class EftWelcomeScreen : WelcomeScreen
{
	internal sealed class EftWelcomeScreenController : EftSequenceScreenController, IWelcomeScreenController
	{
		[CompilerGenerated]
		private readonly ILocalizationLoader <LocalizationLoader>k__BackingField; //Field offset: 0x60

		public override ILocalizationLoader LocalizationLoader
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public EftWelcomeScreenController(ILocalizationLoader localizationLoader) { }

		[CompilerGenerated]
		public override ILocalizationLoader get_LocalizationLoader() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

	}


	public EftWelcomeScreen() { }

}

