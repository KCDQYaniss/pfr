namespace EFT.Animations;

public class UtesMachinery : WeaponMachinery
{
	[SerializeField]
	private Transform _hingeJoint1; //Field offset: 0x20
	[SerializeField]
	private Transform _hingeJoint2; //Field offset: 0x28
	[SerializeField]
	private Transform _hingeJoint2DirectionTransform; //Field offset: 0x30
	[SerializeField]
	private Transform _weaponJoint; //Field offset: 0x38
	[SerializeField]
	private Transform _verticalJoint; //Field offset: 0x40

	public UtesMachinery() { }

	public virtual void OnRotation() { }

	public virtual void SetTransforms(TransformLinks hierarchy) { }

	public virtual void UpdateJoints() { }

}

