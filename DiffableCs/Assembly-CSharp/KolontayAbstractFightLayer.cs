//Type is in global namespace

public abstract class KolontayAbstractFightLayer : BaseLogicLayer
{
	protected float TRY_SEARCH_COVER_PERIOD; //Field offset: 0x90
	protected float _notFoundCoverTime; //Field offset: 0x94
	protected float _blockTunUntil; //Field offset: 0x98

	protected KolontayAbstractFightLayer(BotOwner bot, int priority) { }

	protected bool CoverNotFound() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected AICoreActionResult HoldOrCoverRunKolontay() { }

	protected AICoreActionResult ShootOrDogFight(string info) { }

}

