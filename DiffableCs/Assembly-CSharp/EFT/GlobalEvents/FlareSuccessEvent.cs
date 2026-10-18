namespace EFT.GlobalEvents;

public class FlareSuccessEvent : BaseEvent
{
	private IPlayer _firedPlayer; //Field offset: 0x18
	private Vector3 _playerPosOnFiredFlare; //Field offset: 0x20
	private Vector3 _flarePosition; //Field offset: 0x2C
	private AmmoTemplate _ammoTemplate; //Field offset: 0x38

	public AmmoTemplate AmmoTemplate
	{
		 get { } //Length: 5
	}

	public IPlayer FiredPlayer
	{
		 get { } //Length: 5
	}

	public Vector3 PlayerPosOnFiredFlare
	{
		 get { } //Length: 19
	}

	public FlareSuccessEvent() { }

	public AmmoTemplate get_AmmoTemplate() { }

	public IPlayer get_FiredPlayer() { }

	public Vector3 get_PlayerPosOnFiredFlare() { }

	public void Invoke(IPlayer firedPlayer, Vector3 playerPosOnFiredFlare, Vector3 flarePosition, AmmoTemplate ammoTemplate) { }

	public virtual void Reset() { }

}

