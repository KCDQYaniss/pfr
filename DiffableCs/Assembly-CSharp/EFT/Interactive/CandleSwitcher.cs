namespace EFT.Interactive;

public sealed class CandleSwitcher : MonoBehaviour, ILightSwitcher
{
	[SerializeField]
	private MeshRenderer _meshRenderer; //Field offset: 0x20
	[SerializeField]
	private Material _emissionOnShader; //Field offset: 0x28
	[SerializeField]
	private Material _emissionOffShader; //Field offset: 0x30
	private bool _enabled; //Field offset: 0x38

	public override bool Enabled
	{
		 get { } //Length: 5
		 set { } //Length: 280
	}

	public CandleSwitcher() { }

	public override bool get_Enabled() { }

	private bool HasMeshRenderer() { }

	public override void set_Enabled(bool value) { }

	public override void Switch(EState switchTo) { }

	public override void TurnOff() { }

	public override void TurnOn() { }

}

