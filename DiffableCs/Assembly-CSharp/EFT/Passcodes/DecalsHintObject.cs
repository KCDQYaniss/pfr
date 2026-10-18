namespace EFT.Passcodes;

public sealed class DecalsHintObject : MonoBehaviour, IHintObject
{
	[SerializeField]
	private StaticDeferredDecal[] _hintSymbols; //Field offset: 0x20
	[SerializeField]
	private EHintDecalsType _decalsType; //Field offset: 0x28

	public DecalsHintObject() { }

	public override void ApplyHint(string formattedHintData) { }

}

