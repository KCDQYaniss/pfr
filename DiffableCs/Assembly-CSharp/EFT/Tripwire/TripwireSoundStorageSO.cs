namespace EFT.Tripwire;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/TripwireSoundStorage", fileName = "TripwireSoundStorage")]
public class TripwireSoundStorageSO : ScriptableObject
{
	[SerializeField]
	private SurfaceSoundContainers _plantingSounds; //Field offset: 0x18
	[Header("Tripwire Interactions")]
	[SerializeField]
	[Space]
	private AudioSingleClipContainer _tripwireGrenadeDefuseLoop; //Field offset: 0x20
	[SerializeField]
	private AudioSingleClipContainer _tripwireGrenadeDefuseEnd; //Field offset: 0x28
	[SerializeField]
	private AudioSingleClipContainer _tripwireGrenadePin; //Field offset: 0x30
	[SerializeField]
	private AudioMultipleClipContainer _defuseGrenadeCollisionSound; //Field offset: 0x38
	[Header("Fuze Settings")]
	[SerializeField]
	[Space]
	private AudioMultipleClipContainer _grenadeFuze; //Field offset: 0x40
	[Range(0, 5)]
	[SerializeField]
	private float _fuzeDelaySec; //Field offset: 0x48

	public float FuzeDelaySeconds
	{
		 get { } //Length: 6
	}

	public TripwireSoundStorageSO() { }

	public float get_FuzeDelaySeconds() { }

	public IAudioClipContainer GetDefuseCollisionSound() { }

	public IAudioClipContainer GetDefuseEndSound() { }

	public IAudioClipContainer GetDefuseLoopSound() { }

	public IAudioClipContainer GetFuzeSound() { }

	public IAudioClipContainer GetGrenadePinSound() { }

	public bool TryGetPlantSound(ESurfaceSound materialType, out IAudioClipContainer clipContainer) { }

}

