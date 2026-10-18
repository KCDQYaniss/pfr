namespace EFT.Visual;

public class FlickerSystem : ComponentSystem
{

	protected virtual bool HasLateUpdate
	{
		 get { } //Length: 3
	}

	protected virtual bool HasUpdate
	{
		 get { } //Length: 3
	}

	public FlickerSystem() { }

	protected virtual bool get_HasLateUpdate() { }

	protected virtual bool get_HasUpdate() { }

	protected virtual void LateUpdateComponent(Flicker component) { }

	protected virtual void UpdateComponent(Flicker component) { }

}

