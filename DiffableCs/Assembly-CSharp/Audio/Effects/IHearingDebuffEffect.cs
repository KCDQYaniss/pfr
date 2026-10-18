namespace Audio.Effects;

public interface IHearingDebuffEffect
{

	public void Reset() { }

	public void SetDebuff(float debuffPercentage, float fadeTime = 1, Action onComplete = null) { }

}

