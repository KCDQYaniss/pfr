//Type is in global namespace

public class SanitarBotRandomPlanItemDropper : BotRandomPlanItemDropper
{
	private const string IFAK_ID_TO_DROP = "590c678286f77426c9660122"; //Field offset: 0x0

	public SanitarBotRandomPlanItemDropper(BotOwner owner) { }

	protected virtual Item FindItemToDropToBot() { }

	private Item FindMedsToDropToBot() { }

}

