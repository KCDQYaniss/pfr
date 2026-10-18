//Type is in global namespace

public class LevelPhysicsSettings : MonoBehaviour
{
	private const int _maxSubdivision = 16; //Field offset: 0x0
	private static LevelPhysicsSettings _used; //Field offset: 0x0
	[SerializeField]
	private Bounds _mbpBounds; //Field offset: 0x20
	[Range(1, 16)]
	[SerializeField]
	private int _mbpSubdivisions; //Field offset: 0x38

	public LevelPhysicsSettings() { }

	private void ApplySettings() { }

	private void Awake() { }

	public Bounds GetGlobalBounds() { }

	private void OnDestroy() { }

}

