namespace EFT.Visual;

public class FoldableStockView : MonoBehaviour, IDress
{
	internal class BonePosition
	{
		public string BoneName; //Field offset: 0x10
		public Transform Bone; //Field offset: 0x18
		public Quaternion FoldedRotation; //Field offset: 0x20
		public Quaternion UnfoldedRotation; //Field offset: 0x30

		public BonePosition() { }

	}

	[SerializeField]
	private BonePosition[] _bonePositions; //Field offset: 0x20
	private FoldableComponent _foldable; //Field offset: 0x28
	private Action _subscription; //Field offset: 0x30

	public FoldableStockView() { }

	[CompilerGenerated]
	private void <Init>b__4_0() { }

	public override void Deinit() { }

	public override void Init(Item item, bool isAnimated) { }

}

