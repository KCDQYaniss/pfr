namespace EFT;

public class PlayerAnimator
{
	[CompilerGenerated]
	private sealed class <SmoothlyDisableInteractionLayer>d__198 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayerAnimator <>4__this; //Field offset: 0x20
		private float <value>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SmoothlyDisableInteractionLayer>d__198(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum EDoorInteractionIndex
	{
		PullLeft = 0,
		PullRight = 1,
		Push = 2,
	}

	internal enum EWeaponAnimationType
	{
		Rifle = 0,
		Pistol = 1,
		ThrowWeapon = 2,
		Knife = 3,
		EmptyHands = 4,
		RocketLauncher = 5,
	}

	public const int GUI_LAYER_INDEX = 11; //Field offset: 0x0
	public const int ATTACK_NO_INERT_LAYER_INDEX = 2; //Field offset: 0x0
	private const string LEFT_STANCE_LAYER_NAME = "LS"; //Field offset: 0x0
	private const string ADDITIVE_AIMING_LAYER_NAME = "Additive_Aiming"; //Field offset: 0x0
	private const string SYNC_SPRINT_HANDS_LAYER_NAME = "Sync_SprintHands"; //Field offset: 0x0
	private const string INTERACTIONS_LAYER_NAME = "InteractionsLayer"; //Field offset: 0x0
	private const string BOAR_OVERRIDE_LAYER_NAME = "BoarOverride"; //Field offset: 0x0
	private const string UTILITY_OPERATIONS_LAYER_NAME = "UtilityOperation"; //Field offset: 0x0
	private const string INTRO_ANIMATION_LAYER_NAME = "Intro_anim"; //Field offset: 0x0
	private const string TAGILLA_OVERRIDE_LAYER_NAME = "TagillaOverride"; //Field offset: 0x0
	private const string TAGILLA_REGULAR_OPERATIONS_LAYER_NAME = "TagillaSyncLayerForRegularOperations"; //Field offset: 0x0
	private const string WEAPON_LAYER_NAME = "Weapon"; //Field offset: 0x0
	private const string BASE_LAYER_NAME = "Base Layer"; //Field offset: 0x0
	private const string BTR_INTERACTION_LAYER_NAME = "Btr"; //Field offset: 0x0
	private static readonly int POSE_LEVEL_PARAM_HASH; //Field offset: 0x0
	private static readonly int DIRECTION_X_PARAM_HASH; //Field offset: 0x4
	private static readonly int DIRECTION_Y_PARAM_HASH; //Field offset: 0x8
	private static readonly int DIRECTION_PARAM_HASH; //Field offset: 0xC
	private static readonly int SPEED_PARAM_HASH; //Field offset: 0x10
	private static readonly int SPRINT_SPEED_PARAM_HASH; //Field offset: 0x14
	public static readonly int SWING_SPEED_PARAM_HASH; //Field offset: 0x18
	private static readonly int SPRINT_INERTIA_PARAM_HASH; //Field offset: 0x1C
	public static readonly int WEAPON_SIZE_MODIFIER_PARAM_HASH; //Field offset: 0x20
	private static readonly int DELTA_ROTATION_PARAM_HASH; //Field offset: 0x24
	private static readonly int SPRINT_PARAM_HASH; //Field offset: 0x28
	private static readonly int JUMP_PARAM_HASH; //Field offset: 0x2C
	private static readonly int LANDING_PARAM_HASH; //Field offset: 0x30
	private static readonly int FALLING_DOWN_PARAM_HASH; //Field offset: 0x34
	private static readonly int AIM_ANGLE_PARAM_HASH; //Field offset: 0x38
	private static readonly int INERT_PARAM_HASH; //Field offset: 0x3C
	private static readonly int INERT_FLOAT_PARAM_HASH; //Field offset: 0x40
	private static readonly int PRONE_PARAM_HASH; //Field offset: 0x44
	private static readonly int PRONE_RELOAD_PARAM_HASH; //Field offset: 0x48
	public static readonly int KICK_PARAM_HASH; //Field offset: 0x4C
	public static readonly int KICK_SUCCEED_PARAM_HASH; //Field offset: 0x50
	public static readonly int BTR_GO_IN_PARAM_HASH; //Field offset: 0x54
	public static readonly int BTR_GO_OUT_PARAM_HASH; //Field offset: 0x58
	public static readonly int BTR_GO_IN_FAST_PARAM_HASH; //Field offset: 0x5C
	public static readonly int BTR_GO_OUT_FAST_PARAM_HASH; //Field offset: 0x60
	public static readonly int BTR_ITEM_USE_PARAM_HASH; //Field offset: 0x64
	private static readonly int LOOT_PARAM_HASH; //Field offset: 0x68
	private static readonly int TILT_PARAM_HASH; //Field offset: 0x6C
	private static readonly int BLIND_FIRE_PARAM_HASH; //Field offset: 0x70
	private static readonly int BLIND_FIRE_FLOAT_PARAM_HASH; //Field offset: 0x74
	private static readonly int STEP_PARAM_HASH; //Field offset: 0x78
	private static readonly int FOOT_STEP_PARAM_HASH; //Field offset: 0x7C
	public static readonly int PICKUP_PARAM_HASH; //Field offset: 0x80
	public static readonly int INTERACT_PARAM_HASH; //Field offset: 0x84
	public static readonly int APPROACHED_HASH; //Field offset: 0x88
	public static readonly int WEAPON_TYPE; //Field offset: 0x8C
	public static readonly int STATIONARY_HASH; //Field offset: 0x90
	public static readonly int STATIONARY_TYPE_HASH; //Field offset: 0x94
	public static readonly int THIRDPERSON_HASH; //Field offset: 0x98
	public static readonly int THIRDPERSON_FLOAT_HASH; //Field offset: 0x9C
	public static readonly int DEFLECTED_HASH; //Field offset: 0xA0
	public static readonly int TRANSITION_SPEED_HASH; //Field offset: 0xA4
	public static readonly int WEAPON_TYPE_FLOAT_HASH; //Field offset: 0xA8
	public static readonly int RELOAD_FLOAT_PARAM_HASH; //Field offset: 0xAC
	private static readonly int FALLINGDOWN_FLOAT_PARAM_HASH; //Field offset: 0xB0
	public static readonly int WEAPON_OVERLAP_HASH; //Field offset: 0xB4
	public static readonly int WEAPON_OVERLAP_FLOAT_HASH; //Field offset: 0xB8
	public static readonly int SIDESTEP_FLOAT_HASH; //Field offset: 0xBC
	public static readonly int BOAR_WEAPON_PKM; //Field offset: 0xC0
	public static readonly int FLOAT_VAULTING_HEIGHT; //Field offset: 0xC4
	public static readonly int FLOAT_VAULTING_LENGTH; //Field offset: 0xC8
	public static readonly int BOOL_DO_VAULT; //Field offset: 0xCC
	public static readonly int BOOL_DO_CLIMB; //Field offset: 0xD0
	public static readonly int BOOL_IS_VAULTING; //Field offset: 0xD4
	public static readonly int BOOL_IS_GROUNDED; //Field offset: 0xD8
	public static readonly int FLOAT_ABSOLUTE_FORWARD_VELOCITY; //Field offset: 0xDC
	public static readonly int FLOAT_OVER_OBSTACLE_HEIGHT; //Field offset: 0xE0
	public static readonly int VAULTING_SPEED_HASH; //Field offset: 0xE4
	public static readonly int LEFT_STANCE_BOOL_HASH; //Field offset: 0xE8
	public static readonly int LEFT_STANCE_FORCE_BOOL_HASH; //Field offset: 0xEC
	public static readonly int PRONE_BIPODS_ON; //Field offset: 0xF0
	public static readonly int UI_WEAPON_OPERATION; //Field offset: 0xF4
	public static readonly int UI_RANDOM_ANIMATIONS_COUNT; //Field offset: 0xF8
	public static readonly int UI_RANDOM_TRANSITION; //Field offset: 0xFC
	public static readonly int UI_WEAPON_TYPE; //Field offset: 0x100
	public static readonly int ELBOW_LEFT_WEIGHT; //Field offset: 0x104
	public static readonly int ELBOW_RIGHT_WEIGHT; //Field offset: 0x108
	public static readonly int LEFT_HAND_WEIGHT; //Field offset: 0x10C
	public static readonly int LEFT_HAND_PATROL_WEIGHT; //Field offset: 0x110
	public static readonly int RIGHT_HAND_WEIGHT; //Field offset: 0x114
	public static readonly int RIGHT_HAND_DETACH_WEIGHT; //Field offset: 0x118
	public static readonly int LEFT_SHOULDER_WEIGHT; //Field offset: 0x11C
	public static readonly int RIGHT_SHOULDER_WEIGHT; //Field offset: 0x120
	public static readonly int WEAPON_ROOT_3RD; //Field offset: 0x124
	public static readonly int CAMERA_3RD; //Field offset: 0x128
	public static readonly int FIRST_PERSON_CURVE_WEIGHT; //Field offset: 0x12C
	public static readonly int FIRST_PERSON_ACTION; //Field offset: 0x130
	public static readonly int POSITION_CACHE_FOR_WEAPON_PROCEDURAL; //Field offset: 0x134
	public static readonly int LEFT_STANCE_CURVE; //Field offset: 0x138
	public static readonly int MOUSE_LOOK_CURVE; //Field offset: 0x13C
	public static readonly int AIMING_LAYER_CURVE; //Field offset: 0x140
	public static readonly int TURN; //Field offset: 0x144
	public static readonly int OUT_TO_IDLE_END_HASH; //Field offset: 0x148
	public static readonly int TURN_LEFT_90_AIM_HASH; //Field offset: 0x14C
	public static readonly int TURN_RIGHT_90_AIM_HASH; //Field offset: 0x150
	public static readonly int SIDEBACK_SPEED_PARAMETR_HASH; //Field offset: 0x154
	public static readonly int INVENTORY_PARAMETR_HASH; //Field offset: 0x158
	public static readonly int INVENTORY_OPERATION_PARAMETR_HASH; //Field offset: 0x15C
	public static readonly int TRIGGER_TUTORIAL_INTRO_HASH; //Field offset: 0x160
	public static readonly int UI_CHARACTERSELECTIONSCREEN_HASH; //Field offset: 0x164
	public static readonly int IS_ALERTED; //Field offset: 0x168
	public static readonly int IS_ALERTED_FLOAT; //Field offset: 0x16C
	public static readonly int IS_LOST; //Field offset: 0x170
	public static readonly int IS_HIT; //Field offset: 0x174
	public static readonly int HIT_INDEX_FLOAT; //Field offset: 0x178
	public static readonly int HIT_DIRECTION_X; //Field offset: 0x17C
	public static readonly int HIT_DIRECTION_Y; //Field offset: 0x180
	public static readonly int IS_ATTACKING; //Field offset: 0x184
	public static readonly int ATTACK_VARIANT; //Field offset: 0x188
	public static readonly int IS_TURNING; //Field offset: 0x18C
	public static readonly int TURNING_DELTA_ROTATION; //Field offset: 0x190
	public static readonly int DOOR_INTERACTION_ID; //Field offset: 0x194
	public static readonly int ZOMBIE_WEAPON_TYPE_FLOAT_HASH; //Field offset: 0x198
	public static readonly int IS_AIMING_BOOL_HASH; //Field offset: 0x19C
	public static readonly int USE_LEFT_HAND_BOOL_HASH; //Field offset: 0x1A0
	public static readonly int REMOVE_LEFT_HAND_SPEED_FLOAT_HASH; //Field offset: 0x1A4
	[CompilerGenerated]
	private int <BaseLayer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <WeaponLayer>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <TagilaRegularOperationsLayer>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <TagilaOverriderLayer>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <IntroLayer>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <BtrInteractionLayer>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <BoarLayer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <InteractionsLayer>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <SyncSprintHandsLayer>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <UtilityOperationLayer>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <AdditiveAimingLayer>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <LeftStanceLayer>k__BackingField; //Field offset: 0x3C
	private Func _animatorGetter; //Field offset: 0x40
	private PlayerAnimatorEventsDispatcher _eventsDispatcher; //Field offset: 0x48
	private MonoBehaviour _coroutineRunner; //Field offset: 0x50
	[CompilerGenerated]
	private IAnimatedInteractions <AnimatedInteractions>k__BackingField; //Field offset: 0x58
	private bool _isInventoryOpened; //Field offset: 0x60
	private bool _leftHandInUse; //Field offset: 0x61
	private Coroutine _changeInteractionLayerWeightCoroutine; //Field offset: 0x68
	private float _cachedSidebackSpeed; //Field offset: 0x70
	private float _cachedSidestepFloat; //Field offset: 0x74
	private float _cachedPoseLevel; //Field offset: 0x78
	private float _cachedHandsToBodyAngle; //Field offset: 0x7C
	private float _cachedaimAngle; //Field offset: 0x80
	private Vector2 _cachedMovemenDirection; //Field offset: 0x84
	private EMovementDirection _cachedDirection; //Field offset: 0x8C
	private float _cachedCharaterMovementSpeed; //Field offset: 0x90
	private float _cachedCharacterSprintSpeed; //Field offset: 0x94
	private float _cachedTilt; //Field offset: 0x98
	private float _cachedBlindFireFloat; //Field offset: 0x9C
	private int _cachedStep; //Field offset: 0xA0
	[CompilerGenerated]
	private Action OnJumpEvent; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnLandEvent; //Field offset: 0xB0

	public event Action OnJumpEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnLandEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private int AdditiveAimingLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private IAnimatedInteractions AnimatedInteractions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IAnimator Animator
	{
		 get { } //Length: 37
	}

	public private int BaseLayer
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int BoarLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int BtrInteractionLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Vector3 DeltaPosition
	{
		 get { } //Length: 135
	}

	public Quaternion DeltaRotation
	{
		 get { } //Length: 127
	}

	public PlayerAnimatorEventsDispatcher EventsDispatcher
	{
		 get { } //Length: 5
	}

	public private int InteractionsLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int IntroLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int LeftStanceLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int SyncSprintHandsLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
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

	public private int UtilityOperationLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int WeaponLayer
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static PlayerAnimator() { }

	public PlayerAnimator(Func animatorGetter, MonoBehaviour coroutineRunner) { }

	[CompilerGenerated]
	public void add_OnJumpEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnLandEvent(Action value) { }

	public void Dispose() { }

	public void DoAction() { }

	public void EnableBoarPkm(bool enabled) { }

	public void EnableFallingDown(bool enabled) { }

	public void EnableInert(bool enabled) { }

	public void EnableJump(bool enabled) { }

	public void EnableKick(bool enabled) { }

	public void EnableLanding(bool enabled) { }

	public void EnableLoot(bool enabled) { }

	public void EnablePickup(bool enabled) { }

	public void EnableProne(bool prone) { }

	public void EnableProneReload(bool enabled) { }

	public void EnableSprint(bool enabled) { }

	[CompilerGenerated]
	public int get_AdditiveAimingLayer() { }

	[CompilerGenerated]
	public IAnimatedInteractions get_AnimatedInteractions() { }

	public IAnimator get_Animator() { }

	[CompilerGenerated]
	public int get_BaseLayer() { }

	[CompilerGenerated]
	public int get_BoarLayer() { }

	[CompilerGenerated]
	public int get_BtrInteractionLayer() { }

	public Vector3 get_DeltaPosition() { }

	public Quaternion get_DeltaRotation() { }

	public PlayerAnimatorEventsDispatcher get_EventsDispatcher() { }

	[CompilerGenerated]
	public int get_InteractionsLayer() { }

	[CompilerGenerated]
	public int get_IntroLayer() { }

	[CompilerGenerated]
	public int get_LeftStanceLayer() { }

	[CompilerGenerated]
	public int get_SyncSprintHandsLayer() { }

	[CompilerGenerated]
	public int get_TagilaOverriderLayer() { }

	[CompilerGenerated]
	public int get_TagilaRegularOperationsLayer() { }

	[CompilerGenerated]
	public int get_UtilityOperationLayer() { }

	[CompilerGenerated]
	public int get_WeaponLayer() { }

	public float GetAbsoluteForwardVelocity() { }

	public float GetBehindObstacleRatio() { }

	public float GetCharacterMovementSpeed() { }

	public bool GetDoClimb() { }

	public bool GetDoVault() { }

	public bool GetIsVaulting() { }

	public bool GetItemUse() { }

	public bool GetLeftStance() { }

	public bool GetTurning() { }

	public float GetTurningRotation() { }

	public float GetVaultingHeight() { }

	public float GetVaultingLength() { }

	public float GetVaultingSpeed() { }

	public float GetWeaponTypeFloat() { }

	public bool IsInteractionOn() { }

	public bool IsJumpSetted() { }

	public bool IsProneReload() { }

	public void OnJump() { }

	public void OnLand() { }

	[CompilerGenerated]
	public void remove_OnJumpEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnLandEvent(Action value) { }

	public void ResetAnimatedInteractions() { }

	[CompilerGenerated]
	private void set_AdditiveAimingLayer(int value) { }

	[CompilerGenerated]
	private void set_AnimatedInteractions(IAnimatedInteractions value) { }

	[CompilerGenerated]
	private void set_BaseLayer(int value) { }

	[CompilerGenerated]
	private void set_BoarLayer(int value) { }

	[CompilerGenerated]
	private void set_BtrInteractionLayer(int value) { }

	[CompilerGenerated]
	private void set_InteractionsLayer(int value) { }

	[CompilerGenerated]
	private void set_IntroLayer(int value) { }

	[CompilerGenerated]
	private void set_LeftStanceLayer(int value) { }

	[CompilerGenerated]
	private void set_SyncSprintHandsLayer(int value) { }

	[CompilerGenerated]
	private void set_TagilaOverriderLayer(int value) { }

	[CompilerGenerated]
	private void set_TagilaRegularOperationsLayer(int value) { }

	[CompilerGenerated]
	private void set_UtilityOperationLayer(int value) { }

	[CompilerGenerated]
	private void set_WeaponLayer(int value) { }

	public void SetAbsoluteForwardVelocity(float velocity) { }

	public void SetAimAngle(float aimAngle) { }

	public void SetAiming(bool isAiming) { }

	public void SetAlert(bool isAlerted) { }

	public void SetAlertFloat(float alertFloat) { }

	public void SetApproached(bool isInPosition) { }

	public void SetAttack(float attackVariant) { }

	public void SetBehindObstacleRatio(float height) { }

	public void SetBlindFire(float blindFire) { }

	public void SetBlindFireFloat(float blindFireFloatValue) { }

	public void SetBtrGoIn(bool fast) { }

	public void SetBtrGoOut(bool fast) { }

	public void SetBtrLayerEnabled(bool enable) { }

	public void SetCharacterMovementSpeed(float charaterMovementSpeed) { }

	public void SetCharacterSprintSpeed(float speed) { }

	public void SetDeflected(bool deflected) { }

	public void SetDeltaRotation(float handsToBodyAngle) { }

	public void SetDiscreteDirection(float direction) { }

	public void SetDiscreteDirection(EMovementDirection direction) { }

	public void SetDoClimb(bool doClimb) { }

	public void SetDoorBreak(bool isInteracting, bool approached = false) { }

	public void SetDoorInteraction(EDoorInteractionIndex doorInteractionIndex) { }

	public void SetDoVault(bool doVaulting) { }

	public void SetFallingDownFloat(float val) { }

	public void SetFootStep(float val) { }

	public void SetHit(int hitIndex, float hitDirectionY, float hitDirectionX) { }

	public void SetInteraction(bool isInteracting, bool approached = false) { }

	public void SetInventory(bool inventory) { }

	public void SetInventoryOperation(bool isOperation) { }

	public void SetIsGrounded(bool isGrounded) { }

	public void SetIsThirdPerson(bool isItThough) { }

	public void SetIsVaulting(bool isVaulting) { }

	public void SetItemUse(bool enable) { }

	public void SetKickSucceed(bool succeed) { }

	public void SetLayerWeight(int index, float weight) { }

	public void SetLeftStance(bool enabled) { }

	public void SetLeftStanceForceInOneFrame(bool enabled) { }

	internal void SetMalfRepairSpeed(float fix = 1) { }

	public void SetMovementDirection(Vector2 direction) { }

	public void SetPoseLevel(float poseLevel) { }

	public void SetProneBipodMount(bool isProneBipodMounted) { }

	public void SetProneStateForce() { }

	public void SetRemoveLeftHandSpeed(float speed) { }

	public void SetRotationSpeed(float rotationSpeed) { }

	public void SetSidebackSpeed(float speed) { }

	public void SetSidestepFloat(float speed) { }

	internal void SetSpeedParameters(float reload = 1, float draw = 1) { }

	public void SetSprintInertia(float val) { }

	public void SetStationary(bool stationary) { }

	public void SetStationaryType(int index) { }

	public void SetStep(int step) { }

	public void SetSwingSpeed(float swingSpeed) { }

	public void SetTilt(float tilt) { }

	public void SetTransitionSpeed(float speed) { }

	public void SetTurnDeltaAngle(float turnDeltaAngle) { }

	public void SetTurning(bool isTurning) { }

	public void SetTutorialIntro() { }

	public void SetUseLeftHand(bool val) { }

	public void SetVaultingHeight(float height) { }

	public void SetVaultingLength(float length) { }

	public void SetVaultingSpeed(float speed) { }

	public void SetWeaponId(EWeaponAnimationType val) { }

	public void SetWeaponOverlap(float overlap) { }

	public void SetWeaponType(EWeaponAnimationType value) { }

	public void SetWeaponTypeFloat(float value) { }

	[IteratorStateMachine(typeof(<SmoothlyDisableInteractionLayer>d__198))]
	private IEnumerator SmoothlyDisableInteractionLayer() { }

	public void TriggerAttack() { }

	public void TriggerIsLost() { }

	public void UpdateInteractionLayerWeight() { }

	private void UpdateLayerIndexes() { }

	public void UpdateLayersAfterInitialization() { }

}

