namespace FastAnimatorSystem.TestAnimatorEnvironment;

public class TestWeaponAnimatorSkeleton : MonoBehaviour
{
	public TextAsset fastAnimatorJson; //Field offset: 0x20
	private IAnimator _animator; //Field offset: 0x28

	public IAnimator Animator
	{
		 get { } //Length: 5
	}

	public TestWeaponAnimatorSkeleton() { }

	public IAnimator get_Animator() { }

	public void Start() { }

	private void Update() { }

}

