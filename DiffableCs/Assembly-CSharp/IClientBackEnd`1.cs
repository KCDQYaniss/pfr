//Type is in global namespace

public interface IClientBackEnd`1 : IBackEnd, ILocalizationLoader
{

	public T Session
	{
		 get { } //Length: 0
	}

	public Task CreateClientSession() { }

	public Task Destroy() { }

	public void EnableDiagnostics(bool webDiagnosticsEnabled) { }

	public T get_Session() { }

	public Task GetAvailableLanguages() { }

	public Task GetCharacters() { }

	public Task GetExpansionsSettings() { }

	public Task GetGameMode(Nullable sessionMode) { }

	public Task GetLocalization(string locale) { }

	public Task GetMainMenuLocalization(string locale) { }

	public Task GetSeasonalPerks() { }

	public Task GetTemplates(ItemTemplates returnInCaseOfCache) { }

	public Task Login(string login, string password) { }

	public Task Logout() { }

	public Task RegenerateToken() { }

	public void RegisterDevice(string email, string activateCode, Callback onFinished) { }

	public Task ValidateVersion() { }

}

