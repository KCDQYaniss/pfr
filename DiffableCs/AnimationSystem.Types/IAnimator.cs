//Type is in global namespace

public interface IAnimator : IAnimatorNotificator
{

	public Avatar avatar
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public AnimatorCullingMode cullingMode
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 deltaPosition
	{
		 get { } //Length: 0
	}

	public Quaternion deltaRotation
	{
		 get { } //Length: 0
	}

	public bool enabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool keepAnimatorControllerStateOnDisable
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int layerCount
	{
		 get { } //Length: 0
	}

	public string name
	{
		 get { } //Length: 0
	}

	public int parameterCount
	{
		 get { } //Length: 0
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float speed
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public AnimatorUpdateMode updateMode
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Avatar get_avatar() { }

	public AnimatorCullingMode get_cullingMode() { }

	public Vector3 get_deltaPosition() { }

	public Quaternion get_deltaRotation() { }

	public bool get_enabled() { }

	public bool get_keepAnimatorControllerStateOnDisable() { }

	public int get_layerCount() { }

	public string get_name() { }

	public int get_parameterCount() { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	public float get_speed() { }

	public AnimatorUpdateMode get_updateMode() { }

	public T[] GetBehaviours() { }

	public void GetBehavioursNonAlloc(List resultsList) { }

	public bool GetBool(string parameterName) { }

	public bool GetBool(int parameterNameHash) { }

	public AnimatorStateInfoWrapper GetCurrentAnimatorStateInfo(int layerIndex) { }

	public float GetCurrentTransitionStartOffset(int layerIndex) { }

	public float GetFloat(string parameterName) { }

	public float GetFloat(int parameterNameHash) { }

	public int GetInteger(int parameterNameHash) { }

	public int GetInteger(string parameterName) { }

	public int GetLayerIndex(string layerName) { }

	public string GetLayerName(int layerIndex) { }

	public float GetLayerWeight(int layerIndex) { }

	public AnimatorStateInfoWrapper GetNextAnimatorStateInfo(int layerIndex) { }

	public AnimatorParameterInfo GetParameter(int parameterIndex) { }

	public string GetParameterName(int hash) { }

	public int GetParameterNameHash(int parameterIndex) { }

	public AnimatorControllerParameterType GetParameterType(int parameterIndex) { }

	public string GetStateName(in AnimatorStateInfoWrapper stateInfo) { }

	public float GetTransitionNormalizedTime(int layerIndex) { }

	public bool HasParameter(int parameterHash) { }

	public bool IsInTransition(int layerIndex) { }

	public bool IsParameterControlledByCurve(int parameterNameHash) { }

	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	public void RebindBones() { }

	public bool Reset() { }

	public void ResetTrigger(string triggerName) { }

	public void ResetTrigger(int triggerNameHash) { }

	public void set_avatar(Avatar value) { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	public void set_enabled(bool value) { }

	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	public void set_speed(float value) { }

	public void set_updateMode(AnimatorUpdateMode value) { }

	public void SetBool(string valueName, bool value) { }

	public void SetBool(int valueNameHash, bool value) { }

	public void SetFloat(int valueNameHash, float value) { }

	public void SetFloat(string valueName, float value) { }

	public void SetInteger(string valueName, int value) { }

	public void SetInteger(int valueNameHash, int value) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	public void SetTrigger(int triggerNameHash) { }

	public void SetTrigger(string triggerName) { }

	public int StringToHash(string parameterName) { }

	public void Update(float dt) { }

}

