namespace EFT;

public class PlayerBridge : IObserverToPlayerBridge
{
	[CompilerGenerated]
	private readonly IMovementContextAdapter <MovementContextAdapter>k__BackingField; //Field offset: 0x10
	private Player _player; //Field offset: 0x18

	public override IAIData AIData
	{
		 get { } //Length: 30
	}

	public override float AverageRotationSpeed
	{
		 get { } //Length: 50
	}

	public override float BotSoundCoef
	{
		 get { } //Length: 64
	}

	public override float BushNoiseMultiplier
	{
		 get { } //Length: 205
	}

	public override ICharacterController CharacterController
	{
		 get { } //Length: 29
	}

	public override float CharacterSpeed
	{
		 get { } //Length: 72
	}

	public override EPlayerState CurrentStataName
	{
		 get { } //Length: 48
	}

	public override HitReaction HitReaction
	{
		 get { } //Length: 30
	}

	public override IPlayer iPlayer
	{
		 get { } //Length: 5
	}

	public override bool IsAI
	{
		 get { } //Length: 100
	}

	public override bool IsZombie
	{
		 get { } //Length: 117
	}

	public override string ItemInHandTemplateID
	{
		 get { } //Length: 499
	}

	public override IMovementContextAdapter MovementContextAdapter
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string Nickname
	{
		 get { } //Length: 48
	}

	public override EPointOfView PointOfView
	{
		 get { } //Length: 42
	}

	public override float SoundRadius
	{
		 get { } //Length: 40
	}

	public override Vector3 Velocity
	{
		 get { } //Length: 122
	}

	public override WeaponSoundPlayer WeaponSoundPlayer
	{
		 get { } //Length: 145
	}

	public PlayerBridge(Player player) { }

	public override PlayerHitInfo ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, ShotId shotId) { }

	public override void Dispose() { }

	public override IAIData get_AIData() { }

	public override float get_AverageRotationSpeed() { }

	public override float get_BotSoundCoef() { }

	public override float get_BushNoiseMultiplier() { }

	public override ICharacterController get_CharacterController() { }

	public override float get_CharacterSpeed() { }

	public override EPlayerState get_CurrentStataName() { }

	public override HitReaction get_HitReaction() { }

	public override IPlayer get_iPlayer() { }

	public override bool get_IsAI() { }

	public override bool get_IsZombie() { }

	public override string get_ItemInHandTemplateID() { }

	[CompilerGenerated]
	public override IMovementContextAdapter get_MovementContextAdapter() { }

	public override string get_Nickname() { }

	public override EPointOfView get_PointOfView() { }

	public override float get_SoundRadius() { }

	public override Vector3 get_Velocity() { }

	public override WeaponSoundPlayer get_WeaponSoundPlayer() { }

	public override bool HasBodyPartCollider(Collider col) { }

	public override void ShotReactions(DamageInfo shot, EBodyPart bodyPart) { }

}

