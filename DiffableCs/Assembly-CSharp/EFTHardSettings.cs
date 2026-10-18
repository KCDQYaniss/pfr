//Type is in global namespace

public sealed class EFTHardSettings : ScriptableObject
{
	[CompilerGenerated]
	private struct <Load>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private ResourceRequest <loadOperation>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class ShellsSettings
	{
		public float radius; //Field offset: 0x10
		[Tooltip("Playback speed")]
		public float playMult; //Field offset: 0x14
		[Tooltip("Bigger value for better smoothness")]
		public int maxCastCount; //Field offset: 0x18
		public float deltaTimeStep; //Field offset: 0x1C
		public float randomReboundSpread; //Field offset: 0x20
		[Tooltip("intial speed")]
		public float velocityMult; //Field offset: 0x24
		public float velocityRotation; //Field offset: 0x28
		public float bounceSpeedMult; //Field offset: 0x2C
		public float enforceSurfaceNormals; //Field offset: 0x30
		public Vector2 ReboundRotationX; //Field offset: 0x34
		public Vector2 ReboundRotationY; //Field offset: 0x3C
		public Vector2 ReboundRotationZ; //Field offset: 0x44
		public bool showDebug; //Field offset: 0x4C

		public ShellsSettings() { }

	}

	public const string PATH = "eftsettings"; //Field offset: 0x0
	private static EFTHardSettings _instance; //Field offset: 0x0
	public AnimationCurve PoseInertiaDamp; //Field offset: 0x18
	public AnimationCurve SpeedLimitAfterFall; //Field offset: 0x20
	public AnimationCurve SpeedLimitDuration; //Field offset: 0x28
	public AnimationCurve PoseInertiaOverFallDistance; //Field offset: 0x30
	public AnimationCurve CrouchAccelerationWeightRange; //Field offset: 0x38
	public AnimationCurve MovementAccelerationRange; //Field offset: 0x40
	public float IdleStateMotionPreservation; //Field offset: 0x48
	public float InertiaInputMaxSpeed; //Field offset: 0x4C
	public float DecelerationSpeed; //Field offset: 0x50
	public AnimationCurve InertiaTiltCurve; //Field offset: 0x58
	public float StartingSprintSpeed; //Field offset: 0x60
	public AnimationCurve sprintSpeedInertiaCurve; //Field offset: 0x68
	public AnimationCurve PlaneHeightChangeCurve; //Field offset: 0x70
	public AnimationCurve PlaneVolumeCurve; //Field offset: 0x78
	public AnimationCurve AdditionalTimeCurve; //Field offset: 0x80
	[Header("Airdrop")]
	public float WindFactor; //Field offset: 0x88
	public float WindTurningOffHeight; //Field offset: 0x8C
	public float ShakingCoef; //Field offset: 0x90
	public float ShakingTime; //Field offset: 0x94
	public Vector3 DebugWind; //Field offset: 0x98
	[Header("Swing")]
	public float TiltAngleDeceleration; //Field offset: 0xA4
	public float SwingSpeed; //Field offset: 0xA8
	public float MinTiltAngle; //Field offset: 0xAC
	public float MaxTiltAngle; //Field offset: 0xB0
	public float MinSwingValue; //Field offset: 0xB4
	[Header("Torque")]
	public float MaxTorque; //Field offset: 0xB8
	public float TorqueDeceleration; //Field offset: 0xBC
	public float ToqueMinValue; //Field offset: 0xC0
	public float DeltaTimeModificator; //Field offset: 0xC4
	public AnimationCurve XPositionCurve; //Field offset: 0xC8
	public AnimationCurve YPositionCurve; //Field offset: 0xD0
	public AnimationCurve ZPositionCurve; //Field offset: 0xD8
	public AnimationCurve XRotationCurve; //Field offset: 0xE0
	public AnimationCurve YRotationCurve; //Field offset: 0xE8
	public AnimationCurve ZRotationCurve; //Field offset: 0xF0
	[NotNull]
	public AnimationCurve DoorCurve; //Field offset: 0xF8
	public EPlayerState[] UnsuitableStates; //Field offset: 0x100
	public float TinnitusEffectSpeedMultiplier; //Field offset: 0x108
	public AnimationCurve TinnitusSound; //Field offset: 0x110
	public AnimationCurve TinnitusLowpas; //Field offset: 0x118
	public AnimationCurve MainChannelLevel; //Field offset: 0x120
	public AnimationCurve StairsSoundOcclusionCurve; //Field offset: 0x128
	[Range(0, 2)]
	public float VerticalSoundFactor; //Field offset: 0x130
	public float SoundOcclusionUpdateInterval; //Field offset: 0x134
	public float SoundOcclusionWidening; //Field offset: 0x138
	public float ListenerOcclusionWidening; //Field offset: 0x13C
	public float OcclusionHeight; //Field offset: 0x140
	public bool DebugRays; //Field offset: 0x144
	public Vector3[] BleedingCenters; //Field offset: 0x148
	public float MAXIMUM_BODYPART_VELOCITY; //Field offset: 0x150
	public float HIT_FORCE; //Field offset: 0x154
	public float AIR_CONTROL_SAME_DIR; //Field offset: 0x158
	public float AIR_CONTROL_BACK_DIR; //Field offset: 0x15C
	public float AIR_CONTROL_NONE_OR_ORT_DIR; //Field offset: 0x160
	public float JumpTimeDescendingForStateEnter; //Field offset: 0x164
	public float JumpTimeDescendingForStateExit; //Field offset: 0x168
	public float ObservedJumpTimeDescendingForStateExit; //Field offset: 0x16C
	public float VaultingClimbOverTimeDescendingForStateEnter; //Field offset: 0x170
	public float VaultingClimbUpTimeDescendingForStateEnter; //Field offset: 0x174
	public float PICKUP_DELAY; //Field offset: 0x178
	public AnimationCurve CURVA; //Field offset: 0x180
	public float LOOT_RAYCAST_DISTANCE; //Field offset: 0x188
	public float DOOR_RAYCAST_DISTANCE; //Field offset: 0x18C
	public float BEHIND_CAST; //Field offset: 0x190
	public float PLAYER_RAYCAST_DISTANCE; //Field offset: 0x194
	public float CULL_RECOIL; //Field offset: 0x198
	public float CULL_GROUNDER; //Field offset: 0x19C
	public float CULL_GROUNDER_QUALITY; //Field offset: 0x1A0
	[Header("Player.AudioController")]
	public AnimationCurve SoundRolloff; //Field offset: 0x1A8
	public AnimationCurve SpreadCurve; //Field offset: 0x1B0
	public AnimationCurve LandingVolumeCurve; //Field offset: 0x1B8
	[Range(0, 0.5)]
	public float SpeechInterruptFadeSec; //Field offset: 0x1C0
	[Min(0)]
	public float CoughLoopIntervalSec; //Field offset: 0x1C4
	public float TURN_SOUND_DELAY; //Field offset: 0x1C8
	public float TURN_ANGLE; //Field offset: 0x1CC
	public float GEAR_SOUND_DELAY; //Field offset: 0x1D0
	public AnimationCurve LOWER_LOWPASS; //Field offset: 0x1D8
	public AnimationCurve UPPER_LOWPASS; //Field offset: 0x1E0
	public LayerMask GunshotMask; //Field offset: 0x1E8
	public LayerMask BaseMask; //Field offset: 0x1EC
	public Vector2 VERTICAL_DOT_RANGE; //Field offset: 0x1F0
	public Vector2 VERTICAL_DOT_RANGE_STAIRS; //Field offset: 0x1F8
	public AnimationCurve VOLUME_BY_FLOOR_THICKNESS; //Field offset: 0x200
	public bool SqrRootDecay; //Field offset: 0x208
	public Vector2 ABOVE_OR_BELOW; //Field offset: 0x20C
	public Vector2 ABOVE_OR_BELOW_STAIRS; //Field offset: 0x214
	[Header("Weapon")]
	public float STOP_AIMING_AT; //Field offset: 0x21C
	public bool OFFSET_FOLDED_WEAPON; //Field offset: 0x220
	public double IDLING_MAX_TIME; //Field offset: 0x228
	public EMalfunctionState FORCE_MALFUNCTION; //Field offset: 0x230
	public bool FORCE_MALFUNCTION_LOOPED; //Field offset: 0x234
	public bool FORCE_MALFUNCTION_ONCE; //Field offset: 0x235
	public bool NEXT_MALF_IS_UNKNOWN; //Field offset: 0x236
	public float FORCE_NEXT_MALF_CHANCE; //Field offset: 0x238
	public int FORCE_MALFUNCTION_IN_SHOT; //Field offset: 0x23C
	public LayerMask WEAPON_OCCLUSION_LAYERS; //Field offset: 0x240
	public LayerMask WEAPON_OCCLUSION_SERVER_LAYERS; //Field offset: 0x244
	public bool OVERHEAT_ALLOW_REDUCE_COI; //Field offset: 0x248
	public bool OVERHEAT_ALLOW_BARREL_MOVE; //Field offset: 0x249
	public float OVERHEAT_INCREASE_MULT; //Field offset: 0x24C
	public float DURABILITY_LOSS_MULT; //Field offset: 0x250
	public float SCOPE_ROTATION_THRESHOLD; //Field offset: 0x254
	[Header("Shell Shot Extraction")]
	public Vector2 SHELLS_EXCTRACT_FORCE_X_RANGE; //Field offset: 0x258
	public Vector2 SHELLS_EXCTRACT_FORCE_Y_RANGE; //Field offset: 0x260
	public Vector2 SHELLS_EXCTRACT_FORCE_Z_RANGE; //Field offset: 0x268
	public Vector2 SHELLS_EXCTRACT_ROTATION_RANGE_X; //Field offset: 0x270
	public Vector2 SHELLS_EXCTRACT_ROTATION_RANGE_Y; //Field offset: 0x278
	public Vector2 SHELLS_EXCTRACT_ROTATION_RANGE_Z; //Field offset: 0x280
	public float SHELL_FORCE_MULTIPLIER; //Field offset: 0x288
	[Header("Shell MISFIRE Extraction")]
	public Vector2 SHELLS_MISFIRE_FORCE_X_RANGE; //Field offset: 0x28C
	public Vector2 SHELLS_MISFIRE_FORCE_Y_RANGE; //Field offset: 0x294
	public Vector2 SHELLS_MISFIRE_FORCE_Z_RANGE; //Field offset: 0x29C
	public Vector2 SHELLS_MISFIRE_ROTATION_RANGE_X; //Field offset: 0x2A4
	public Vector2 SHELLS_MISFIRE_ROTATION_RANGE_Y; //Field offset: 0x2AC
	public Vector2 SHELLS_MISFIRE_ROTATION_RANGE_Z; //Field offset: 0x2B4
	[Header("Shell JAM Extraction")]
	public Vector2 SHELLS_JAM_FORCE_X_RANGE; //Field offset: 0x2BC
	public Vector2 SHELLS_JAM_FORCE_Y_RANGE; //Field offset: 0x2C4
	public Vector2 SHELLS_JAM_FORCE_Z_RANGE; //Field offset: 0x2CC
	public Vector2 SHELLS_JAM_ROTATION_RANGE_X; //Field offset: 0x2D4
	public Vector2 SHELLS_JAM_ROTATION_RANGE_Y; //Field offset: 0x2DC
	public Vector2 SHELLS_JAM_ROTATION_RANGE_Z; //Field offset: 0x2E4
	[Header("Grenade")]
	public float GrenadeForce; //Field offset: 0x2EC
	public ForceMode GrenadeForceMode; //Field offset: 0x2F0
	[Header("Visual Effects")]
	public bool PLAYER_HIT_DECALS_ENEBLED; //Field offset: 0x2F4
	public bool HIT_EFFECTS_ENABLED; //Field offset: 0x2F5
	public bool HEAT_EMITTER_ENABLED; //Field offset: 0x2F6
	public bool SHOT_EFFECTS_ENABLED; //Field offset: 0x2F7
	public bool DEFERRED_DECALS_ENABLED; //Field offset: 0x2F8
	public bool STATIC_DEFERRED_DECALS_ENABLED; //Field offset: 0x2F9
	[Header("Player")]
	public AnimationCurve SprintSpeedImitatorCurve; //Field offset: 0x300
	public AnimationCurve WalkSpeedImitatorCurve; //Field offset: 0x308
	public AnimationCurve ObservedPlayerStepsImitatorCurve; //Field offset: 0x310
	public AnimationCurve ObservedPlayerSprintImitatorCurve; //Field offset: 0x318
	public float SIDESTEP_TO_MOVE_DURATION; //Field offset: 0x320
	public float HumanPyramidExtraDepenetration; //Field offset: 0x324
	public float HumanPyramidSlopeLength; //Field offset: 0x328
	public bool IS_CHARACTER_SPEED_OVERRIDDEN; //Field offset: 0x32C
	[Range(0, 1)]
	public float OVERRIDDEN_CHARACTER_SPEED; //Field offset: 0x330
	public float PRONE_ALIGN_SPEED; //Field offset: 0x334
	public AnimationCurve SWAY_STRENGTH_PER_KG; //Field offset: 0x338
	public AnimationCurve DISPLACEMENT_STRENGTH_PER_KG; //Field offset: 0x340
	public Vector2 MOUSE_LOOK_HORIZONTAL_LIMIT; //Field offset: 0x348
	public Vector2 MOUSE_LOOK_VERTICAL_LIMIT; //Field offset: 0x350
	public float MOUSE_LOOK_LIMIT_IN_AIMING_COEF; //Field offset: 0x358
	[SerializeField]
	private EPlayerState[] NO_AIM_STATES; //Field offset: 0x360
	public float DELTA_SPEED; //Field offset: 0x368
	public Vector2 SWAY_DAMPING_NORMAL_DAMAGED; //Field offset: 0x36C
	public Vector2 SWAY_FREQ_NORMAL_DAMAGED; //Field offset: 0x374
	public float DELTA_LEVEL; //Field offset: 0x37C
	public float DIRECTION_LERP_SPEED; //Field offset: 0x380
	public float HANDS_TO_BODY_MAX_ANGLE; //Field offset: 0x384
	public float POSE_CHANGING_SPEED; //Field offset: 0x388
	public float TILT_CHANGING_SPEED; //Field offset: 0x38C
	public float CHARACTER_SPEED_CHANGING_SPEED; //Field offset: 0x390
	public float TRANSFORM_ROTATION_LERP_SPEED; //Field offset: 0x394
	public AnimationCurve DIRECTION_CURVE; //Field offset: 0x398
	public AnimationCurve LIFT_VELOCITY_BY_SPEED; //Field offset: 0x3A0
	public AnimationCurve JUMP_DELAY_BY_SPEED; //Field offset: 0x3A8
	public float AIR_MIN_SPEED; //Field offset: 0x3B0
	public float AIR_LERP; //Field offset: 0x3B4
	public LayerMask MOVEMENT_MASK; //Field offset: 0x3B8
	public bool MED_EFFECT_USING_PANEL; //Field offset: 0x3BC
	[Header("Roll State Parameters")]
	public bool UseRibcage; //Field offset: 0x3BD
	public Vector3 RollCheckShift; //Field offset: 0x3C0
	public Vector3 RollCheckSize; //Field offset: 0x3CC
	public Vector3 ProneTiltCheckShift; //Field offset: 0x3D8
	public Vector3 ProneTiltCheckSize; //Field offset: 0x3E4
	public float RollCheckGroundCastLength; //Field offset: 0x3F0
	[Header("Ballistic")]
	public BallisticPreset[] ColliderPresets; //Field offset: 0x3F8
	public float DECAL_SHIFT; //Field offset: 0x400
	public float AIM_PROCEDURAL_INTENSITY; //Field offset: 0x404
	public float PROCEDURAL_INTENSITY_AT_ZERO_LEVEL_POSE; //Field offset: 0x408
	[Header("BallisticEffects")]
	public float DRAW_BLOOD_ON_WALLS_MAX_DISTANCE; //Field offset: 0x40C
	public float DRAW_BLEEDING_MAX_DISTANCE; //Field offset: 0x410
	public LayerMask ENVIRONMENT_HIT_MASK; //Field offset: 0x414
	public bool DRAW_DEFERRED_DECALS; //Field offset: 0x418
	[Header("Door")]
	public float DOOR_BREACH_THRESHOLD; //Field offset: 0x41C
	[Header("Icons")]
	public StaticIcons StaticIcons; //Field offset: 0x420
	public ChatSpecialIconSettings ChatSpecialIconSettings; //Field offset: 0x428
	public SeasonsRanksConfig SeasonsRanksConfig; //Field offset: 0x430
	public SeasonCarouselData SeasonsIntroCarouselData; //Field offset: 0x438
	public SeasonCarouselData SeasonsLeaguesCarouselData; //Field offset: 0x440
	public Quaternion[] LEFT_HAND_QTS; //Field offset: 0x448
	public Quaternion[] RIGHT_HAND_QTS; //Field offset: 0x450
	[Header("Culling")]
	public float CULLING_PLAYER_SPHERE_RADIUS; //Field offset: 0x458
	public float CULLING_PLAYER_SPHERE_DEAD_BODY_RADIUS; //Field offset: 0x45C
	public Vector3 CULLING_PLAYER_SPHERE_SHIFT; //Field offset: 0x460
	public float CULLING_PLAYER_DEAD_BODY_DISTANCE; //Field offset: 0x46C
	public float CULLING_PLAYER_DISTANCE; //Field offset: 0x470
	public float CULLING_PLAYER_BALLISTICS_ANGLE; //Field offset: 0x474
	public float PATRONS_MANIPULATIONS_VISIBLE_DISTANCE; //Field offset: 0x478
	public float FLYING_SHELLS_VISIBLE_DISTANCE; //Field offset: 0x47C
	[Header("-------- Simple character controller")]
	public float SIMPLE_CHARACTER_CONTROLLER_FIXED_DELTA_DISTANCE; //Field offset: 0x480
	public LayerMask TriggersCastLayerMask; //Field offset: 0x484
	public LayerMask TriggersCastLayerMaskForObservedPlayers; //Field offset: 0x488
	public LayerMask ServerTriggersCastLayerMask; //Field offset: 0x48C
	public float HoboCastTimeBreakInterval; //Field offset: 0x490
	public float DelayToOpenContainer; //Field offset: 0x494
	public float GrenadeFullSyncDelay; //Field offset: 0x498
	public bool DisableDoorColliderOnInteraction; //Field offset: 0x49C
	public float AnimatorCullDistance; //Field offset: 0x4A0
	public AnimationCurve StrafeInertionCurve; //Field offset: 0x4A8
	public float StrafeInertionCoefficient; //Field offset: 0x4B0
	[Header("Shells")]
	public ShellsSettings Shells; //Field offset: 0x4B8
	[Tooltip("This option will enable high quallity physics simulation if loot volume (size.x * size.y * size.z) is less than value\nNote: Continuous Collision Detection is only supported for Rigidbodies with Sphere-, Capsule- or BoxColliders")]
	public float LootVolumeForHighQuallityPhysicsClient; //Field offset: 0x4C0
	public float LootVolumeForHighQuallityPhysicsServer; //Field offset: 0x4C4
	public float ThrowLootMakeVisibleDelay; //Field offset: 0x4C8
	[Header("Corpse")]
	public float CorpseEnergyToSleep; //Field offset: 0x4CC
	public float CorpseMaxDepenetrationVelocity; //Field offset: 0x4D0
	public float CorpseApplyHardSyncMinDistanceSqr; //Field offset: 0x4D4
	public float MaxSmoothPhysicsDeltaTime; //Field offset: 0x4D8
	private HashSet _noAimStatesHashSet; //Field offset: 0x4E0
	public bool DEBUG_CORPSE_PHYSICS; //Field offset: 0x4E8

	public static EFTHardSettings Instance
	{
		 get { } //Length: 456
	}

	public EFTHardSettings() { }

	public bool CanAimInState(EPlayerState currentStateName) { }

	public static EFTHardSettings get_Instance() { }

	public BallisticPreset GetPresetFromCollider(BallisticCollider collider) { }

	[AsyncStateMachine(typeof(<Load>d__41))]
	public static Task Load() { }

	public static void Set(string key, string value) { }

}

