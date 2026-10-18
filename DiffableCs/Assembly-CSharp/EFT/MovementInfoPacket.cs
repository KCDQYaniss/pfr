namespace EFT;

public struct MovementInfoPacket
{
	private const int MAX_PLAYER_STATE_VALUE = 31; //Field offset: 0x0
	private const int DISCRETE_DIRECTION_MAX_VALUE = 8; //Field offset: 0x0
	private static readonly Vector3Quantizer USUAL_DELTA_POSITION_QUANTIZER; //Field offset: 0x0
	public const float MOVEMENT_DIRECTION_RESOLUTION = 0.015625; //Field offset: 0x0
	public const float PRECISE_POSITION_RESOLUTION_MULTIPLIER = 0.1; //Field offset: 0x0
	public const float USUAL_POSITION_Z_RESOLUTION = 0.001953125; //Field offset: 0x0
	private const float POSITION_CHANCHED_SQR = 9.536743E-07; //Field offset: 0x0
	public const float USUAL_POSITION_X_RESOLUTION = 0.001953125; //Field offset: 0x0
	private const float LOW_POSITION_DELTA_LIMIT = 6; //Field offset: 0x0
	private const int MAX_MOVEMENT_DIR_VALUE = 8; //Field offset: 0x0
	public const float USUAL_POSITION_Y_RESOLUTION = 0.0009765625; //Field offset: 0x0
	private const int MAX_ANIMATOR_STATE_INDEX_VALUE = 70; //Field offset: 0x0
	private static readonly Vector3Quantizer PRECISE_DELTA_POSITION_QUANTIZER; //Field offset: 0x8
	private static readonly Vector3Quantizer PRECISE_NORMAL_QUANTIZER; //Field offset: 0x10
	private static readonly Vector2Quantizer ROTATION_QUANTIZER; //Field offset: 0x18
	private static readonly LimitedFloatSerializationSettings _poseLevelSettings; //Field offset: 0x20
	private static readonly LimitedFloatSerializationSettings _speedSettings; //Field offset: 0x30
	private static readonly LimitedFloatSerializationSettings _tiltSettings; //Field offset: 0x40
	public static Vector2Quantizer MOVEMENT_DIRECTION_QUANTIZER; //Field offset: 0x50
	public bool SyncPositionApplied; //Field offset: 0x0
	public EPlayerState EPlayerState; //Field offset: 0x1
	public int AnimatorStateIndex; //Field offset: 0x4
	public int DiscreteDirection; //Field offset: 0x8
	public float PoseLevel; //Field offset: 0xC
	public float CharacterMovementSpeed; //Field offset: 0x10
	public float Tilt; //Field offset: 0x14
	public int Step; //Field offset: 0x18
	public int BlindFire; //Field offset: 0x1C
	public bool SoftSurface; //Field offset: 0x20
	public bool LeftStance; //Field offset: 0x21
	public StaminaStruct Stamina; //Field offset: 0x22
	public InteractWithDoorPacket InteractWithDoorPacket; //Field offset: 0x28
	public InteractWithBtrPacket InteractWithBtrPacket; //Field offset: 0x48
	public InteractWithTripwirePacket InteractWithTripwirePacket; //Field offset: 0x54
	public InteractWithTransitPacket InteractWithTransitPacket; //Field offset: 0x60
	public InteractWithEventObjectPacket InteractWithEventObjectPacket; //Field offset: 0x78
	public LootInteractionPacket LootInteractionPacket; //Field offset: 0x88
	public StationaryWeaponPacket StationaryWeaponPacket; //Field offset: 0xA0
	public PlantItemPacket PlantItemPacket; //Field offset: 0xB8
	public Vector3 HeadRotation; //Field offset: 0xD0
	public bool IsGrounded; //Field offset: 0xDC
	public Vector3 WeaponPosition; //Field offset: 0xE0
	public Vector3 WeaponRotation; //Field offset: 0xEC
	public Vector3 SurfaceNormal; //Field offset: 0xF8
	public Vector3 PlayerSurfaceUpAlignNormal; //Field offset: 0x104
	public bool FullPositionSync; //Field offset: 0x110
	public VaultingPacket VaultingPacket; //Field offset: 0x114
	public InteractionPacket InteractionPacket; //Field offset: 0x13C
	public InventoryInteractionPacket InventoryInteractionPacket; //Field offset: 0x13F
	public MountingPacket MountingPacket; //Field offset: 0x144
	public LeftHandPacket LeftHandPacket; //Field offset: 0x160

	public bool HasImportantData
	{
		 get { } //Length: 108
	}

	public static Vector3Quantizer PRECISE_POSITION_QUANTIZER
	{
		 get { } //Length: 60
	}

	public static Vector3Quantizer USUAL_POSITION_QUANTIZER
	{
		 get { } //Length: 59
	}

	private static MovementInfoPacket() { }

	public MovementInfoPacket(EPlayerState ePlayerState, int animatorStateIndex, float poseLevel, float characterMovementSpeed, float tilt, int step, int blindFire, InteractWithDoorPacket interactWithDoorPacket, InteractWithBtrPacket interactWithBtrPacket, InteractWithTripwirePacket interactWithTripwirePacket, InteractWithTransitPacket interactWithTransitPacket, InteractWithEventObjectPacket interactWithEventObjectPacket, LootInteractionPacket lootInteractionPacket, StationaryWeaponPacket stationaryWeaponPacket, PlantItemPacket plantItemPacket, bool softSurface, bool leftStance, Vector3 headRotation, StaminaStruct stamina, bool syncPositionApplied, int discreteMovementDirection, bool isGrounded, Vector3 weaponPosition, Vector3 weaponRotation, Vector3 surfaceNormal, Vector3 playerSurfaceUpAlignNormal, bool autoVaultingSettingEnable, VaultingPacket vaultingPacket, InteractionPacket interactionPacket, InventoryInteractionPacket inventoryInteractionPacket, MountingPacket mountingPacket, LeftHandPacket leftHandPacket) { }

	public void ClearCommandRelatedData() { }

	public static void DeserializeDiffUsing(IBitReaderStream reader, ref MovementInfoPacket movementInfoPacket, MovementInfoPacket prevFrame, bool isExtraPrecisionMovement = false) { }

	private static Vector3 DeserializePosition(IBitReaderStream reader, Vector3 prevPosition, bool isExtraPrecisionMovement) { }

	private static Vector2 DeserializeRotation(IBitReaderStream reader, Vector2 prevFrameRotation) { }

	public bool get_HasImportantData() { }

	public static Vector3Quantizer get_PRECISE_POSITION_QUANTIZER() { }

	public static Vector3Quantizer get_USUAL_POSITION_QUANTIZER() { }

	public static void SerializeDiffUsing(IBitWriterStream writer, ref MovementInfoPacket current, MovementInfoPacket prevFrame, bool isExtraPrecisionMovement = false) { }

	private static void SerializeInteractionInfo(IBitWriterStream writer, ref MovementInfoPacket current) { }

	private static void SerializeInventoryInteractionInfo(IBitWriterStream writer, ref MovementInfoPacket current) { }

	private static void SerializeLeftHandInfo(IBitWriterStream writer, ref MovementInfoPacket current) { }

	private static void SerializeMountingInfo(IBitWriterStream writer, ref MovementInfoPacket current) { }

	private static Vector3 SerializePosition(IBitWriterStream writer, Vector3 currentPosition, Vector3 prevFramePosition, bool isExtraPrecisionMovement, bool forceSyncPosition) { }

	private static void SerializeRotation(IBitWriterStream writer, Vector2 currentRotation, Vector2 prevFrameRotation) { }

	private static void SerializeVaultingInfo(IBitWriterStream writer, ref MovementInfoPacket current) { }

	public virtual string ToString() { }

}

