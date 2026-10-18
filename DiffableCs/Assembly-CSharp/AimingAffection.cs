//Type is in global namespace

public class AimingAffection
{
	private Vector3 _affectionOffset; //Field offset: 0x10
	private float _curAffectionCoef; //Field offset: 0x1C
	private float _curDelationSec; //Field offset: 0x20
	private bool _damageaffection; //Field offset: 0x24
	private float _endAffectionTime; //Field offset: 0x28
	private readonly BotOwner _owner; //Field offset: 0x30

	public AimingAffection(BotOwner owner) { }

	public Vector3 Affect(Vector3 dir) { }

	private void CalcCurCoef() { }

	public void DoAffection() { }

}

