//Type is in global namespace

public class ObservedStunGrenade : StunGrenade
{

	protected virtual float PhysicsQuality
	{
		 get { } //Length: 66
	}

	public ObservedStunGrenade() { }

	protected virtual float get_PhysicsQuality() { }

	protected virtual ObjectVisibility GetVisibilityChecker() { }

	protected virtual void OnDoneFromNet() { }

	protected virtual void StartTimer() { }

	private void Suicide() { }

}

