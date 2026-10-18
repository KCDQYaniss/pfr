namespace Systems.Effects;

public class FireworkEffectSelector : FlareShotEffectSelector
{
	[SerializeField]
	private ParticleSystem _fireworkParticleSystem; //Field offset: 0xA8

	public FireworkEffectSelector() { }

	public virtual void SetFlareEffect(FlareColorType flareColorType, float lifetime) { }

}

