namespace EFT;

public sealed class SettingsScreenResolver
{
	private EGameState _currentGameState; //Field offset: 0x10
	private readonly IEftSession _session; //Field offset: 0x18

	public SettingsScreenResolver(IEftSession session) { }

	public void SetState(EGameState state) { }

	public void ShowScreen() { }

}

