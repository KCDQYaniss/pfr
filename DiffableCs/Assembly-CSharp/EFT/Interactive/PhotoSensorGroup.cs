namespace EFT.Interactive;

public class PhotoSensorGroup : MonoBehaviour
{
	public float SunHeihgtThreshold; //Field offset: 0x20
	public Turnable[] Items; //Field offset: 0x28
	private bool _on; //Field offset: 0x30

	public PhotoSensorGroup() { }

	private void Awake() { }

	private void Update() { }

}

