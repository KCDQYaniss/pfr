namespace EFT;

public class HitReactionCharacter : MonoBehaviour
{
	[SerializeField]
	private string mixingAnim; //Field offset: 0x20
	[SerializeField]
	private Transform recursiveMixingTransform; //Field offset: 0x28
	[SerializeField]
	private Camera cam; //Field offset: 0x30
	[SerializeField]
	private HitReaction hitReaction; //Field offset: 0x38
	[SerializeField]
	private float hitForce; //Field offset: 0x40

	public HitReactionCharacter() { }

	private void Update() { }

}

