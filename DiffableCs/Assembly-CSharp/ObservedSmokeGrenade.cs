//Type is in global namespace

public class ObservedSmokeGrenade : SmokeGrenade
{

	protected virtual float PhysicsQuality
	{
		 get { } //Length: 66
	}

	public ObservedSmokeGrenade() { }

	protected virtual float get_PhysicsQuality() { }

	protected virtual ObjectVisibility GetVisibilityChecker() { }

	protected virtual void OnDoneFromNet() { }

	protected virtual void RemoveRigidBodyOnVelocityDrop(Throwable grenade) { }

}

