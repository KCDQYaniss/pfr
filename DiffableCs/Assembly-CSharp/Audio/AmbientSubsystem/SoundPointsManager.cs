namespace Audio.AmbientSubsystem;

public class SoundPointsManager : MonoBehaviour
{
	[SerializeField]
	private SoundPoint[] _allSoundPoints; //Field offset: 0x20

	public SoundPointsManager() { }

	private void Awake() { }

	public void CollectPoints() { }

}

