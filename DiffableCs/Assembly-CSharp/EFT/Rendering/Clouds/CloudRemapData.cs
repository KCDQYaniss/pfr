namespace EFT.Rendering.Clouds;

[CreateAssetMenu(menuName = "Settings/Clouds/Create Cloud Remap Data", fileName = "CloudRemapData", order = 99)]
public class CloudRemapData : ScriptableObject
{
	private struct Opacity
	{
		public AnimationCurve R; //Field offset: 0x0
		public AnimationCurve G; //Field offset: 0x8
		public AnimationCurve B; //Field offset: 0x10
		public AnimationCurve A; //Field offset: 0x18

	}

	[SerializeField]
	private Opacity Layer1; //Field offset: 0x18

	public CloudRemapData() { }

	[ContextMenu("Make Reset")]
	private void MakeReset() { }

	public CloudRemapRecord RemapCloudValue(float normalizedCloudiness) { }

	public void Reset() { }

	public void SetRemapCloudValue(float time, CloudRemapRecord record) { }

}

