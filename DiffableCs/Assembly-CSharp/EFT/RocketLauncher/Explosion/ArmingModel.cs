namespace EFT.RocketLauncher.Explosion;

public class ArmingModel
{
	private float _armingTime; //Field offset: 0x10
	private bool _isArmed; //Field offset: 0x14
	private float _startTime; //Field offset: 0x18
	private float _timeToArmed; //Field offset: 0x1C

	public ArmingModel() { }

	public bool IsArmed() { }

	public void Start(float armingTime) { }

	public void Update() { }

}

