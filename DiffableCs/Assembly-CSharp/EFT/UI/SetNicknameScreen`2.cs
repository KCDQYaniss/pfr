namespace EFT.UI;

public abstract class SetNicknameScreen`2 : BaseScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public TController controller; //Field offset: 0x0
		public SetNicknameScreen <>4__this; //Field offset: 0x0

		public <>c__DisplayClass3_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	protected ValidationInputField _nicknameInput; //Field offset: 0x0
	[SerializeField]
	protected DefaultUIButton _nextButton; //Field offset: 0x0

	protected SetNicknameScreen`2() { }

	[CompilerGenerated]
	private void <Awake>b__2_0(ENicknameError error) { }

	private void Accept() { }

	private void Awake() { }

	public virtual void Close() { }

	protected void SetScreenAvailability(bool value) { }

	public virtual void Show(TController controller) { }

	private void Show(string reservedNickname) { }

	private void ShowError(ENicknameError error) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

