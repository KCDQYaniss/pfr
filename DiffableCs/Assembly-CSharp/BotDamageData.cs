//Type is in global namespace

public class BotDamageData
{
	public float TimeDamage; //Field offset: 0x10
	public bool IsAI; //Field offset: 0x14
	public Vector3 Postion; //Field offset: 0x18

	public BotDamageData(Vector3 postion, bool isAi) { }

	public bool IsActive() { }

}

