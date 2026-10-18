namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
public class InteractionSystem : MonoBehaviour
{
	internal sealed class InteractionDelegate : MulticastDelegate
	{

		public InteractionDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	}

	internal sealed class InteractionEventDelegate : MulticastDelegate
	{

		public InteractionEventDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionEvent interactionEvent, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionEvent interactionEvent) { }

	}

	[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
	public string targetTag; //Field offset: 0x20
	[Tooltip("The fade in time of the interaction.")]
	public float fadeInTime; //Field offset: 0x28
	[Tooltip("The master speed for all interactions.")]
	public float speed; //Field offset: 0x2C
	[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
	public float resetToDefaultsSpeed; //Field offset: 0x30
	[FormerlySerializedAs("collider")]
	[Header("Triggering")]
	[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
	public Collider characterCollider; //Field offset: 0x38
	[FormerlySerializedAs("camera")]
	[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
	public Transform FPSCamera; //Field offset: 0x40
	[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
	public LayerMask camRaycastLayers; //Field offset: 0x48
	[Tooltip("Max distance of raycasting from the camera.")]
	public float camRaycastDistance; //Field offset: 0x4C
	[CompilerGenerated]
	private List <triggersInRange>k__BackingField; //Field offset: 0x50
	private List inContact; //Field offset: 0x58
	private List bestRangeIndexes; //Field offset: 0x60
	public InteractionDelegate OnInteractionStart; //Field offset: 0x68
	public InteractionDelegate OnInteractionPause; //Field offset: 0x70
	public InteractionDelegate OnInteractionPickUp; //Field offset: 0x78
	public InteractionDelegate OnInteractionResume; //Field offset: 0x80
	public InteractionDelegate OnInteractionStop; //Field offset: 0x88
	public InteractionEventDelegate OnInteractionEvent; //Field offset: 0x90
	public RaycastHit raycastHit; //Field offset: 0x98
	[SerializeField]
	[Space(10)]
	[Tooltip("Reference to the FBBIK component.")]
	private FullBodyBipedIK fullBody; //Field offset: 0xC8
	[Tooltip("Handles looking at the interactions.")]
	public InteractionLookAt lookAt; //Field offset: 0xD0
	private InteractionEffector[] interactionEffectors; //Field offset: 0xD8
	private bool initiated; //Field offset: 0xE0
	private Collider lastCollider; //Field offset: 0xE8
	private Collider c; //Field offset: 0xF0

	public FullBodyBipedIK ik
	{
		 get { } //Length: 8
	}

	public bool inInteraction
	{
		 get { } //Length: 207
	}

	public private List triggersInRange
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public InteractionSystem() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	private bool ContactIsInRange(int index, out int bestRangeIndex) { }

	public FullBodyBipedIK get_ik() { }

	public bool get_inInteraction() { }

	[CompilerGenerated]
	public List get_triggersInRange() { }

	public InteractionObject GetClosestInteractionObjectInRange() { }

	public InteractionObject[] GetClosestInteractionObjectsInRange() { }

	public Range GetClosestInteractionRange() { }

	public InteractionTarget GetClosestInteractionTargetInRange() { }

	public InteractionTarget[] GetClosestInteractionTargetsInRange() { }

	public int GetClosestTriggerIndex() { }

	public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType) { }

	public float GetMinActiveProgress() { }

	public float GetProgress(FullBodyBipedEffector effectorType) { }

	public Range GetTriggerRange(int index) { }

	private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	public bool IsInInteraction(FullBodyBipedEffector effectorType) { }

	public bool IsInSync() { }

	public bool IsPaused(FullBodyBipedEffector effectorType) { }

	public bool IsPaused() { }

	private bool IsValid(bool log) { }

	private void LateUpdate() { }

	private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	private void OnDestroy() { }

	private void OnDrawGizmosSelected() { }

	private void OnPostFBBIK() { }

	private void OnPreFBBIK() { }

	public void OnTriggerEnter(Collider c) { }

	public void OnTriggerExit(Collider c) { }

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

	public void PauseAll() { }

	public bool PauseInteraction(FullBodyBipedEffector effectorType) { }

	private void Raycasting() { }

	public void ResumeAll() { }

	public bool ResumeInteraction(FullBodyBipedEffector effectorType) { }

	[CompilerGenerated]
	private void set_triggersInRange(List value) { }

	protected override void Start() { }

	public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt) { }

	public void StopAll() { }

	public bool StopInteraction(FullBodyBipedEffector effectorType) { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

	public bool TriggerEffectorsReady(int index) { }

	private bool TriggerIndexIsValid(int index) { }

	public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject) { }

	public bool TriggerInteraction(int index, bool interrupt) { }

	public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget) { }

	private void Update() { }

	private void UpdateTriggerEventBroadcasting() { }

}

