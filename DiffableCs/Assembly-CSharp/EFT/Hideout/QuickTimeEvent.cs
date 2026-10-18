namespace EFT.Hideout;

public class QuickTimeEvent
{
	public EQteType Type; //Field offset: 0x10
	public Vector2 Position; //Field offset: 0x14
	public float StartDelay; //Field offset: 0x1C
	public float EndDelay; //Field offset: 0x20
	public float Speed; //Field offset: 0x24
	public Vector2 SuccessRange; //Field offset: 0x28
	public KeyCode Key; //Field offset: 0x30

	public QuickTimeEvent() { }

	public QuickTimeEvent(EQteType type, Vector2 position, float speed, float startDelay, float endDelay, Vector2 successRange, KeyCode key) { }

}

