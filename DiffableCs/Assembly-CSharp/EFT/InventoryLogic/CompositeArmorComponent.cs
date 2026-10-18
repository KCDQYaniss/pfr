namespace EFT.InventoryLogic;

public class CompositeArmorComponent : ArmorComponent
{
	[CanBeNull]
	public readonly TogglableComponent Togglable; //Field offset: 0x30

	public CompositeArmorComponent(Item item, IArmorComponentTemplate template, RepairableComponent repairable, TogglableComponent togglable, BuffComponent buff) { }

	public virtual bool ShotMatches(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider) { }

}

