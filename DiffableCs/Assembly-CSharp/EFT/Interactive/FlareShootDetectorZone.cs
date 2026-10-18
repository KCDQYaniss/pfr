namespace EFT.Interactive;

public class FlareShootDetectorZone : MonoBehaviour
{
	[SerializeField]
	private string zoneID; //Field offset: 0x20
	[SerializeField]
	private FlareEventType flareTypeForHandle; //Field offset: 0x28
	[SerializeField]
	private List _triggerHandlers; //Field offset: 0x30
	private HashSet _shotPlayerProfiles; //Field offset: 0x38
	private Action _unsubscribeOnDestroy; //Field offset: 0x40

	public FlareShootDetectorZone() { }

	[CompilerGenerated]
	private void <Awake>b__5_0(FlareSuccessEvent flareEvent) { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnFlareEventRaised(FlareSuccessEvent flareEvent) { }

	private void OnTriggerEnterHandler(Collider collider) { }

	private void OnTriggerExitHandler(Collider collider) { }

}

