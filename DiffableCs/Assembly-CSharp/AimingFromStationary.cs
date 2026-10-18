//Type is in global namespace

public class AimingFromStationary : Aiming
{
	private AnimationCurve _curveYAim; //Field offset: 0x38

	public AimingFromStationary(BotOwner bot) { }

	protected virtual Nullable GetTarget() { }

}

