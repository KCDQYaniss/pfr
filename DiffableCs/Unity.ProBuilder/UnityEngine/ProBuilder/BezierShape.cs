namespace UnityEngine.ProBuilder;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[RequireComponent(typeof(ProBuilderMesh))]
internal sealed class BezierShape : MonoBehaviour
{
	public List points; //Field offset: 0x20
	public bool closeLoop; //Field offset: 0x28
	public float radius; //Field offset: 0x2C
	public int rows; //Field offset: 0x30
	public int columns; //Field offset: 0x34
	public bool smooth; //Field offset: 0x38
	[SerializeField]
	private bool m_IsEditing; //Field offset: 0x39
	private ProBuilderMesh m_Mesh; //Field offset: 0x40

	public bool isEditing
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public ProBuilderMesh mesh
	{
		 get { } //Length: 320
		 set { } //Length: 82
	}

	public BezierShape() { }

	public bool get_isEditing() { }

	public ProBuilderMesh get_mesh() { }

	public void Init() { }

	public void Refresh() { }

	public void set_isEditing(bool value) { }

	public void set_mesh(ProBuilderMesh value) { }

}

