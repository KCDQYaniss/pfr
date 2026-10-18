//Type is in global namespace

public class TwistRelax : MonoBehaviour
{
	[Range(0, 1)]
	[Tooltip("The weight of relaxing the twist of this Transform")]
	public float weight; //Field offset: 0x20
	[Range(0, 1)]
	[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
	public float parentChildCrossfade; //Field offset: 0x24
	[Tooltip("The parent Transform, does not need to be the actual transform.parent.")]
	public Transform parent; //Field offset: 0x28
	[Tooltip("The child Transform, does not need to be the direct child, you can skip bones in the hierarchy.")]
	public Transform child; //Field offset: 0x30
	[Tooltip("The local axis of this Transform that it will be twisted around (the axis pointing towards the parent).")]
	public Vector3 twistAxis; //Field offset: 0x38
	[Tooltip("Another axis, orthogonal to twistAxis.")]
	public Vector3 axis; //Field offset: 0x44
	[SerializeField]
	private Vector3 _axisRelativeToParentDefault; //Field offset: 0x50
	[SerializeField]
	private Vector3 _axisRelativeToChildDefault; //Field offset: 0x5C

	public TwistRelax() { }

	[ContextMenu("Relax")]
	public void Relax() { }

	[ContextMenu("Store values")]
	private void StoreValues() { }

}

