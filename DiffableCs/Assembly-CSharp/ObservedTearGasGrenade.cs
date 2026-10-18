//Type is in global namespace

public class ObservedTearGasGrenade : TearGasGrenade
{

	protected virtual float PhysicsQuality
	{
		 get { } //Length: 66
	}

	public ObservedTearGasGrenade() { }

	protected virtual float get_PhysicsQuality() { }

	protected virtual ObjectVisibility GetVisibilityChecker() { }

	protected virtual void OnDoneFromNet() { }

	protected virtual void RemoveRigidBodyOnVelocityDrop() { }

}

