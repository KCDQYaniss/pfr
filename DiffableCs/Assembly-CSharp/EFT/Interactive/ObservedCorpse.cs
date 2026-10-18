namespace EFT.Interactive;

public class ObservedCorpse : Corpse
{
	[CompilerGenerated]
	private sealed class <ApplyTransformSyncWorker>d__20 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ObservedCorpse <>4__this; //Field offset: 0x20
		public TransformSync[] packetTransformSyncs; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ApplyTransformSyncWorker>d__20(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <FinalMoveUpdate>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ObservedCorpse <>4__this; //Field offset: 0x20
		public Vector3 desiredPosition; //Field offset: 0x28
		public float corpseSyncThreshold; //Field offset: 0x34
		public TransformSync[] packetTransformSyncs; //Field offset: 0x38

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <FinalMoveUpdate>d__19(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private Transform _rightPalm; //Field offset: 0x190
	private EDamageType _killedDamageType; //Field offset: 0x198
	private bool _isDone; //Field offset: 0x19C
	private bool _isStill; //Field offset: 0x19D
	private bool _stillForced; //Field offset: 0x19E
	private IEnumerator _finaleWorker; //Field offset: 0x1A0
	private bool _wasVisibleAtCloseDistance; //Field offset: 0x1A8
	private bool _forceTransformSyncOnDone; //Field offset: 0x1A9
	private bool _transformSyncForced; //Field offset: 0x1AA

	protected virtual CollisionDetectionMode CollisionDetectionMode
	{
		 get { } //Length: 6
	}

	public bool IsDone
	{
		 get { } //Length: 8
	}

	public virtual float PhysicsQuality
	{
		 get { } //Length: 4
	}

	public ObservedCorpse() { }

	public void ApplyNetPacket(CorpseSyncPacket packet) { }

	protected virtual void ApplyTransformSync(TransformSync[] packetTransformSyncs) { }

	[IteratorStateMachine(typeof(<ApplyTransformSyncWorker>d__20))]
	private IEnumerator ApplyTransformSyncWorker(TransformSync[] packetTransformSyncs) { }

	protected virtual bool CheckCorpseIsStill(bool sleeping, float timePass) { }

	private void CheckVisibility() { }

	public void ClearWeaponInHands() { }

	[IteratorStateMachine(typeof(<FinalMoveUpdate>d__19))]
	private IEnumerator FinalMoveUpdate(Vector3 desiredPosition, float corpseSyncThreshold, TransformSync[] packetTransformSyncs) { }

	public void ForceApplyTransformSync(TransformSync[] packetTransformSyncs) { }

	public void ForceStill() { }

	public void ForceTransformSyncOnDone() { }

	protected virtual CollisionDetectionMode get_CollisionDetectionMode() { }

	public bool get_IsDone() { }

	public virtual float get_PhysicsQuality() { }

	private float MoveTo(Vector3 position, float corpseSyncThreshold) { }

	public void SetSpecificSettings(Transform rightPalm) { }

	private bool TryForceTransformSync(CorpseSyncPacket packet) { }

}

