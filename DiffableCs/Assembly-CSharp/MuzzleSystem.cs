//Type is in global namespace

public class MuzzleSystem : ComponentSystem
{
	private Camera _cam; //Field offset: 0x30

	protected virtual bool HasLateUpdate
	{
		 get { } //Length: 3
	}

	protected virtual bool HasUpdate
	{
		 get { } //Length: 3
	}

	public MuzzleSystem() { }

	protected virtual bool get_HasLateUpdate() { }

	protected virtual bool get_HasUpdate() { }

	protected virtual void LateUpdate() { }

	protected virtual void LateUpdateComponent(MuzzleManager component) { }

	protected virtual void UpdateComponent(MuzzleManager component) { }

}

