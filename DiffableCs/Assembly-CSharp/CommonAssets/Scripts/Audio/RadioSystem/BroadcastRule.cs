namespace CommonAssets.Scripts.Audio.RadioSystem;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/BroadcastRule", fileName = "BroadcastRule")]
public class BroadcastRule : ScriptableObject
{
	internal class CrossfadeDurationByType : SerializableEnumDictionary
	{

		public CrossfadeDurationByType() { }

	}

	public int broadcastItemsCount; //Field offset: 0x18
	public Vector2 tracksBeforeJingle; //Field offset: 0x1C
	public Vector2 adsAfterTracks; //Field offset: 0x24
	public Vector2 showAfterTracks; //Field offset: 0x2C
	public Vector2 showsCount; //Field offset: 0x34
	public bool includeShow; //Field offset: 0x3C
	public bool restartBroadcastAfterFinished; //Field offset: 0x3D
	[SerializeField]
	private CrossfadeDurationByType _crossFadeDurationByType; //Field offset: 0x40

	public BroadcastRule() { }

	public float GetCrossfadeDuration(EBroadcastItemType type) { }

}

