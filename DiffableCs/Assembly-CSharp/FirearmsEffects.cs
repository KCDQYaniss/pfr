//Type is in global namespace

public class FirearmsEffects : MonoBehaviour
{
	protected MuzzleManager _muzzleManager; //Field offset: 0x20
	private bool _muzzleActiveSavedState; //Field offset: 0x28

	public GameObject[] Jets
	{
		 get { } //Length: 262
	}

	public FirearmsEffects() { }

	public GameObject[] get_Jets() { }

	public void Init(Transform hierarchy) { }

	public void SetMuzzleActive(bool isActive) { }

	public void StartFireEffects(bool isVisible, float sqrCameraDistance) { }

	public void StartLauncherEffects() { }

	public void UpdateMuzzle() { }

}

