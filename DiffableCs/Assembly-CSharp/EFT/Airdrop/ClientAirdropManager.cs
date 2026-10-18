namespace EFT.Airdrop;

public class ClientAirdropManager : AirdropManager, IDisposable
{
	private const string AIRPLANE_DELAY_MESSAGE = "AirplaneDelayMessage"; //Field offset: 0x0
	private ProjectilesCollector _projectilesCollector; //Field offset: 0x40
	private int _nextAirdropTimeRemaining; //Field offset: 0x48
	private int _nextAirdropFlareRemaining; //Field offset: 0x4C

	public ClientAirdropManager() { }

	public virtual void AddProjectile(GameObject projectile, float expiredTime) { }

	public virtual void Dispose() { }

	public virtual void Init(bool enableAirdrops) { }

	public virtual void ManualUpdate(float deltaTime) { }

	public virtual void OnFlareSuccessEvent(bool canSendAirdrop) { }

}

