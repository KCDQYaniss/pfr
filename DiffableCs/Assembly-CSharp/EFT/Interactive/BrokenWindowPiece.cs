namespace EFT.Interactive;

public struct BrokenWindowPiece
{
	public GameObject GameObject; //Field offset: 0x0
	public Transform Transform; //Field offset: 0x8
	public MeshFilter MeshFilter; //Field offset: 0x10
	public MeshRenderer MeshRenderer; //Field offset: 0x18
	public MeshCollider MeshCollider; //Field offset: 0x20
	public BallisticCollider BallisticCollider; //Field offset: 0x28
	public Transform ChildTransform; //Field offset: 0x30
	public BoxCollider ChildBoxCollider; //Field offset: 0x38
	public BrokenWindowPieceCollider ChildFragileCollider; //Field offset: 0x40

}

