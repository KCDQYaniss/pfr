namespace uLipSync;

[BurstCompile]
[CreateAssetMenu(menuName = "uLipSync/Baked Data")]
public class BakedData : ScriptableObject
{
	public static Color[] phonemeColors; //Field offset: 0x0
	public Profile profile; //Field offset: 0x18
	public AudioClip audioClip; //Field offset: 0x20
	[HideInInspector]
	public Profile bakedProfile; //Field offset: 0x28
	[HideInInspector]
	public AudioClip bakedAudioClip; //Field offset: 0x30
	public float duration; //Field offset: 0x38
	public List frames; //Field offset: 0x40

	public override bool isDataChanged
	{
		 get { } //Length: 512
	}

	public bool isValid
	{
		 get { } //Length: 90
	}

	private static BakedData() { }

	public BakedData() { }

	public override bool get_isDataChanged() { }

	public bool get_isValid() { }

	public BakedFrame GetFrame(float t) { }

	public LipSyncInfo GetLipSyncInfo(float t) { }

	public static LipSyncInfo GetLipSyncInfo(BakedFrame frame) { }

}

