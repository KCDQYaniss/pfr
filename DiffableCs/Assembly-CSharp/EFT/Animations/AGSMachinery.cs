namespace EFT.Animations;

public class AGSMachinery : WeaponMachinery
{
	private Transform _target; //Field offset: 0x20
	private Transform _lever; //Field offset: 0x28
	private Transform _verticalPart; //Field offset: 0x30
	private Transform _scope; //Field offset: 0x38

	public AGSMachinery() { }

	public virtual void OnRotation() { }

	public virtual void SetTransforms(TransformLinks hierarchy) { }

	public virtual void UpdateJoints() { }

}

