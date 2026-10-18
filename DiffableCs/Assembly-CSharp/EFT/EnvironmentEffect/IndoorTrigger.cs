namespace EFT.EnvironmentEffect;

public class IndoorTrigger : MonoBehaviour, IAABB
{
	private static int _cachedLayers; //Field offset: 0x0
	[SerializeField]
	public bool IsBunker; //Field offset: 0x20
	[SerializeField]
	public float FadeTime; //Field offset: 0x24
	[SerializeField]
	public float BunkerDepth; //Field offset: 0x28
	[SerializeField]
	public float BunkerLowPass; //Field offset: 0x2C
	[SerializeField]
	[Space(15)]
	public float ExposureSpeed; //Field offset: 0x30
	[SerializeField]
	public float ExposureOffset; //Field offset: 0x34
	[SerializeField]
	public float RainVolume; //Field offset: 0x38
	[SerializeField]
	public Bounds Bounds; //Field offset: 0x3C
	public int AreaAutoId; //Field offset: 0x54

	public IndoorTrigger() { }

	private void Awake() { }

	[CanBeNull]
	public override IndoorTrigger Check(Vector3 pos) { }

	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	private void OnValidate() { }

	public override void Reinit() { }

}

