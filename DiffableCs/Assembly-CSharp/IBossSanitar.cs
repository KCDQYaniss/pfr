//Type is in global namespace

public interface IBossSanitar
{

	public bool EnoughtHaveGoodCovers
	{
		 get { } //Length: 0
	}

	public Nullable PointForBoss
	{
		 get { } //Length: 0
	}

	public bool CanStartUseStimulator() { }

	public bool get_EnoughtHaveGoodCovers() { }

	public Nullable get_PointForBoss() { }

	public void SetFightPosition(bool b, BotOwner owner) { }

	public void SomebodyUseStimulator() { }

	public void WantAskHeal(BotOwner owner) { }

}

