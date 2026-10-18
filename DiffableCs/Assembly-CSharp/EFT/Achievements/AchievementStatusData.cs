namespace EFT.Achievements;

public sealed class AchievementStatusData
{
	public string TemplateId; //Field offset: 0x10
	public int UnlockDate; //Field offset: 0x18
	public float GlobalProgressPercent; //Field offset: 0x1C
	public EQuestStatus Status; //Field offset: 0x20

	public AchievementStatusData() { }

	public AchievementStatusData(string tid, int unlockDate, float globalProgressPercent, EQuestStatus status = 2) { }

}

