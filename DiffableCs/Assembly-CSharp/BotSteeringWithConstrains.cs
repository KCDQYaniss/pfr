//Type is in global namespace

public class BotSteeringWithConstrains : BotSteering
{

	public BotSteeringWithConstrains(BotOwner owner) { }

	protected virtual bool CanSteerToMovingDirection() { }

	protected virtual void SetXAngle(float degPerSec) { }

}

