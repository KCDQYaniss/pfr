namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

public sealed class AmbientPlayerSplineMappedEmitter : AbstractSplineMappedEmitter
{
	[SerializeField]
	private BaseAmbientSoundPlayer _soundPlayer; //Field offset: 0x20
	[SerializeField]
	private Vector2 _spreadRange; //Field offset: 0x28
	private Transform _cachedTransform; //Field offset: 0x30
	[CompilerGenerated]
	private Vector3 <EmitterPosition>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Action StartEmit; //Field offset: 0x48
	[CompilerGenerated]
	private Action Emitted; //Field offset: 0x50
	[CompilerGenerated]
	private Action Stopped; //Field offset: 0x58

	public virtual event Action Emitted
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public virtual event Action StartEmit
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public virtual event Action Stopped
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public virtual Vector3 EmitterPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public AmbientPlayerSplineMappedEmitter() { }

	[CompilerGenerated]
	public virtual void add_Emitted(Action value) { }

	[CompilerGenerated]
	public virtual void add_StartEmit(Action value) { }

	[CompilerGenerated]
	public virtual void add_Stopped(Action value) { }

	public virtual void FadeIn(float fadeInSec) { }

	public virtual void FadeOut(float fadeOutSec) { }

	[CompilerGenerated]
	public virtual Vector3 get_EmitterPosition() { }

	protected virtual void OnAwake() { }

	protected virtual void OnDestroy() { }

	private void PlayedHandler() { }

	[CompilerGenerated]
	public virtual void remove_Emitted(Action value) { }

	[CompilerGenerated]
	public virtual void remove_StartEmit(Action value) { }

	[CompilerGenerated]
	public virtual void remove_Stopped(Action value) { }

	public virtual void ScaleMaxDistance(float value) { }

	[CompilerGenerated]
	protected virtual void set_EmitterPosition(Vector3 value) { }

	public virtual void SetSpreadRange(Vector2 spreadRange) { }

	private void StartPlayHandler() { }

	private void StoppedHandler() { }

	public virtual void Translate(Vector3 newPos) { }

	public virtual void UpdateSpatialBlend(float value) { }

	public virtual void UpdateSpread(float value) { }

}

