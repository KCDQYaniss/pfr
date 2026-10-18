namespace EFT;

public class SpawnedWave
{
	public BotZone BotZone; //Field offset: 0x10
	public int Count; //Field offset: 0x18
	public BotCreationData Data; //Field offset: 0x20

	public SpawnedWave(BotZone botZone, int count, BotCreationData data) { }

}

