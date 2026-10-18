namespace EFT;

public class HalloweenVisualContainer : MonoBehaviour
{
	[SerializeField]
	private CultistSignEffect _sign; //Field offset: 0x20
	[SerializeField]
	private LightPillarEffect _pillar; //Field offset: 0x28

	public HalloweenVisualContainer() { }

	public void Initialize(Vector3 ritualPosition = null) { }

	public void SwitchLight(bool value) { }

	public void SwitchSight(bool value) { }

}

