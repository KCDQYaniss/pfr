//Type is in global namespace

public class ArmorPlateCollider : BodyPartCollider
{
	public EArmorPlateCollider ArmorPlateColliderType; //Field offset: 0xB0

	public ArmorPlateCollider() { }

	public virtual PlayerHitInfo ApplyHit(DamageInfo damageInfo, ShotId shotID) { }

	protected virtual void InitColliderSettings() { }

}

