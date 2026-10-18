namespace CommonAssets.Scripts.GlobalEventsSystem;

public class ExplosionGlobalImpulseShakeEffectEvent : BaseEvent
{
	public float CameraPositionStrength; //Field offset: 0x18
	public float CameraRotationStrength; //Field offset: 0x1C

	public ExplosionGlobalImpulseShakeEffectEvent() { }

	public void Invoke(float cameraPositionStrength, float cameraRotationStrength) { }

	public virtual void Reset() { }

}

