//Type is in global namespace

public class SpectatorHeadDeviceCameraEffectsController
{
	[CompilerGenerated]
	private sealed class <CollectFaceShieldComponents>d__25 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private FaceShieldComponent <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public SpectatorHeadDeviceCameraEffectsController <>4__this; //Field offset: 0x28
		private ObservedPlayerView observedPlayer; //Field offset: 0x30
		public ObservedPlayerView <>3__observedPlayer; //Field offset: 0x38
		private IEnumerator <>7__wrap1; //Field offset: 0x40

		private override FaceShieldComponent System.Collections.Generic.IEnumerator<EFT.InventoryLogic.FaceShieldComponent>.Current
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
		public <CollectFaceShieldComponents>d__25(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.FaceShieldComponent>.GetEnumerator() { }

		[DebuggerHidden]
		private override FaceShieldComponent System.Collections.Generic.IEnumerator<EFT.InventoryLogic.FaceShieldComponent>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private bool _onFaceShieldChangedIsLive; //Field offset: 0x10
	private ObservedPlayerView _subscribedPlayer; //Field offset: 0x18
	private readonly List _headDeviceSubscriptions; //Field offset: 0x20
	private Slot _headwearSlot; //Field offset: 0x28
	private Slot _faceCoverSlot; //Field offset: 0x30
	private Action _onHeadEquipmentChanged; //Field offset: 0x38
	private Action _unsubscribeEquipChangedEvent; //Field offset: 0x40

	public SpectatorHeadDeviceCameraEffectsController() { }

	[CompilerGenerated]
	private void <SubscribeObservedPlayerEquipChanged>b__17_0(ObservedPlayerChangedEquipEvent raisedEvent) { }

	private void ApplyFaceShieldComponent(FaceShieldComponent faceShield) { }

	private void ApplyNightVision(bool enabled, NightVisionComponent activeNightVisionComponent = null) { }

	private void ApplyThermalVision(bool enabled, ThermalVisionComponent activeThermalVisionComponent = null) { }

	public void Clear() { }

	[IteratorStateMachine(typeof(<CollectFaceShieldComponents>d__25))]
	private IEnumerable CollectFaceShieldComponents(ObservedPlayerView observedPlayer) { }

	private void DisableNightVisionIfSwitching() { }

	private void DisableThermalVisionIfSwitching() { }

	private T FindFirstComponent(Item item) { }

	private bool IsAnyNightVisionComponentActive(IEnumerable components, out NightVisionComponent active) { }

	private bool IsAnyThermalVisionActive(IEnumerable components, out ThermalVisionComponent active) { }

	private void OnHeadEquipmentChanged(Item item) { }

	private void OnSubscribedFaceShieldChanged() { }

	private void OnSubscribedNightVisionChanged() { }

	private void OnSubscribedThermalVisionChanged() { }

	private FaceShieldComponent ResolveFaceShieldComponent(ObservedPlayerView observedPlayer) { }

	private void ResyncHeadDevices(ObservedPlayerView observedPlayer) { }

	private bool ShouldApplyFor(ObservedPlayerView observedPlayer) { }

	private void SubscribeHeadDeviceChanges(ObservedPlayerView observedPlayer) { }

	private void SubscribeHeadEquipmentChanges(ObservedPlayerView observedPlayer) { }

	private void SubscribeObservedPlayerEquipChanged(ObservedPlayerView observedPlayer) { }

	public void SyncFaceShieldFromObservedPlayer(ObservedPlayerView observedPlayer) { }

	private void SyncFaceShieldInternal(ObservedPlayerView observedPlayer) { }

	public void SyncFromObservedPlayer(ObservedPlayerView observedPlayer) { }

	private void SyncNightVisionFromHeadwear(ObservedPlayerView observedPlayer) { }

	private void SyncThermalVisionFromHeadwear(ObservedPlayerView observedPlayer) { }

	private bool TryFindComponents(Item item, out IEnumerable components) { }

	private bool TryGetEquipmentItem(ObservedPlayerView view, EquipmentSlot slot, out Item item) { }

	private void UnsubscribeHeadDeviceChanges() { }

	private void UnsubscribeHeadEquipmentChanges() { }

	private void UnsubscribeObservedPlayerEquipChanged() { }

}

