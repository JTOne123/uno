#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Input
{
	#if false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class FocusManagerGotFocusEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Guid CorrelationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid FocusManagerGotFocusEventArgs.CorrelationId is not implemented in Uno.");
			}
		}
		#endif
		// Skipping already declared property NewFocusedElement
		// Forced skipping of method Windows.UI.Xaml.Input.FocusManagerGotFocusEventArgs.NewFocusedElement.get
		// Forced skipping of method Windows.UI.Xaml.Input.FocusManagerGotFocusEventArgs.CorrelationId.get
	}
}
