namespace uLipSync;

public class uLipSyncAnimator : MonoBehaviour
{
	internal class AnimatorInfo
	{
		public string phoneme; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public int nameHash; //Field offset: 0x20
		public int index; //Field offset: 0x24
		public float maxWeight; //Field offset: 0x28
		[CompilerGenerated]
		private float <weight>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		private float <weightVelocity>k__BackingField; //Field offset: 0x30

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

		public AnimatorInfo() { }

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
	public Animator animator; //Field offset: 0x28
	public List parameters; //Field offset: 0x30
	public float minVolume; //Field offset: 0x38
	public float maxVolume; //Field offset: 0x3C
	[Range(0, 0.3)]
	public float smoothness; //Field offset: 0x40
	[Range(0.0001, 0.01)]
	public float minimalValueThreshold; //Field offset: 0x44
	private LipSyncInfo _info; //Field offset: 0x48
	private bool _lipSyncUpdated; //Field offset: 0x60
	private float _volume; //Field offset: 0x64
	private float _openCloseVelocity; //Field offset: 0x68

	protected float volume
	{
		 get { } //Length: 6
	}

	public uLipSyncAnimator() { }

	public void ApplyAnimator() { }

	private void Awake() { }

	private void FixedUpdate() { }

	protected float get_volume() { }

	private void LateUpdate() { }

	private void OnApplyAnimator() { }

	public void OnLipSyncUpdate(LipSyncInfo info) { }

	private float SmoothDamp(float value, float target, float threshold, ref float velocity) { }

	private void Update() { }

	private void UpdateLipSync() { }

	private void UpdateVolume() { }

	private void UpdateVowels() { }

}

