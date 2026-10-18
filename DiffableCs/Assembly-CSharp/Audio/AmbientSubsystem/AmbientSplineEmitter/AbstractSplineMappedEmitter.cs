namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

public abstract class AbstractSplineMappedEmitter : MonoBehaviour, IPositionTranslator
{

	public abstract event Action Emitted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action StartEmit
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract event Action Stopped
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public abstract Vector3 EmitterPosition
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected AbstractSplineMappedEmitter() { }

	[CompilerGenerated]
	public abstract void add_Emitted(Action value) { }

	[CompilerGenerated]
	public abstract void add_StartEmit(Action value) { }

	[CompilerGenerated]
	public abstract void add_Stopped(Action value) { }

	private void Awake() { }

	public abstract void FadeIn(float fadeInSec) { }

	public abstract void FadeOut(float fadeOutSec) { }

	public abstract Vector3 get_EmitterPosition() { }

	protected override void OnAwake() { }

	protected override void OnDestroy() { }

	[CompilerGenerated]
	public abstract void remove_Emitted(Action value) { }

	[CompilerGenerated]
	public abstract void remove_StartEmit(Action value) { }

	[CompilerGenerated]
	public abstract void remove_Stopped(Action value) { }

	public abstract void ScaleMaxDistance(float value) { }

	protected abstract void set_EmitterPosition(Vector3 value) { }

	public abstract void SetSpreadRange(Vector2 spreadRange) { }

	public abstract void Translate(Vector3 position) { }

	public abstract void UpdateSpatialBlend(float value) { }

	public abstract void UpdateSpread(float value) { }

}

