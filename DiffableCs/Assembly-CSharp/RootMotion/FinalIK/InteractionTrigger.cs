namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
public class InteractionTrigger : MonoBehaviour
{
	internal class CameraPosition
	{
		[Tooltip("What the camera should be looking at to trigger the interaction?")]
		public Collider lookAtTarget; //Field offset: 0x10
		[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
		public Vector3 direction; //Field offset: 0x18
		[Tooltip("Max distance from the lookAtTarget to the camera.")]
		public float maxDistance; //Field offset: 0x24
		[Range(0, 180)]
		[Tooltip("Max angle between the direction and the direction towards the camera.")]
		public float maxAngle; //Field offset: 0x28
		[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
		public bool fixYAxis; //Field offset: 0x2C

		public CameraPosition() { }

		public Quaternion GetRotation() { }

		public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error) { }

	}

	internal class CharacterPosition
	{
		[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
		public bool use; //Field offset: 0x10
		[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
		public Vector2 offset; //Field offset: 0x14
		[Range(-180, 180)]
		[Tooltip("Angle offset from the default forward direction.")]
		public float angleOffset; //Field offset: 0x1C
		[Range(0, 180)]
		[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
		public float maxAngle; //Field offset: 0x20
		[Tooltip("Max offset of the character's position from this range's center.")]
		public float radius; //Field offset: 0x24
		[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
		public bool orbit; //Field offset: 0x28
		[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
		public bool fixYAxis; //Field offset: 0x29

		public Vector3 direction3D
		{
			 get { } //Length: 690
		}

		public Vector3 offset3D
		{
			 get { } //Length: 22
		}

		public CharacterPosition() { }

		public Vector3 get_direction3D() { }

		public Vector3 get_offset3D() { }

		public bool IsInRange(Transform character, Transform trigger, out float error) { }

	}

	internal class Range
	{
		internal class Interaction
		{
			[Tooltip("The InteractionObject to interact with.")]
			public InteractionObject interactionObject; //Field offset: 0x10
			[Tooltip("The effectors to interact with.")]
			public FullBodyBipedEffector[] effectors; //Field offset: 0x18

			public Interaction() { }

		}

		[HideInInspector]
		[SerializeField]
		public string name; //Field offset: 0x10
		[HideInInspector]
		[SerializeField]
		public bool show; //Field offset: 0x18
		[Tooltip("The range for the character's position and rotation.")]
		public CharacterPosition characterPosition; //Field offset: 0x20
		[Tooltip("The range for the character camera's position and rotation.")]
		public CameraPosition cameraPosition; //Field offset: 0x28
		[Tooltip("Definitions of the interactions associated with this range.")]
		public Interaction[] interactions; //Field offset: 0x30

		public Range() { }

		public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError) { }

	}

	[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
	public Range[] ranges; //Field offset: 0x20

	public InteractionTrigger() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit) { }

	[ContextMenu("TUTORIAL VIDEO")]
	private void OpenTutorial4() { }

	private void Start() { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

}

