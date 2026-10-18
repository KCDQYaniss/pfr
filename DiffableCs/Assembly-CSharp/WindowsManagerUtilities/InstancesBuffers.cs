namespace WindowsManagerUtilities;

[CreateAssetMenu(menuName = "Windows Manager/Instances Buffers")]
internal class InstancesBuffers : ScriptableObject
{
	public List _allTransforms; //Field offset: 0x18
	public List _allBounds; //Field offset: 0x20
	public List _meshIndex; //Field offset: 0x28
	[SerializeField]
	private List _texturesOffsets; //Field offset: 0x30
	[SerializeField]
	private int _texturesOffsetsCount; //Field offset: 0x38

	public int TexturesOffsetsCount
	{
		 get { } //Length: 4
	}

	public List TexturesOffsetsList
	{
		 get { } //Length: 76
	}

	public InstancesBuffers() { }

	public void AddTextureOffsets(TexturesOffsets offsets) { }

	public void Clear() { }

	public int get_TexturesOffsetsCount() { }

	public List get_TexturesOffsetsList() { }

}

