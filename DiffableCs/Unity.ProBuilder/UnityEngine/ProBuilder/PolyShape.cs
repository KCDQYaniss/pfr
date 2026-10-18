namespace UnityEngine.ProBuilder;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[ProGridsConditionalSnap]
public sealed class PolyShape : MonoBehaviour
{
	public enum PolyEditMode
	{
		None = 0,
		Path = 1,
		Height = 2,
		Edit = 3,
	}

	private ProBuilderMesh m_Mesh; //Field offset: 0x20
	[FormerlySerializedAs("points")]
	[SerializeField]
	internal List m_Points; //Field offset: 0x28
	[FormerlySerializedAs("extrude")]
	[SerializeField]
	private float m_Extrude; //Field offset: 0x30
	[FormerlySerializedAs("polyEditMode")]
	[SerializeField]
	private PolyEditMode m_EditMode; //Field offset: 0x34
	[FormerlySerializedAs("flipNormals")]
	[SerializeField]
	private bool m_FlipNormals; //Field offset: 0x38
	[SerializeField]
	internal bool isOnGrid; //Field offset: 0x39

	public ReadOnlyCollection controlPoints
	{
		 get { } //Length: 182
	}

	public float extrude
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool flipNormals
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	internal ProBuilderMesh mesh
	{
		internal get { } //Length: 320
		internal set { } //Length: 82
	}

	internal PolyEditMode polyEditMode
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	public PolyShape() { }

	public ReadOnlyCollection get_controlPoints() { }

	public float get_extrude() { }

	public bool get_flipNormals() { }

	internal ProBuilderMesh get_mesh() { }

	internal PolyEditMode get_polyEditMode() { }

	private bool IsSnapEnabled() { }

	public void set_extrude(float value) { }

	public void set_flipNormals(bool value) { }

	internal void set_mesh(ProBuilderMesh value) { }

	internal void set_polyEditMode(PolyEditMode value) { }

	public void SetControlPoints(IList points) { }

}

