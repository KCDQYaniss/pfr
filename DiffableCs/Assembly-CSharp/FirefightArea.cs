//Type is in global namespace

[DisallowMultipleComponent]
public class FirefightArea : MonoBehaviour
{
	[Min(0)]
	public float Radius; //Field offset: 0x20
	[Range(0, 1)]
	public float LocalDensity; //Field offset: 0x24
	public FirefightAreaAudioPreset AudioPreset; //Field offset: 0x28
	public bool UseSector; //Field offset: 0x30
	[Range(0, 360)]
	public float SectorApertureDeg; //Field offset: 0x34
	public Vector2 ForwardOffsetPercentRange; //Field offset: 0x38
	private Transform _cachedTransform; //Field offset: 0x40

	public Vector3 Position
	{
		 get { } //Length: 138
	}

	public FirefightArea() { }

	private void Awake() { }

	public Vector3 get_Position() { }

	private void OnDestroy() { }

}

