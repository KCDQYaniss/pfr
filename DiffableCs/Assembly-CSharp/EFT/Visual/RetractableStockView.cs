namespace EFT.Visual;

public class RetractableStockView : MonoBehaviour, IDress
{
	internal struct BonePosition
	{
		public string BoneName; //Field offset: 0x0
		public Transform Bone; //Field offset: 0x8
		public Vector3 RetractedPosition; //Field offset: 0x10
		public Vector3 NormalPosition; //Field offset: 0x1C

	}

	[SerializeField]
	private BonePosition[] _bonePositions; //Field offset: 0x20
	private FoldableComponent _foldable; //Field offset: 0x28
	private Action _subscription; //Field offset: 0x30

	public RetractableStockView() { }

	[CompilerGenerated]
	private void <Init>b__4_0() { }

	public override void Deinit() { }

	public override void Init(Item item, bool isAnimated) { }

}

