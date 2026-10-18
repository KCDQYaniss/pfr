//Type is in global namespace

public class KhorovodPosition
{
	[HideInInspector]
	public float angle; //Field offset: 0x10
	public BotOwner attachedOwner; //Field offset: 0x18
	public bool havePhrase; //Field offset: 0x20

	public KhorovodPosition() { }

	public Vector3 CalcPosition(float radius, float time) { }

}

