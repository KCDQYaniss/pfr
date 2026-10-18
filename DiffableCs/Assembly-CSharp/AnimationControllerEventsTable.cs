//Type is in global namespace

public static class AnimationControllerEventsTable
{
	private sealed class EventsFunctionDelegate : MulticastDelegate
	{

		public EventsFunctionDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(List eventsConsumers, AnimationEventParameter parameter, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(List eventsConsumers, AnimationEventParameter parameter) { }

	}

	private static readonly Dictionary _bindedFunctions; //Field offset: 0x0
	private static readonly Dictionary _hashToFunctionName; //Field offset: 0x8

	private static AnimationControllerEventsTable() { }

	private static void AimReady(List eventsConsumers, AnimationEventParameter parameter) { }

	public static void AnimatorEventHandler(List eventsConsumers, int functionNameHash, AnimationEventParameter parameter) { }

	private static void AnimatorEventHandler(List eventsConsumers, string functionName, AnimationEventParameter parameter) { }

	private static void BipodClose(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void BipodOpen(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void DropWeapon(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireAddAmmoInChamber(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireAddAmmoInMag(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireArm(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireCook(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireDelAmmoChamber(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireDelAmmoFromMag(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireDisarm(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireFireEnd(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireFiringBullet(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireFoldOff(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireFoldOn(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireIdleStart(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireLauncherAppeared(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireLauncherDisappeared(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireMagHide(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireMagIn(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireMagOut(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireMagShow(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireMalfunctionOff(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireMessageName(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireModChanged(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireOffBoltCatch(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireOnBoltCatch(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FirePutMagToRig(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireRemoveShell(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireReplaceSecondMag(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireShellEject(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireShowAmmo(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireShowMag(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireSliderOut(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireSound(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireSoundAtPoint(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireStartUtilityOperation(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireThirdAction(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireUseProp(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireUseSecondMagForReload(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireWeapIn(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void FireWeapOut(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void IdleReady(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void OnBackpackDrop(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void OnComboPlanning(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void OnCurrentAnimStateEnded(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void OnDeactivateObject(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void OnSetActiveObject(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void OutUse(List eventsConsumers, AnimationEventParameter parameter) { }

	private static void ReloadTest(List eventsConsumers, AnimationEventParameter parameter) { }

}

