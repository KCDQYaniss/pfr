namespace EFT.UI.Screens;

public sealed class PostFXPreviewScreen : UIScreen
{
	[SerializeField]
	private PostFXSettingsTab _postFXTab; //Field offset: 0x90
	[SerializeField]
	private DefaultUIButton _applyButton; //Field offset: 0x98
	private IBaseScreenController _screenController; //Field offset: 0xA0
	private PostFxSettingsController _controller; //Field offset: 0xA8

	public PostFXPreviewScreen() { }

	[CompilerGenerated]
	private void <Show>b__5_0() { }

	private void Apply() { }

	private void Awake() { }

	public virtual void Close() { }

	private void ReturnToMenu() { }

	private void ScreenChangedHandler(EEftScreenType screenType) { }

	public void Show(SettingsScreenController settingsController) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

