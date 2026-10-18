namespace EFT;

[Extension]
public static class ItemRelatedViewExtensions
{

	private static void LogException(T handler, Exception e, string methodName = "UNKNOWN") { }

	[Extension]
	public static void SafeOnBindItemInvoke(IBindHandler handler, BindItemEventArgs args) { }

	[Extension]
	public static void SafeOnDrainInvoke(IDrainHandler handler, DrainItemEventArgs args) { }

	[Extension]
	public static void SafeOnInventoryMagazineCheckInvoke(IInventoryMagazineCheckHandler handler, Magazine item, float time, bool status) { }

	[Extension]
	public static void SafeOnItemAddedInvoke(IAddHandler handler, AddItemEventArgs obj) { }

	[Extension]
	public static void SafeOnItemRemovedInvoke(IRemoveHandler handler, RemoveItemEventArgs obj) { }

	[Extension]
	public static void SafeOnLoadMagazineInvoke(ILoadMagazineHandler handler, LoadMagazineEventArgs args) { }

	[Extension]
	public static void SafeOnMagazineChangeInvoke(IMagazineChangedHandler handler, Magazine magazine) { }

	[Extension]
	public static void SafeOnRefreshItemInvoke(IRefreshHandler handler, RefreshItemEventArgs args) { }

	[Extension]
	public static void SafeOnRemoveFromHandsInvoke(IRemoveFromHandsHandler handler, RemoveFromHandsEventArgs args) { }

	[Extension]
	public static void SafeOnSetInHandsInvoke(ISetInHandsHandler handler, SetInHandsEventArgs args) { }

	[Extension]
	public static void SafeOnUnbindItemInvoke(IUnbindHandler handler, UnbindItemEventArgs args) { }

	[Extension]
	public static void SafeOnUnloadMagazineInvoke(IUnloadMagazineHandler handler, UnloadMagazineEventArgs args) { }

}

