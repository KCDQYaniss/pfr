//Type is in global namespace

public class PeriodicCheck
{
	private Func _checkAct; //Field offset: 0x10
	private bool _lastCheck; //Field offset: 0x18
	private float _lastPeriod; //Field offset: 0x1C
	private float _period; //Field offset: 0x20

	public PeriodicCheck(Func checkAct, float period) { }

	public bool Check() { }

}

