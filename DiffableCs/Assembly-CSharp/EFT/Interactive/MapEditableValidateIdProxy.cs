namespace EFT.Interactive;

public static class MapEditableValidateIdProxy
{
	internal sealed class UniqueIdRequestDelegate : MulticastDelegate
	{

		public UniqueIdRequestDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IMapEditable mapEditable, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IMapEditable mapEditable) { }

	}

	private static UniqueIdRequestDelegate _uniqueIdRequestHandler; //Field offset: 0x0

	private static void RequestUniqueId(IMapEditable mapEditable) { }

	public static void SetRequestHandler(UniqueIdRequestDelegate requestHandler) { }

	public static void ValidateOnDuplicateOrPaste(T mapEditable) { }

}

