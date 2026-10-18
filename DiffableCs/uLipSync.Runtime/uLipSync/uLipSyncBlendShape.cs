namespace uLipSync;

[ExecuteAlways]
public class uLipSyncBlendShape : AnimationBakableMonoBehaviour
{
	internal class BlendShapeInfo
	{
		public string phoneme; //Field offset: 0x10
		public int index; //Field offset: 0x18
		public float maxWeight; //Field offset: 0x1C
		[CompilerGenerated]
		private float <weight>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private float <weightVelocity>k__BackingField; //Field offset: 0x24

		public float weight
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public float weightVelocity
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public BlendShapeInfo() { }

		[CompilerGenerated]
		public float get_weight() { }

		[CompilerGenerated]
		public float get_weightVelocity() { }

		[CompilerGenerated]
		public void set_weight(float value) { }

		[CompilerGenerated]
		public void set_weightVelocity(float value) { }

	}

	public UpdateMethod updateMethod; //Field offset: 0x20
	public SkinnedMeshRenderer skinnedMeshRenderer; //Field offset: 0x28
	public List blendShapes; //Field offset: 0x30
	public float maxBlendShapeValue; //Field offset: 0x38
	public float minVolume; //Field offset: 0x3C
	public float maxVolume; //Field offset: 0x40
	[Range(0, 0.3)]
	public float smoothness; //Field offset: 0x44
	public bool usePhonemeBlend; //Field offset: 0x48
	private LipSyncInfo _info; //Field offset: 0x50
	private bool _lipSyncUpdated; //Field offset: 0x68
	private float _volume; //Field offset: 0x6C
	private float _openCloseVelocity; //Field offset: 0x70

	protected float volume
	{
		 get { } //Length: 6
	}

	public uLipSyncBlendShape() { }

	public BlendShapeInfo AddBlendShape(string phoneme, string blendShape) { }

	public void ApplyBlendShapes() { }

	private void FixedUpdate() { }

	protected float get_volume() { }

	public BlendShapeInfo GetBlendShapeInfo(string phoneme) { }

	private void LateUpdate() { }

	protected override void OnApplyBlendShapes() { }

	public void OnLipSyncUpdate(LipSyncInfo info) { }

	private float SmoothDamp(float value, float target, ref float velocity) { }

	private void Update() { }

	private void UpdateLipSync() { }

	private void UpdateVolume() { }

	private void UpdateVowels() { }

}

