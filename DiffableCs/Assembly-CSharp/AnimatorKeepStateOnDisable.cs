//Type is in global namespace

[RequireComponent(typeof(Animator))]
public sealed class AnimatorKeepStateOnDisable : MonoBehaviour
{
	[SerializeField]
	private bool _keepStateOnDisable; //Field offset: 0x20

	public AnimatorKeepStateOnDisable() { }

	private void Awake() { }

}

