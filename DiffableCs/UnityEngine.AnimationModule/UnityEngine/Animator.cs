namespace UnityEngine;

[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[UsedByNativeCode]
public class Animator : Behaviour
{

	public bool applyRootMotion
	{
		 set { } //Length: 93
	}

	public Avatar avatar
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public AnimatorCullingMode cullingMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public Vector3 deltaPosition
	{
		 get { } //Length: 104
	}

	public Quaternion deltaRotation
	{
		 get { } //Length: 102
	}

	public bool hasBoundPlayables
	{
		[NativeMethod("HasBoundPlayables")]
		 get { } //Length: 78
	}

	public bool hasRootMotion
	{
		[NativeMethod("HasRootMotion")]
		 get { } //Length: 78
	}

	public bool isHuman
	{
		[NativeMethod("IsHuman")]
		 get { } //Length: 78
	}

	public bool keepAnimatorStateOnDisable
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public int layerCount
	{
		 get { } //Length: 78
	}

	public bool logWarnings
	{
		 set { } //Length: 93
	}

	public int parameterCount
	{
		 get { } //Length: 78
	}

	public AnimatorControllerParameter[] parameters
	{
		[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
		 get { } //Length: 78
	}

	public Vector3 pivotPosition
	{
		 get { } //Length: 104
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float speed
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public Quaternion targetRotation
	{
		 get { } //Length: 102
	}

	public AnimatorUpdateMode updateMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public Animator() { }

	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	public Avatar get_avatar() { }

	public AnimatorCullingMode get_cullingMode() { }

	public Vector3 get_deltaPosition() { }

	private void get_deltaPosition_Injected(out Vector3 ret) { }

	public Quaternion get_deltaRotation() { }

	private void get_deltaRotation_Injected(out Quaternion ret) { }

	[NativeMethod("HasBoundPlayables")]
	public bool get_hasBoundPlayables() { }

	[NativeMethod("HasRootMotion")]
	public bool get_hasRootMotion() { }

	[NativeMethod("IsHuman")]
	public bool get_isHuman() { }

	public bool get_keepAnimatorStateOnDisable() { }

	public int get_layerCount() { }

	public int get_parameterCount() { }

	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	public AnimatorControllerParameter[] get_parameters() { }

	public Vector3 get_pivotPosition() { }

	private void get_pivotPosition_Injected(out Vector3 ret) { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	public float get_speed() { }

	public Quaternion get_targetRotation() { }

	private void get_targetRotation_Injected(out Quaternion ret) { }

	public AnimatorUpdateMode get_updateMode() { }

	[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = True)]
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	public T[] GetBehaviours() { }

	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethod("GetBoneTransform")]
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	public bool GetBool(int id) { }

	public bool GetBool(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	private bool GetBoolID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = True)]
	private bool GetBoolString(string name) { }

	public void GetCurrentAnimatorClipInfo(int layerIndex, List clips) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	public float GetFloat(string name) { }

	public float GetFloat(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	private float GetFloatID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = True)]
	private float GetFloatString(string name) { }

	public int GetInteger(int id) { }

	public int GetInteger(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	private int GetIntegerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = True)]
	private int GetIntegerString(string name) { }

	public int GetLayerIndex(string layerName) { }

	public string GetLayerName(int layerIndex) { }

	public float GetLayerWeight(int layerIndex) { }

	public void GetNextAnimatorClipInfo(int layerIndex, List clips) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::InternalGetBehaviours", HasExplicitThis = True)]
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	public bool IsInTransition(int layerIndex) { }

	public bool IsParameterControlledByCurve(int id) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = True)]
	private bool IsParameterControlledByCurveID(int id) { }

	public void Play(int stateNameHash) { }

	public void Play(int stateNameHash, int layer) { }

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	public void Play(string stateName) { }

	private void Rebind(bool writeDefaultValues) { }

	public void Rebind() { }

	public void ResetTrigger(string name) { }

	public void ResetTrigger(int id) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = True)]
	private void ResetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	private void ResetTriggerString(string name) { }

	public void set_applyRootMotion(bool value) { }

	public void set_avatar(Avatar value) { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	public void set_keepAnimatorStateOnDisable(bool value) { }

	public void set_logWarnings(bool value) { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	public void set_speed(float value) { }

	public void set_updateMode(AnimatorUpdateMode value) { }

	public void SetBool(string name, bool value) { }

	public void SetBool(int id, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	private void SetBoolID(int id, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	private void SetBoolString(string name, bool value) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int id, float value) { }

	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	private void SetFloatID(int id, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatIDDamp", HasExplicitThis = True)]
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = True)]
	private void SetFloatString(string name, float value) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	private void SetIntegerID(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = True)]
	private void SetIntegerString(string name, int value) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	public void SetTrigger(int id) { }

	public void SetTrigger(string name) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	private void SetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	private void SetTriggerString(string name) { }

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	public static int StringToHash(string name) { }

	[NativeMethod("UpdateWithDelta")]
	public void Update(float deltaTime) { }

}

