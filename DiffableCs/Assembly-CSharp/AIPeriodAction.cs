//Type is in global namespace

public class AIPeriodAction
{
	private float _nextAction; //Field offset: 0x10
	private readonly float _preiod; //Field offset: 0x14
	private readonly Action _callback; //Field offset: 0x18

	public AIPeriodAction(float period, Action callback, bool withStep = false) { }

	public void ResetNextUpdate() { }

	public void Update() { }

}

