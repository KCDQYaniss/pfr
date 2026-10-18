//Type is in global namespace

public class FloatingObjectManager : ComponentSystem
{

	protected virtual bool HasLateUpdate
	{
		 get { } //Length: 3
	}

	protected virtual bool HasUpdate
	{
		 get { } //Length: 3
	}

	public FloatingObjectManager() { }

	protected virtual bool get_HasLateUpdate() { }

	protected virtual bool get_HasUpdate() { }

	protected virtual void LateUpdateComponent(FloatingObject component) { }

	protected virtual void UpdateComponent(FloatingObject component) { }

}

