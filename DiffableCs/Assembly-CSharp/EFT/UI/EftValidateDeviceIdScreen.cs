namespace EFT.UI;

public sealed class EftValidateDeviceIdScreen : ValidateDeviceIdScreen
{
	internal sealed class EftValidateDeviceIdScreenControllerController : EftScreenController, IValidateDeviceIdScreenController
	{
		[CompilerGenerated]
		private Action OnValidateDeviceId; //Field offset: 0x58

		public override event Action OnValidateDeviceId
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

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public EftValidateDeviceIdScreenControllerController() { }

		[CompilerGenerated]
		public override void add_OnValidateDeviceId(Action value) { }

		public override void ErrorShow(string err) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public override void remove_OnValidateDeviceId(Action value) { }

		public override void ValidateDeviceId(string deviceId) { }

	}


	public EftValidateDeviceIdScreen() { }

}

