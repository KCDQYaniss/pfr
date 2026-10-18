namespace EFT.RocketLauncher.Explosion;

public interface IExplosionPropagationModel
{
	internal sealed class OnColliderDetected : MulticastDelegate
	{

		public OnColliderDetected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Collider collider, ComputableUnit unit, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(Collider collider, ComputableUnit unit) { }

	}


	public event OnColliderDetected OnColliderDetectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IEnumerable RandomInnerGrid
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnColliderDetectedEvent(OnColliderDetected value) { }

	public IEnumerable get_RandomInnerGrid() { }

	[CompilerGenerated]
	public void remove_OnColliderDetectedEvent(OnColliderDetected value) { }

	public IEnumerator StartPropagation(Vector3 epicenter) { }

}

