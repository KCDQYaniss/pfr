namespace Systems.Effects;

public class FlareShotEffectSelector : MonoBehaviour
{
	private struct FlareParameters
	{
		public Color32 Color; //Field offset: 0x0
		public float LightIntensity; //Field offset: 0x4
		public float LightRange; //Field offset: 0x8
		public bool CastShadows; //Field offset: 0xC

	}

	[SerializeField]
	private FlareParameters _lightFlareParameters; //Field offset: 0x20
	[SerializeField]
	private FlareParameters _redAirdropFlareParameters; //Field offset: 0x30
	[SerializeField]
	private FlareParameters _greenExitActivateFlareParameters; //Field offset: 0x40
	[SerializeField]
	private FlareParameters _yellowQuestFlareParameters; //Field offset: 0x50
	[SerializeField]
	private FlareParameters _acidGreenFlareParameters; //Field offset: 0x60
	[SerializeField]
	private FlareParameters _blueFlareParameters; //Field offset: 0x70
	[SerializeField]
	[Space(10)]
	private ParticleSystem _flareParticleSystem; //Field offset: 0x80
	[SerializeField]
	private ParticleSystem _smokeParticleSystem; //Field offset: 0x88
	[SerializeField]
	private Light _flareLight; //Field offset: 0x90
	[SerializeField]
	private FlareShotEffectAnimator _flareAnimator; //Field offset: 0x98
	[SerializeField]
	[Space(10)]
	protected FlarePatronSound _flarePatronSound; //Field offset: 0xA0

	public FlareShotEffectSelector() { }

	public override void SetFlareEffect(FlareColorType flareColorType, float lifetime) { }

}

