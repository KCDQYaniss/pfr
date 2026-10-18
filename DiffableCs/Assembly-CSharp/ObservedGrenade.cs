//Type is in global namespace

public class ObservedGrenade : Grenade
{

	protected virtual float PhysicsQuality
	{
		 get { } //Length: 66
	}

	public ObservedGrenade() { }

	private void Expire() { }

	protected virtual float get_PhysicsQuality() { }

	protected virtual ObjectVisibility GetVisibilityChecker() { }

	protected virtual void OnDoneFromNet() { }

	protected virtual void ProcessContactExplodeCollision(float impulse) { }

	protected virtual void StartTimer() { }

}

