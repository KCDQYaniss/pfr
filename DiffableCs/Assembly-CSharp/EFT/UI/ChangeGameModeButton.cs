namespace EFT.UI;

public sealed class ChangeGameModeButton : HeroActionButton
{
	[SerializeField]
	private readonly Dictionary _stateData; //Field offset: 0x160

	protected virtual Dictionary StateData
	{
		 get { } //Length: 8
	}

	public ChangeGameModeButton() { }

	private void ApplyPmcSprites(EGameMode sessionMode) { }

	protected virtual Dictionary get_StateData() { }

	public void Show(EGameMode sessionMode) { }

}

