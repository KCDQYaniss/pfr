namespace EFT.Interactive.Commands;

public class Command`1
{
	private float _scheduleTime; //Field offset: 0x0
	protected T DataValue; //Field offset: 0x0
	protected bool IsScheduled; //Field offset: 0x0

	public Command`1() { }

	protected bool Expired(float time, float lifeTime) { }

	public void Schedule(T data, float time) { }

}

