namespace EFT.Interactive;

public sealed class BrokenWindowPieceTemplate : MonoBehaviour
{
	[SerializeField]
	private MeshFilter _meshFilter; //Field offset: 0x20
	[SerializeField]
	private MeshRenderer _meshRenderer; //Field offset: 0x28
	[SerializeField]
	private MeshCollider _meshCollider; //Field offset: 0x30
	[SerializeField]
	private BallisticCollider _ballisticCollider; //Field offset: 0x38
	[SerializeField]
	private GameObject _child; //Field offset: 0x40
	[SerializeField]
	private BoxCollider _childBoxCollider; //Field offset: 0x48
	[SerializeField]
	private BrokenWindowPieceCollider _childFragileGlassCollider; //Field offset: 0x50

	public BrokenWindowPieceTemplate() { }

	public BrokenWindowPiece GetPiece() { }

}

