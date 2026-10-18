namespace WindowsManagerUtilities;

[CreateAssetMenu(menuName = "Windows Manager/Scene Data Container")]
internal class SceneDataContainer : ScriptableObject
{
	[SerializeField]
	public List _verticesInstances; //Field offset: 0x18
	[SerializeField]
	public List _verticesLocalOffsets; //Field offset: 0x20
	[SerializeField]
	public List _meshesOffsetsList; //Field offset: 0x28
	[SerializeField]
	public List _meshesVerticesCount; //Field offset: 0x30
	[SerializeField]
	public List _instanceIdToStartVertexId; //Field offset: 0x38

	public SceneDataContainer() { }

}

