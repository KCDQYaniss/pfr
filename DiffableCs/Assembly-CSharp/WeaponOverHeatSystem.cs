//Type is in global namespace

[DefaultExecutionOrder(100)]
public class WeaponOverHeatSystem : ComponentSystem
{

	protected virtual bool HasLateUpdate
	{
		 get { } //Length: 3
	}

	protected virtual bool HasUpdate
	{
		 get { } //Length: 3
	}

	public WeaponOverHeatSystem() { }

	protected virtual bool get_HasLateUpdate() { }

	protected virtual bool get_HasUpdate() { }

	protected virtual void LateUpdate() { }

	protected virtual void LateUpdateComponent(WeaponPrefab component) { }

	protected virtual void UpdateComponent(WeaponPrefab component) { }

}

