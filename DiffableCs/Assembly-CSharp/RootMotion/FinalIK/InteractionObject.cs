namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
public class InteractionObject : MonoBehaviour
{
	internal class AnimatorEvent
	{
		private const string empty = ""; //Field offset: 0x0
		[Tooltip("The Animator component that will receive the AnimatorEvents.")]
		public Animator animator; //Field offset: 0x10
		[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
		public Animation animation; //Field offset: 0x18
		[Tooltip("The name of the animation state.")]
		public string animationState; //Field offset: 0x20
		[Tooltip("The crossfading time.")]
		public float crossfadeTime; //Field offset: 0x28
		[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
		public int layer; //Field offset: 0x2C
		[Tooltip("Should the animation always start from 0 normalized time?")]
		public bool resetNormalizedTime; //Field offset: 0x30

		public AnimatorEvent() { }

		public void Activate(bool pickUp) { }

		private void Activate(Animator animator) { }

		private void Activate(Animation animation) { }

	}

	internal class InteractionEvent
	{
		[Tooltip("The time of the event since interaction start.")]
		public float time; //Field offset: 0x10
		[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
		public bool pause; //Field offset: 0x14
		[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
		public bool pickUp; //Field offset: 0x15
		[Tooltip("The animations called on this event.")]
		public AnimatorEvent[] animations; //Field offset: 0x18
		[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
		public Message[] messages; //Field offset: 0x20

		public InteractionEvent() { }

		public void Activate(Transform t) { }

	}

	internal class Message
	{
		private const string empty = ""; //Field offset: 0x0
		[Tooltip("The name of the function called.")]
		public string function; //Field offset: 0x10
		[Tooltip("The recipient game object.")]
		public GameObject recipient; //Field offset: 0x18

		public Message() { }

		public void Send(Transform t) { }

	}

	internal class Multiplier
	{
		[Tooltip("The curve type to multiply.")]
		public Type curve; //Field offset: 0x10
		[Tooltip("The multiplier of the curve's value.")]
		public float multiplier; //Field offset: 0x14
		[Tooltip("The resulting value will be applied to this channel.")]
		public Type result; //Field offset: 0x18

		public Multiplier() { }

		public float GetValue(WeightCurve weightCurve, float timer) { }

	}

	internal class WeightCurve
	{
		internal enum Type
		{
			PositionWeight = 0,
			RotationWeight = 1,
			PositionOffsetX = 2,
			PositionOffsetY = 3,
			PositionOffsetZ = 4,
			Pull = 5,
			Reach = 6,
			RotateBoneWeight = 7,
			Push = 8,
			PushParent = 9,
			PoserWeight = 10,
		}

		[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
		public Type type; //Field offset: 0x10
		[Tooltip("The weight curve.")]
		public AnimationCurve curve; //Field offset: 0x18

		public WeightCurve() { }

		public float GetValue(float timer) { }

	}

	[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
	public Transform otherLookAtTarget; //Field offset: 0x20
	[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
	public Transform otherTargetsRoot; //Field offset: 0x28
	[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
	public Transform positionOffsetSpace; //Field offset: 0x30
	public WeightCurve[] weightCurves; //Field offset: 0x38
	public Multiplier[] multipliers; //Field offset: 0x40
	public InteractionEvent[] events; //Field offset: 0x48
	[CompilerGenerated]
	private float <length>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private InteractionSystem <lastUsedInteractionSystem>k__BackingField; //Field offset: 0x58
	private InteractionTarget[] targets; //Field offset: 0x60

	public private InteractionSystem lastUsedInteractionSystem
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float length
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public Transform lookAtTarget
	{
		 get { } //Length: 280
	}

	public Transform targetsRoot
	{
		 get { } //Length: 280
	}

	public InteractionObject() { }

	private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, Type type, float value, float weight) { }

	public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight) { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	private void Awake() { }

	public bool CurveUsed(Type type) { }

	[CompilerGenerated]
	public InteractionSystem get_lastUsedInteractionSystem() { }

	[CompilerGenerated]
	public float get_length() { }

	public Transform get_lookAtTarget() { }

	public Transform get_targetsRoot() { }

	private int GetMultiplierIndex(Type weightCurveType) { }

	public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem) { }

	private Transform GetTarget(FullBodyBipedEffector effectorType) { }

	public Transform GetTarget(FullBodyBipedEffector effectorType, string tag) { }

	public InteractionTarget[] GetTargets() { }

	public float GetValue(Type weightCurveType, InteractionTarget target, float timer) { }

	private int GetWeightCurveIndex(Type weightCurveType) { }

	public void Initiate() { }

	public void OnStartInteraction(InteractionSystem interactionSystem) { }

	[ContextMenu("Scrpt Reference")]
	private void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
	private void OpenTutorial1() { }

	[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
	private void OpenTutorial2() { }

	[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
	private void OpenTutorial3() { }

	[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
	private void OpenTutorial4() { }

	[ContextMenu("User Manual")]
	private void OpenUserManual() { }

	[CompilerGenerated]
	private void set_lastUsedInteractionSystem(InteractionSystem value) { }

	[CompilerGenerated]
	private void set_length(float value) { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

}

