namespace Audio.AmbientSubsystem.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/SeasonSurfaceSetContainer", fileName = "SeasonSurfaceSetContainer")]
public class SeasonSurfaceSetContainer : SoundContainerBase
{
	internal class SeasonMovementSounds : SerializableEnumDictionary
	{

		public SeasonMovementSounds() { }

	}

	[SerializeField]
	private SeasonMovementSounds SeasonPlayerMovementSounds; //Field offset: 0x18

	public SeasonSurfaceSetContainer() { }

	public virtual bool TryGetContent(ESeasonStatus soundType, out SurfaceSet set) { }

}

