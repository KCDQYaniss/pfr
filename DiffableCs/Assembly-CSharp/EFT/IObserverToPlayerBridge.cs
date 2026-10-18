namespace EFT;

public interface IObserverToPlayerBridge
{

	public IAIData AIData
	{
		 get { } //Length: 0
	}

	public float AverageRotationSpeed
	{
		 get { } //Length: 0
	}

	public float BotSoundCoef
	{
		 get { } //Length: 0
	}

	public float BushNoiseMultiplier
	{
		 get { } //Length: 0
	}

	public ICharacterController CharacterController
	{
		 get { } //Length: 0
	}

	public float CharacterSpeed
	{
		 get { } //Length: 0
	}

	public EPlayerState CurrentStataName
	{
		 get { } //Length: 0
	}

	public HitReaction HitReaction
	{
		 get { } //Length: 0
	}

	public IPlayer iPlayer
	{
		 get { } //Length: 0
	}

	public bool IsAI
	{
		 get { } //Length: 0
	}

	public bool IsZombie
	{
		 get { } //Length: 0
	}

	public string ItemInHandTemplateID
	{
		 get { } //Length: 0
	}

	public IMovementContextAdapter MovementContextAdapter
	{
		 get { } //Length: 0
	}

	public string Nickname
	{
		 get { } //Length: 0
	}

	public EPointOfView PointOfView
	{
		 get { } //Length: 0
	}

	public float SoundRadius
	{
		 get { } //Length: 0
	}

	public Vector3 Velocity
	{
		 get { } //Length: 0
	}

	public WeaponSoundPlayer WeaponSoundPlayer
	{
		 get { } //Length: 0
	}

	public PlayerHitInfo ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, ShotId shotId) { }

	public void Dispose() { }

	public IAIData get_AIData() { }

	public float get_AverageRotationSpeed() { }

	public float get_BotSoundCoef() { }

	public float get_BushNoiseMultiplier() { }

	public ICharacterController get_CharacterController() { }

	public float get_CharacterSpeed() { }

	public EPlayerState get_CurrentStataName() { }

	public HitReaction get_HitReaction() { }

	public IPlayer get_iPlayer() { }

	public bool get_IsAI() { }

	public bool get_IsZombie() { }

	public string get_ItemInHandTemplateID() { }

	public IMovementContextAdapter get_MovementContextAdapter() { }

	public string get_Nickname() { }

	public EPointOfView get_PointOfView() { }

	public float get_SoundRadius() { }

	public Vector3 get_Velocity() { }

	public WeaponSoundPlayer get_WeaponSoundPlayer() { }

	public bool HasBodyPartCollider(Collider col) { }

	public void ShotReactions(DamageInfo shot, EBodyPart bodyPart) { }

}

