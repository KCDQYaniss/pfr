namespace EFT.StreamingAnimatorSystem;

[RequireComponent(typeof(Animator))]
public class StreamingAnimator : MonoBehaviour, IStreamingAnimator
{
	[HideInInspector]
	public List StreamingParameters; //Field offset: 0x20
	[SerializeField]
	private Animator _recipientAnimator; //Field offset: 0x28
	[SerializeField]
	private IAnimator _donorAnimator; //Field offset: 0x30
	private float _cachedTime; //Field offset: 0x38
	private Nullable _cachedStateInfo; //Field offset: 0x3C
	private HashSet _streamingParamsHashset; //Field offset: 0x68

	public override IEventBehaviour[] EventBehaviours
	{
		 get { } //Length: 248
	}

	public RuntimeAnimatorController RecipientController
	{
		 get { } //Length: 90
	}

	public AnimatorControllerParameter[] RecipientParameters
	{
		 get { } //Length: 90
	}

	public StreamingAnimator() { }

	private bool CanSetParam(int hash) { }

	public override void ClearData() { }

	public override IEventBehaviour[] get_EventBehaviours() { }

	public RuntimeAnimatorController get_RecipientController() { }

	public AnimatorControllerParameter[] get_RecipientParameters() { }

	private void InitHashSet() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void SetBool(int hash, bool value) { }

	public override void SetDonorAnimator(IAnimator weaponAnimator) { }

	private void SetFloat(int hash, float value) { }

	private void SetInteger(int hash, int value) { }

	private void SetTrigger(int hash, bool value) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

