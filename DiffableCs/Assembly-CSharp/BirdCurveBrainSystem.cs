//Type is in global namespace

public class BirdCurveBrainSystem : ComponentSystem
{

	protected virtual bool HasLateUpdate
	{
		 get { } //Length: 3
	}

	protected virtual bool HasUpdate
	{
		 get { } //Length: 3
	}

	public BirdCurveBrainSystem() { }

	protected virtual bool get_HasLateUpdate() { }

	protected virtual bool get_HasUpdate() { }

	protected virtual void LateUpdateComponent(BirdCurveBrain component) { }

	protected virtual void UpdateComponent(BirdCurveBrain component) { }

}

