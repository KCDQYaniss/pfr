namespace EFT.Animations;

public abstract class WeaponMachinery : MonoBehaviour
{

	protected WeaponMachinery() { }

	public abstract void OnRotation() { }

	public abstract void SetTransforms(TransformLinks hierarchy) { }

	public abstract void UpdateJoints() { }

}

