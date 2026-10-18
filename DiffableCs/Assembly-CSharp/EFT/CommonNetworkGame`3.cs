namespace EFT;

internal abstract class CommonNetworkGame`3 : NetworkGame
{
	protected TSession Session; //Field offset: 0x0

	protected CommonNetworkGame`3() { }

	protected static TNetworkGame Create(TSession session, ClientGameWorld gameWorld, ProfileStatus profileStatus, TRaidSettings raidSettings, Profile savageProfile, InsuranceCompany insurance, IInputTree inputTree, GameUI gameUI, ClientMetricsEvents metricsEvents, ClientMetricsCollector metricsCollector, EUpdateQueue updateQueue, TimeSpan sessionTime, Action runCallback, Callback callback) { }

}

