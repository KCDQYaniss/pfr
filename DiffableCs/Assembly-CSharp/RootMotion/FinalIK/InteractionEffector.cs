namespace RootMotion.FinalIK;

public class InteractionEffector
{
	[CompilerGenerated]
	private FullBodyBipedEffector <effectorType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <isPaused>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private InteractionObject <interactionObject>k__BackingField; //Field offset: 0x18
	private Poser poser; //Field offset: 0x20
	private IKEffector effector; //Field offset: 0x28
	private float timer; //Field offset: 0x30
	private float length; //Field offset: 0x34
	private float weight; //Field offset: 0x38
	private float fadeInSpeed; //Field offset: 0x3C
	private float defaultPositionWeight; //Field offset: 0x40
	private float defaultRotationWeight; //Field offset: 0x44
	private float defaultPull; //Field offset: 0x48
	private float defaultReach; //Field offset: 0x4C
	private float defaultPush; //Field offset: 0x50
	private float defaultPushParent; //Field offset: 0x54
	private float resetTimer; //Field offset: 0x58
	private bool positionWeightUsed; //Field offset: 0x5C
	private bool rotationWeightUsed; //Field offset: 0x5D
	private bool pullUsed; //Field offset: 0x5E
	private bool reachUsed; //Field offset: 0x5F
	private bool pushUsed; //Field offset: 0x60
	private bool pushParentUsed; //Field offset: 0x61
	private bool pickedUp; //Field offset: 0x62
	private bool defaults; //Field offset: 0x63
	private bool pickUpOnPostFBBIK; //Field offset: 0x64
	private Vector3 pickUpPosition; //Field offset: 0x68
	private Vector3 pausePositionRelative; //Field offset: 0x74
	private Quaternion pickUpRotation; //Field offset: 0x80
	private Quaternion pauseRotationRelative; //Field offset: 0x90
	private InteractionTarget interactionTarget; //Field offset: 0xA0
	private Transform target; //Field offset: 0xA8
	private List triggered; //Field offset: 0xB0
	private InteractionSystem interactionSystem; //Field offset: 0xB8
	private bool started; //Field offset: 0xC0

	public private FullBodyBipedEffector effectorType
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool inInteraction
	{
		 get { } //Length: 203
	}

	public private InteractionObject interactionObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool isPaused
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public float progress
	{
		 get { } //Length: 60
	}

	public InteractionEffector(FullBodyBipedEffector effectorType) { }

	[CompilerGenerated]
	public FullBodyBipedEffector get_effectorType() { }

	public bool get_inInteraction() { }

	[CompilerGenerated]
	public InteractionObject get_interactionObject() { }

	[CompilerGenerated]
	public bool get_isPaused() { }

	public float get_progress() { }

	public void Initiate(InteractionSystem interactionSystem) { }

	public void OnPostFBBIK() { }

	public bool Pause() { }

	private void PickUp(Transform root) { }

	public bool ResetToDefaults(float speed) { }

	public bool Resume() { }

	[CompilerGenerated]
	private void set_effectorType(FullBodyBipedEffector value) { }

	[CompilerGenerated]
	private void set_interactionObject(InteractionObject value) { }

	[CompilerGenerated]
	private void set_isPaused(bool value) { }

	public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt) { }

	public bool Stop() { }

	private void StoreDefaults() { }

	private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause) { }

	public void Update(Transform root, float speed) { }

}

