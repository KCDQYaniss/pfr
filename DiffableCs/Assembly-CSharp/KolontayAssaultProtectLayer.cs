//Type is in global namespace

public class KolontayAssaultProtectLayer : FollowerKolontayFightProtectLayer
{
	private bool _protectingNow; //Field offset: 0xE8

	public KolontayAssaultProtectLayer(BotOwner bot, int priority) { }

	public virtual string Name() { }

	public void SetProtect(bool protectBoss) { }

	public virtual bool ShallUseNow() { }

}

