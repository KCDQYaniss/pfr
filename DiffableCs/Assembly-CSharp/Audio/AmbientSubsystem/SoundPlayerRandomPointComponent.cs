namespace Audio.AmbientSubsystem;

[RequireComponent(typeof(BaseAmbientSoundPlayer))]
public class SoundPlayerRandomPointComponent : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private List _worldSoundPoints; //Field offset: 0x20
	private BaseRandomAmbientSoundPlayer _randomPlayer; //Field offset: 0x28
	private readonly Dictionary _pointsByID; //Field offset: 0x30
	private readonly List _freePoints; //Field offset: 0x38
	private SoundPoint _currentPoint; //Field offset: 0x40

	public SoundPlayerRandomPointComponent() { }

	private void Awake() { }

	private void MoveToRandomPoint() { }

	private void OnDestroy() { }

	private void OnPointOccupied(int pointInstanceID) { }

	private void OnPointReleased(int pointInstanceID) { }

	private bool TryGetRandomPoint(out SoundPoint point) { }

	private void ValidatePoints() { }

}

