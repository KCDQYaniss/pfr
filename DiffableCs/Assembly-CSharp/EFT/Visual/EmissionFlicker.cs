namespace EFT.Visual;

public class EmissionFlicker : Flicker
{
	private static readonly int _emissionVisibility; //Field offset: 0x0
	[SerializeField]
	private MeshRenderer _meshRenderer; //Field offset: 0x48
	private float _intensity; //Field offset: 0x50
	private MaterialPropertyBlock _mpb; //Field offset: 0x58

	private float EmissionVisibility
	{
		private get { } //Length: 6
		private set { } //Length: 264
	}

	private static EmissionFlicker() { }

	public EmissionFlicker() { }

	protected virtual void Awake() { }

	private float get_EmissionVisibility() { }

	private void Init() { }

	public virtual void ManualUpdate() { }

	protected virtual void OnDestroy() { }

	private void set_EmissionVisibility(float value) { }

}

