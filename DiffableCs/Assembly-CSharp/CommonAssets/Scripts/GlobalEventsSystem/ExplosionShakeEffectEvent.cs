namespace CommonAssets.Scripts.GlobalEventsSystem;

public class ExplosionShakeEffectEvent : BaseEvent
{
	public Vector3 ExplosionPosition; //Field offset: 0x18
	public float MaxReactionDistanceSqr; //Field offset: 0x24
	public float ExponentValue; //Field offset: 0x28
	public CustomExplosionShakeSettings ExplosionShakeSettings; //Field offset: 0x30

	public ExplosionShakeEffectEvent() { }

	public void Invoke(Vector3 explosionPosition, float maxReactionDistance, float exponentValue, CustomExplosionShakeSettings explosionShakeSettings) { }

	public virtual void Reset() { }

}

