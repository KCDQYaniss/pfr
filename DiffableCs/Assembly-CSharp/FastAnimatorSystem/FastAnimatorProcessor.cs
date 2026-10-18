namespace FastAnimatorSystem;

public class FastAnimatorProcessor : IAnimator, IAnimatorNotificator
{
	internal class FastAnimatorCache : IParametersCache
	{
		private readonly FastAnimatorController _animatorController; //Field offset: 0x10
		private readonly Dictionary _flattenHash2StateDict; //Field offset: 0x18
		private readonly Dictionary _flattenLayer2NameDict; //Field offset: 0x20
		private readonly Dictionary _flattenName2StateDict; //Field offset: 0x28
		private readonly Dictionary _hash2paramCache; //Field offset: 0x30
		private readonly AnimatorSystemLogger _logger; //Field offset: 0x38
		private readonly Dictionary _name2paramCache; //Field offset: 0x40
		private readonly List _allAbstractStates; //Field offset: 0x48

		public FastAnimatorCache(FastAnimatorController animatorController, AnimatorSystemLogger logger) { }

		public void AddDependencyToParameter(int parameterHash, AbstractAnimatorControllerState animatorState) { }

		public string GetLayerName(int layer) { }

		public override float GetParameter(int nameHash) { }

		private AnimatorParameter GetParameterCache(int parameterHash) { }

		private AnimatorParameter GetParameterCache(string paramaterName) { }

		public string GetParameterName(int nameHash) { }

		public bool GetState(string stateName, int layer, out AbstractState state) { }

		public bool GetState(int stateInfoFullPathHash, out AbstractState state) { }

		public bool HasParameter(int parameterHash) { }

		public void RemoveDependencyFromParameter(int parameterHash, AbstractAnimatorControllerState animatorState) { }

		public void SetParameter(int valueNameHash, int value) { }

		public void SetParameter(string valueNameHash, float value) { }

		public void SetParameter(int paramaterHash, bool value) { }

		public void SetParameter(string paramaterName, bool value) { }

		public void SetParameter(string paramaterName, int value) { }

		public void SetParameter(int valueNameHash, float value) { }

	}

	private static AnimatorSystemLogger Logger; //Field offset: 0x0
	public readonly FastAnimatorController FastAnimatorController; //Field offset: 0x10
	public FastControllerInfo FastControllerInfo; //Field offset: 0x18
	private bool _hadBeenUpdated; //Field offset: 0x20
	private FastAnimatorCache _animatorCache; //Field offset: 0x28
	private Dictionary _cachedNodes; //Field offset: 0x30
	private Transform _rootBone; //Field offset: 0x38
	private float _lastUpdateDeltaTime; //Field offset: 0x40
	private IPlayableAnimator _playableAnimator; //Field offset: 0x48
	private int _tagillaIndex; //Field offset: 0x50
	[CompilerGenerated]
	private int <TagilaRegularOperationsLayer>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private int <TagilaOverriderLayer>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <IntroLayer>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private int <BtrLayer>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private int <BoarLayer>k__BackingField; //Field offset: 0x64
	private bool _enable; //Field offset: 0x68
	private AnimatorUpdateMode _animatorUpdateMode; //Field offset: 0x6C
	[CompilerGenerated]
	private AnimatorCullingMode <cullingMode>k__BackingField; //Field offset: 0x70
	private float _speed; //Field offset: 0x74
	private Avatar _avatar; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnBoolValueChanged; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnIntegerValueChanged; //Field offset: 0x88
	[CompilerGenerated]
	private Action OnFloatValueChanged; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnTriggerChanged; //Field offset: 0x98
	[CompilerGenerated]
	private bool <keepAnimatorControllerStateOnDisable>k__BackingField; //Field offset: 0xA0

	public override event Action OnBoolValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnFloatValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnIntegerValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnTriggerChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override Avatar avatar
	{
		 get { } //Length: 114
		 set { } //Length: 200
	}

	public private int BoarLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int BtrLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override AnimatorCullingMode cullingMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override Vector3 deltaPosition
	{
		 get { } //Length: 1848
	}

	public override Quaternion deltaRotation
	{
		 get { } //Length: 1036
	}

	public override bool enabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public private int IntroLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool keepAnimatorControllerStateOnDisable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int layerCount
	{
		 get { } //Length: 71
	}

	public override string name
	{
		 get { } //Length: 27
	}

	public override int parameterCount
	{
		 get { } //Length: 71
	}

	public override RuntimeAnimatorController runtimeAnimatorController
	{
		 get { } //Length: 122
		 set { } //Length: 109
	}

	public override float speed
	{
		 get { } //Length: 6
		 set { } //Length: 128
	}

	public private int TagilaOverriderLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int TagilaRegularOperationsLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private int TagillaLayerIndex
	{
		private get { } //Length: 81
	}

	public override AnimatorUpdateMode updateMode
	{
		 get { } //Length: 4
		 set { } //Length: 123
	}

	public FastAnimatorProcessor(FastAnimatorController fastAnimatorController, Dictionary computedNodes, Transform rootBone, IPlayableAnimator playableAnimator) { }

	[CompilerGenerated]
	public override void add_OnBoolValueChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnFloatValueChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnIntegerValueChanged(Action value) { }

	[CompilerGenerated]
	public override void add_OnTriggerChanged(Action value) { }

	private Vector3 ComputeStateDeltaPos(AbstractAnimatorControllerState animState, float stateNormalizedTime) { }

	private Quaternion ComputeStateDeltaRotation(AbstractAnimatorControllerState animState) { }

	private static AnimatorControllerParameterType ConvertParameterType(EAnimatorValueType parameterType) { }

	private AnimatorStateInfoWrapper CreateAnimatorStateInfoWrapper(AbstractAnimatorControllerState state, float normalizedTime) { }

	private AnimatorParameterInfo CreateParameterInfo(AnimatorParameter parameter) { }

	public override Avatar get_avatar() { }

	[CompilerGenerated]
	public int get_BoarLayer() { }

	[CompilerGenerated]
	public int get_BtrLayer() { }

	[CompilerGenerated]
	public override AnimatorCullingMode get_cullingMode() { }

	public override Vector3 get_deltaPosition() { }

	public override Quaternion get_deltaRotation() { }

	public override bool get_enabled() { }

	[CompilerGenerated]
	public int get_IntroLayer() { }

	[CompilerGenerated]
	public override bool get_keepAnimatorControllerStateOnDisable() { }

	public override int get_layerCount() { }

	public override string get_name() { }

	public override int get_parameterCount() { }

	public override RuntimeAnimatorController get_runtimeAnimatorController() { }

	public override float get_speed() { }

	[CompilerGenerated]
	public int get_TagilaOverriderLayer() { }

	[CompilerGenerated]
	public int get_TagilaRegularOperationsLayer() { }

	private int get_TagillaLayerIndex() { }

	public override AnimatorUpdateMode get_updateMode() { }

	public override T[] GetBehaviours() { }

	public override void GetBehavioursNonAlloc(List resultsList) { }

	public override bool GetBool(string parameterName) { }

	public override bool GetBool(int parameterNameHash) { }

	public override AnimatorStateInfoWrapper GetCurrentAnimatorStateInfo(int layerIndex) { }

	public override float GetCurrentTransitionStartOffset(int layerIndex) { }

	public override float GetFloat(string parameterName) { }

	public override float GetFloat(int parameterNameHash) { }

	public override int GetInteger(int parameterNameHash) { }

	public override int GetInteger(string parameterName) { }

	private AnimatorControllerTransition GetInterruptedTriggeredTransition(AbstractAnimatorControllerState current, AbstractAnimatorControllerState next, float currentStateAbsTime, float nextStateAbsTime, float dt, AnimatorControllerTransition transition) { }

	public override int GetLayerIndex(string layerName) { }

	public override string GetLayerName(int layerIndex) { }

	public override float GetLayerWeight(int layerIndex) { }

	public override AnimatorStateInfoWrapper GetNextAnimatorStateInfo(int layerIndex) { }

	public override AnimatorParameterInfo GetParameter(int parameterIndex) { }

	public override string GetParameterName(int hash) { }

	public override int GetParameterNameHash(int parameterIndex) { }

	public IParametersCache GetParametersCache() { }

	public override AnimatorControllerParameterType GetParameterType(int parameterIndex) { }

	public float GetStateAbsTime(in AnimatorStateInfoWrapper stateInfo, int layerIndex) { }

	public string GetStateName(in AnimatorStateInfoWrapper stateInfo) { }

	public void GetTransitionInfo(int layerIndex, out string tranName, out float tranDuration, out float tranTimeNormalized) { }

	public override float GetTransitionNormalizedTime(int layerIndex) { }

	private AnimatorControllerTransition GetTriggeredTransition(AbstractAnimatorControllerState state, float absoluteStartFrameTime, float absoluteEndFrameTime) { }

	public override bool HasParameter(int parameterHash) { }

	private override string IAnimator.GetStateName(in AnimatorStateInfoWrapper stateInfo) { }

	public override bool IsInTransition(int layerIndex) { }

	public override bool IsParameterControlledByCurve(int parameterNameHash) { }

	public override void Play(string stateName, int layer, float normalizedTime) { }

	public override void Play(int stateNameHash, int layer, float normalizedTime) { }

	private void ProcessImmediateTransition(FastLayerInfo layerInfo, float destStateDT, int recursionLevel, AnimatorControllerTransition triggeredTransition, int layerIndex, float prevstatDt) { }

	private void ProcessLayer(float deltaTime, int layerIndex, FastAnimatorController fastAnimatorController, FastControllerInfo fastControllerInfo) { }

	private void ProcessState(FastLayerInfo layerInfo, float deltaTime, int layerIndex, int recursionLevel = 0) { }

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

	private void ResetParameterToDefaultValues() { }

	public override void ResetTrigger(string triggerName) { }

	public override void ResetTrigger(int triggerNameHash) { }

	private void ResetTriggeredTriggers(AnimatorControllerTransition triggeredTransition) { }

	public override void set_avatar(Avatar value) { }

	[CompilerGenerated]
	private void set_BoarLayer(int value) { }

	[CompilerGenerated]
	private void set_BtrLayer(int value) { }

	[CompilerGenerated]
	public override void set_cullingMode(AnimatorCullingMode value) { }

	public override void set_enabled(bool value) { }

	[CompilerGenerated]
	private void set_IntroLayer(int value) { }

	[CompilerGenerated]
	public override void set_keepAnimatorControllerStateOnDisable(bool value) { }

	public override void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	public override void set_speed(float value) { }

	[CompilerGenerated]
	private void set_TagilaOverriderLayer(int value) { }

	[CompilerGenerated]
	private void set_TagilaRegularOperationsLayer(int value) { }

	public override void set_updateMode(AnimatorUpdateMode value) { }

	public override void SetBool(int valueNameHash, bool value) { }

	public override void SetBool(string valueName, bool value) { }

	public override void SetFloat(string valueName, float value) { }

	public override void SetFloat(int valueNameHash, float value) { }

	public override void SetInteger(int valueNameHash, int value) { }

	public override void SetInteger(string valueName, int value) { }

	public override void SetLayerWeight(int layerIndex, float weight) { }

	public override void SetTrigger(int valueNameHash) { }

	public override void SetTrigger(string triggerName) { }

	public override int StringToHash(string parameterName) { }

	public virtual string ToString() { }

	public override void Update(float deltaTime) { }

}

