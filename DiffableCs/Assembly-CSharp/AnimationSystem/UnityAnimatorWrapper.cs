namespace AnimationSystem;

public class UnityAnimatorWrapper : IAnimator, IAnimatorNotificator
{
	private static AnimatorSystemLogger LOGGER; //Field offset: 0x0
	protected Animator _animator; //Field offset: 0x10
	private string _animatorName; //Field offset: 0x18
	private AnimatorControllerParameter[] _parametersCache; //Field offset: 0x20
	private HashSet _parametersHashes; //Field offset: 0x28
	private StateMachineBehaviour[] _allStateMachineBehaviours; //Field offset: 0x30
	private RuntimeAnimatorController _cachedRuntimeAnimatorController; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnBoolValueChanged; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnIntegerValueChanged; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnFloatValueChanged; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnTriggerChanged; //Field offset: 0x58

	public override event Action OnBoolValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnFloatValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnIntegerValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnTriggerChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Animator Animator
	{
		 get { } //Length: 5
	}

	public override Avatar avatar
	{
		 get { } //Length: 90
		 set { } //Length: 105
	}

	public override AnimatorCullingMode cullingMode
	{
		 get { } //Length: 90
		 set { } //Length: 103
	}

	public override Vector3 deltaPosition
	{
		 get { } //Length: 138
	}

	public override Quaternion deltaRotation
	{
		 get { } //Length: 126
	}

	public override bool enabled
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override bool keepAnimatorControllerStateOnDisable
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override int layerCount
	{
		 get { } //Length: 90
	}

	public override string name
	{
		 get { } //Length: 5
	}

	public override int parameterCount
	{
		 get { } //Length: 90
	}

	public override RuntimeAnimatorController runtimeAnimatorController
	{
		 get { } //Length: 90
		 set { } //Length: 137
	}

	public override float speed
	{
		 get { } //Length: 90
		 set { } //Length: 106
	}

	public override AnimatorUpdateMode updateMode
	{
		 get { } //Length: 90
		 set { } //Length: 103
	}

	protected UnityAnimatorWrapper() { }

	[CompilerGenerated]
	public override void add_OnBoolValueChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnFloatValueChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnIntegerValueChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnTriggerChanged(Action value) { }

	private void CacheParameters() { }

	public static UnityAnimatorWrapper Create() { }

	public static UnityAnimatorWrapper Create(Animator animator) { }

	public static AnimatorStateInfoWrapper CreateAnimatorStateInfoWrapper(AnimatorStateInfo stateInfo) { }

	private void EnsureBehavioursCache() { }

	public Animator get_Animator() { }

	public override Avatar get_avatar() { }

	public override AnimatorCullingMode get_cullingMode() { }

	public override Vector3 get_deltaPosition() { }

	public override Quaternion get_deltaRotation() { }

	public override bool get_enabled() { }

	public override bool get_keepAnimatorControllerStateOnDisable() { }

	public override int get_layerCount() { }

	public override string get_name() { }

	public override int get_parameterCount() { }

	public override RuntimeAnimatorController get_runtimeAnimatorController() { }

	public override float get_speed() { }

	public override AnimatorUpdateMode get_updateMode() { }

	public override T[] GetBehaviours() { }

	public override void GetBehavioursNonAlloc(List resultsList) { }

	public override bool GetBool(int conditionCachedNameHash) { }

	public override bool GetBool(string parameterName) { }

	public override AnimatorStateInfoWrapper GetCurrentAnimatorStateInfo(int layerIndex) { }

	public override float GetCurrentTransitionStartOffset(int layerIndex) { }

	public override float GetFloat(string parameterName) { }

	public override float GetFloat(int conditionCachedNameHash) { }

	public override int GetInteger(int conditionCachedNameHash) { }

	public override int GetInteger(string parameterName) { }

	public override int GetLayerIndex(string layerName) { }

	public override string GetLayerName(int layerIndex) { }

	public override float GetLayerWeight(int layerIndex) { }

	public override AnimatorStateInfoWrapper GetNextAnimatorStateInfo(int layerIndex) { }

	public override AnimatorParameterInfo GetParameter(int parameterIndex) { }

	public override string GetParameterName(int hash) { }

	public override int GetParameterNameHash(int parameterIndex) { }

	public override AnimatorControllerParameterType GetParameterType(int parameterIndex) { }

	public string GetStateName(in AnimatorStateInfoWrapper stateInfo) { }

	public override float GetTransitionNormalizedTime(int layerIndex) { }

	public override bool HasParameter(int parameterHash) { }

	private override string IAnimator.GetStateName(in AnimatorStateInfoWrapper stateInfo) { }

	private void InvalidateBehavioursCache() { }

	public override bool IsInTransition(int layerIndex) { }

	public override bool IsParameterControlledByCurve(int parameterNameHash) { }

	public void Play(string stateName) { }

	public override void Play(int stateNameHash, int layer, float normalizedTime) { }

	public override void Play(string stateName, int layer, float normalizedTime) { }

	public override void RebindBones() { }

	[CompilerGenerated]
	public override void remove_OnBoolValueChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnFloatValueChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnIntegerValueChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_OnTriggerChanged(Action value) { }

	public override bool Reset() { }

	private bool ResetParameterToDefaultValues() { }

	public override void ResetTrigger(int triggerNameHash) { }

	public override void ResetTrigger(string triggerName) { }

	public override void set_avatar(Avatar value) { }

	public override void set_cullingMode(AnimatorCullingMode value) { }

	public override void set_enabled(bool value) { }

	public override void set_keepAnimatorControllerStateOnDisable(bool value) { }

	public override void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	public override void set_speed(float value) { }

	public override void set_updateMode(AnimatorUpdateMode value) { }

	public void SetAnimator(Animator animator) { }

	public override void SetBool(string valueName, bool value) { }

	public override void SetBool(int valueNameHash, bool value) { }

	public override void SetFloat(string floatValueHash, float value) { }

	public override void SetFloat(int valueNameHash, float value) { }

	public override void SetInteger(int valueNameHash, int value) { }

	public override void SetInteger(string valueName, int value) { }

	public override void SetLayerWeight(int layerIndex, float weight) { }

	public override void SetTrigger(int triggerNameHash) { }

	public override void SetTrigger(string triggerName) { }

	public override int StringToHash(string parameterName) { }

	public override void Update(float dt) { }

}

