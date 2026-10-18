namespace EFT.UI;

public sealed class CutsceneScreen : EftScreen
{
	internal sealed class CutsceneScreenController : EftScreenController
	{

		protected virtual EStateSwitcher CameraBlur
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher IgnorePlayerInput
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		public CutsceneScreenController() { }

		protected virtual EStateSwitcher get_CameraBlur() { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		protected virtual EStateSwitcher get_IgnorePlayerInput() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

		public void PlaySubtitles(IEnumerable ccData, Func passedTime = null) { }

		public void StopSubtitles() { }

	}


	public CutsceneScreen() { }

	private void PlaySubtitles(IEnumerable data, Func passedTime = null) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public virtual void Show(CutsceneScreenController controller) { }

	private void StopSubtitles() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

