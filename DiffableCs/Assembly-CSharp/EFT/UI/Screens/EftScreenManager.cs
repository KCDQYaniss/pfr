namespace EFT.UI.Screens;

public sealed class EftScreenManager : ScreenManager
{
	internal abstract class EftScreenController`2 : ScreenController
	{
		[CompilerGenerated]
		private static class <>O
		{
			public static Action <0>__SetIgnoreInput; //Field offset: 0x0

		}


		protected override EStateSwitcher CameraBlur
		{
			 get { } //Length: 6
		}

		protected override EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		protected override EStateSwitcher IgnorePlayerInput
		{
			 get { } //Length: 6
		}

		protected override bool MainEnvironment
		{
			 get { } //Length: 3
		}

		protected override EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		protected override bool RotateEnvironment
		{
			 get { } //Length: 3
		}

		protected override EShadingStateSwitcher ShadingType
		{
			 get { } //Length: 6
		}

		protected override EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 3
		}

		protected override EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 3
		}

		protected override string TaskBarButtonCustomTooltip
		{
			 get { } //Length: 3
		}

		protected override EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 3
		}

		protected override EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		protected EftScreenController`2() { }

		protected override EStateSwitcher get_CameraBlur() { }

		protected override EStateSwitcher get_EnvironmentOverlay() { }

		protected override EStateSwitcher get_IgnorePlayerInput() { }

		protected override bool get_MainEnvironment() { }

		protected override EStateSwitcher get_MenuChatBarVisibility() { }

		protected override bool get_RotateEnvironment() { }

		protected override EShadingStateSwitcher get_ShadingType() { }

		protected override EStateSwitcher get_ShowEnvironment() { }

		protected override EStateSwitcher get_ShowEnvironmentCamera() { }

		protected override string get_TaskBarButtonCustomTooltip() { }

		protected override EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected override EStateSwitcher get_UnrestrictedFrameRate() { }

		protected virtual void PrepareEnvironment() { }

		private void UpdateScreenFrameRate() { }

	}

	private static EftScreenManager _instance; //Field offset: 0x0
	private Action _openChatAction; //Field offset: 0x30

	protected virtual IBaseScreenController CurrentBaseScreenController
	{
		 set { } //Length: 342
	}

	public static EftScreenManager Instance
	{
		 get { } //Length: 238
	}

	private EftScreenManager() { }

	public static EftScreenManager get_Instance() { }

	public void InitChatScreen(Action openChatAction) { }

	public void OpenChatScreen() { }

	public void ReturnToSpecificScreen(EEftScreenType screenType) { }

	protected virtual void set_CurrentBaseScreenController(IBaseScreenController value) { }

}

