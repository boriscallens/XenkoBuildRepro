# Trying to get to the bottom of a project setup problem

  - Indirect nuget reference issue fixed https://github.com/xenko3d/xenko/issues/365
  - Component and processor cause exit to crash

After adding a basic component and processor pair and exiting game studio this error occurs

	Log: 1: MyProcessor(0,0): []: Fatal: The asset MyProcessor is missing or incorrectly indexed in the package. Please report this issue.
	2: MyComponent(0,0): []: Fatal: The asset MyComponent is missing or incorrectly indexed in the package. Please report this issue.
	3: BasicCameraController(0,0): []: Fatal: The asset BasicCameraController is missing or incorrectly indexed in the package. Please report this issue.
	4: MyProcessor(0,0): []: Fatal: The asset MyProcessor is missing or incorrectly indexed in the package. Please report this issue.
	5: MyComponent(0,0): []: Fatal: The asset MyComponent is missing or incorrectly indexed in the package. Please report this issue.

Stacktrace:

	Exception: NullReferenceException: Object reference not set to an instance of an object.
	   at Xenko.Engine.Processors.ScriptSystem.AddTask(Func`1 microThreadFunction, Int64 priority)
	   at Xenko.Editor.Preview.GameStudioPreviewService.SetAssetToPreview(AssetViewModel asset)
	   at System.Collections.Specialized.NotifyCollectionChangedEventHandler.Invoke(Object sender, NotifyCollectionChangedEventArgs e)
	   at Xenko.Core.Presentation.Collections.ObservableList`1.OnCollectionChanged(NotifyCollectionChangedEventArgs arg)
	   at Xenko.Core.Presentation.Collections.ObservableList`1.AddRange(IEnumerable`1 items)
	   at Xenko.Core.Assets.Editor.ViewModel.AssetCollectionViewModel.SelectedContentCollectionChanged(Object sender, NotifyCollectionChangedEventArgs e)
	   at System.Collections.Specialized.NotifyCollectionChangedEventHandler.Invoke(Object sender, NotifyCollectionChangedEventArgs e)
	   at Xenko.Core.Presentation.Collections.ObservableList`1.OnCollectionChanged(NotifyCollectionChangedEventArgs arg)
	   at Xenko.Core.Presentation.Collections.ObservableList`1.AddRange(IEnumerable`1 items)
	   at Xenko.Core.Presentation.Behaviors.BindableSelectedItemsBehavior`1.ControlSelectionChanged(IEnumerable addedItems, IList removedItems)
	   at Xenko.Core.Presentation.Behaviors.ListBoxBindableSelectedItemsBehavior.ListBoxSelectionChanged(Object sender, SelectionChangedEventArgs e)
	   at System.Windows.RoutedEventArgs.InvokeHandler(Delegate handler, Object target)
	   at System.Windows.RoutedEventHandlerInfo.InvokeHandler(Object target, RoutedEventArgs routedEventArgs)
	   at System.Windows.EventRoute.InvokeHandlersImpl(Object source, RoutedEventArgs args, Boolean reRaised)
	   at System.Windows.UIElement.RaiseEventImpl(DependencyObject sender, RoutedEventArgs args)
	   at System.Windows.Controls.ListBox.OnSelectionChanged(SelectionChangedEventArgs e)
	   at System.Windows.Controls.Primitives.Selector.SelectionChanger.End()
	   at System.Windows.Controls.Primitives.Selector.SelectionChanger.SelectJustThisItem(ItemInfo info, Boolean assumeInItemsCollection)
	   at System.Windows.Controls.Primitives.Selector.SetSelectedToCurrent()
	   at System.Windows.Controls.Primitives.Selector.SetSynchronizationWithCurrentItem()
	   at System.Windows.DependencyObject.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.FrameworkElement.OnPropertyChanged(DependencyPropertyChangedEventArgs e)
	   at System.Windows.DependencyObject.NotifyPropertyChange(DependencyPropertyChangedEventArgs args)
	   at System.Windows.DependencyObject.UpdateEffectiveValue(EntryIndex entryIndex, DependencyProperty dp, PropertyMetadata metadata, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType)
	   at System.Windows.DependencyObject.SetValueCommon(DependencyProperty dp, Object value, PropertyMetadata metadata, Boolean coerceWithDeferredReference, Boolean coerceWithCurrentValue, OperationType operationType, Boolean isInternal)
	   at System.Windows.DependencyObject.SetValue(DependencyProperty dp, Object value)
	   at Xenko.Core.Presentation.Behaviors.TilePanelNavigationBehavior.OnAttachedAndLoaded()
	   at Xenko.Core.Presentation.Behaviors.DeferredBehaviorBase`1.AssociatedObjectLoaded(Object sender, RoutedEventArgs e)
	   at System.Windows.EventRoute.InvokeHandlersImpl(Object source, RoutedEventArgs args, Boolean reRaised)
	   at System.Windows.UIElement.RaiseEventImpl(DependencyObject sender, RoutedEventArgs args)
	   at System.Windows.BroadcastEventHelper.BroadcastEvent(DependencyObject root, RoutedEvent routedEvent)
	   at System.Windows.BroadcastEventHelper.BroadcastLoadedEvent(Object root)
	   at MS.Internal.LoadedOrUnloadedOperation.DoWork()
	   at System.Windows.Media.MediaContext.FireLoadedPendingCallbacks()
	   at System.Windows.Media.MediaContext.FireInvokeOnRenderCallbacks()
	   at System.Windows.Media.MediaContext.RenderMessageHandlerCore(Object resizedCompositionTarget)
	   at System.Windows.Media.MediaContext.AnimatedRenderMessageHandler(Object resizedCompositionTarget)
	   at System.Windows.Threading.ExceptionWrapper.InternalRealCall(Delegate callback, Object args, Int32 numArgs)
	   at System.Windows.Threading.ExceptionWrapper.TryCatchWhen(Object source, Delegate callback, Object args, Int32 numArgs, Delegate catchHandler)
	   at System.Windows.Threading.DispatcherOperation.InvokeImpl()
	   at MS.Internal.CulturePreservingExecutionContext.CallbackWrapper(Object obj)
	   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
	   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
	   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
	   at MS.Internal.CulturePreservingExecutionContext.Run(CulturePreservingExecutionContext executionContext, ContextCallback callback, Object state)
	   at System.Windows.Threading.DispatcherOperation.Invoke()
	   at System.Windows.Threading.Dispatcher.ProcessQueue()
	   at System.Windows.Threading.Dispatcher.WndProcHook(IntPtr hwnd, Int32 msg, IntPtr wParam, IntPtr lParam, Boolean& handled)
	   at MS.Win32.HwndWrapper.WndProc(IntPtr hwnd, Int32 msg, IntPtr wParam, IntPtr lParam, Boolean& handled)
	   at MS.Win32.HwndSubclass.DispatcherCallbackOperation(Object o)
	   at System.Windows.Threading.ExceptionWrapper.InternalRealCall(Delegate callback, Object args, Int32 numArgs)
	   at System.Windows.Threading.ExceptionWrapper.TryCatchWhen(Object source, Delegate callback, Object args, Int32 numArgs, Delegate catchHandler)
	   at System.Windows.Threading.Dispatcher.LegacyInvokeImpl(DispatcherPriority priority, TimeSpan timeout, Delegate method, Object args, Int32 numArgs)
	   at MS.Win32.HwndSubclass.SubclassWndProc(IntPtr hwnd, Int32 msg, IntPtr wParam, IntPtr lParam)
	   at MS.Win32.UnsafeNativeMethods.DispatchMessage(MSG& msg)
	   at System.Windows.Threading.Dispatcher.PushFrameImpl(DispatcherFrame frame)
	   at System.Windows.Application.RunDispatcher(Object ignore)
	   at System.Windows.Application.RunInternal(Window window)
	   at Xenko.GameStudio.Program.Main() in D:\BuildAgent\work\8cafb933a54b01d0\sources\editor\Xenko.GameStudio\Program.cs:line 159
