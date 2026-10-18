namespace RootMotion.FinalIK;

public class GenericPoser : Poser
{
	internal class Map
	{
		public Transform bone; //Field offset: 0x10
		public Transform target; //Field offset: 0x18
		private Vector3 defaultLocalPosition; //Field offset: 0x20
		private Quaternion defaultLocalRotation; //Field offset: 0x2C

		public Map(Transform bone, Transform target) { }

		public void FixTransform() { }

		public void StoreDefaultState() { }

		public void Update(float localRotationWeight, float localPositionWeight) { }

	}

	public Map[] maps; //Field offset: 0x38

	public GenericPoser() { }

	[ContextMenu("Auto-Mapping")]
	public virtual void AutoMapping() { }

	public virtual void FixTransforms() { }

	private Transform GetTargetNamed(string tName, Transform[] array) { }

	private void LateUpdate() { }

	public virtual void StoreDefaultState() { }

}

