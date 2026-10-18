namespace FastAnimatorSystem.TestAnimatorEnvironment;

public class TestAnimatorSkeleton : MonoBehaviour
{
	public Animator animator; //Field offset: 0x20
	public RuntimeAnimatorController originalAnimatorController; //Field offset: 0x28
	public TextAsset fastAnimatorJson; //Field offset: 0x30
	public RootMotionBlendTable blendTable; //Field offset: 0x38
	public CharacterClipsKeeper clipsKeeper; //Field offset: 0x40
	public Camera cam; //Field offset: 0x48
	public PlayableAnimator playableAnimator; //Field offset: 0x50
	public bool useFastAnimator; //Field offset: 0x58
	public bool usePlayableWithFast; //Field offset: 0x59
	public float speedMult; //Field offset: 0x5C
	public Vector3 rotateAroundVec; //Field offset: 0x60
	public bool applyDeltaPosition; //Field offset: 0x6C
	public bool isVisible; //Field offset: 0x6D
	private Vector3 _lastDelta; //Field offset: 0x70
	private IAnimator _animator; //Field offset: 0x80
	private int _prevState; //Field offset: 0x88

	public IAnimator Animator
	{
		 get { } //Length: 8
	}

	public Vector3 LastDelta
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public TestAnimatorSkeleton() { }

	public IAnimator get_Animator() { }

	public Vector3 get_LastDelta() { }

	public AnimatorStateInfoWrapper GetCurrentState() { }

	public Vector3 GetDeltaPosition() { }

	public AnimatorStateInfoWrapper GetNextState() { }

	public void Init() { }

	private void PlaySoundBank(string val) { }

	public void Process(float dt) { }

	public void set_LastDelta(Vector3 value) { }

}

