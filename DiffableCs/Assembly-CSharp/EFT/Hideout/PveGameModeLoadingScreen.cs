namespace EFT.Hideout;

public sealed class PveGameModeLoadingScreen : UIScreen
{
	private const string LOADING_STATE_NAME = "LoadingState"; //Field offset: 0x0
	private const string EMPTY_STATE_NAME = "EmptyState"; //Field offset: 0x0
	[SerializeField]
	private float _fadeDuration; //Field offset: 0x90
	[SerializeField]
	private CanvasGroup _logoGroup; //Field offset: 0x98
	[SerializeField]
	private Animator _screenAnimator; //Field offset: 0xA0
	private Sequence _loadingSequence; //Field offset: 0xA8

	public PveGameModeLoadingScreen() { }

	[CompilerGenerated]
	private void <LoadComplete>b__7_0() { }

	[CompilerGenerated]
	private void <Show>b__6_0() { }

	public void LoadComplete() { }

	public void Show() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

