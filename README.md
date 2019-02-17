# Trying to get to the bottom of a project setup problem

  - Indirect nuget reference issue fixed https://github.com/xenko3d/xenko/issues/365
  - Component with property of certain types crashes game studio

After adding a property of the type Xenko.Maths.Int3 and then adding the Component to an entity Game Studio crashes

	Application: GameStudio
	UserEmail: 
	UserMessage: 
	XenkoVersion: 3.1.0.1-beta01-0441
	GameStudioVersion: 4
	ThreadName: Main thread
	DefaultGraphicProfile: Level_10_0
	OpenedAssets: f6148c7a-2b9a-46c2-8fea-79b06b289d94:MainScene (Scene)

	LastActions: * +[Reload game assemblies]
		* {ContentValueChangeOperation: EntityComponentCollection[2] --[2] = }
		* {ReloadAssembliesOperation}
		* {AnonymousDirtyingOperation}
		* {ContentValueChangeOperation: EntityComponentCollection[2] ++[2] = MyGame.BasicCameraController}
		* {AnonymousDirtyingOperation}
	* +[Execute AddNewItem]
		* {AssetContentValueChangeOperation: EntityComponentCollection ++[2] = MyGame.MyComponent}
	* +[Execute RemoveItem]
		* {AssetContentValueChangeOperation: EntityComponentCollection --[2] = }
	* +[Reload game assemblies]
		* {ContentValueChangeOperation: EntityComponentCollection[2] --[2] = }
		* {ReloadAssembliesOperation}
		* {AnonymousDirtyingOperation}
		* {ContentValueChangeOperation: EntityComponentCollection[2] ++[2] = MyGame.BasicCameraController}
		* {AnonymousDirtyingOperation}
	* +[Execute AddNewItem]
		* {AssetContentValueChangeOperation: EntityComponentCollection ++[2] = MyGame.MyComponent}

	CurrentDirectory: C:\Program Files\Xenko
	CommandArgs: H:\Tests\XenkoBuildRepro\MyGame.sln
	OsVersion: Microsoft Windows 10 Pro N 10.0.17134 x64
	ProcessorCount: 4
	Exception: XamlParseException: Add value to collection of type 'System.Windows.Controls.UIElementCollection' threw an exception.
	   at System.Windows.Markup.XamlReader.RewrapException(Exception e, IXamlLineInfo lineInfo, Uri baseUri)
	   at System.Windows.FrameworkTemplate.LoadTemplateXaml(XamlReader templateReader, XamlObjectWriter currentWriter)
	   at System.Windows.FrameworkTemplate.LoadTemplateXaml(XamlObjectWriter objectWriter)
	   at System.Windows.FrameworkTemplate.LoadOptimizedTemplateContent(DependencyObject container, IComponentConnector componentConnector, IStyleConnector styleConnector, List`1 affectedChildren, UncommonField`1 templatedNonFeChildrenField)
	   at System.Windows.FrameworkTemplate.LoadContent(DependencyObject container, List`1 affectedChildren)
	   at System.Windows.StyleHelper.ApplyTemplateContent(UncommonField`1 dataField, DependencyObject container, FrameworkElementFactory templateRoot, Int32 lastChildIndex, HybridDictionary childIndexFromChildID, FrameworkTemplate frameworkTemplate)
	   at System.Windows.FrameworkTemplate.ApplyTemplateContent(UncommonField`1 templateDataField, FrameworkElement container)
	   at System.Windows.FrameworkElement.ApplyTemplate()
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at MS.Internal.Helper.MeasureElementWithSingleChild(UIElement element, Size constraint)
	   at System.Windows.Controls.ContentPresenter.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Control.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Border.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Grid.MeasureCell(Int32 cell, Boolean forceInfinityV)
	   at System.Windows.Controls.Grid.MeasureCellsGroup(Int32 cellsHead, Size referenceSize, Boolean ignoreDesiredSizeU, Boolean forceInfinityV, Boolean& hasDesiredSizeUChanged)
	   at System.Windows.Controls.Grid.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at MS.Internal.Helper.MeasureElementWithSingleChild(UIElement element, Size constraint)
	   at System.Windows.Controls.ContentPresenter.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at MS.Internal.Helper.MeasureElementWithSingleChild(UIElement element, Size constraint)
	   at System.Windows.Controls.ContentPresenter.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Border.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.DockPanel.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Border.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Control.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.StackPanel.StackMeasureHelper(IStackMeasure measureElement, IStackMeasureScrollData scrollData, Size constraint)
	   at System.Windows.Controls.StackPanel.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at MS.Internal.Helper.MeasureElementWithSingleChild(UIElement element, Size constraint)
	   at System.Windows.Controls.ItemsPresenter.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.StackPanel.StackMeasureHelper(IStackMeasure measureElement, IStackMeasureScrollData scrollData, Size constraint)
	   at System.Windows.Controls.StackPanel.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at MS.Internal.Helper.MeasureElementWithSingleChild(UIElement element, Size constraint)
	   at System.Windows.Controls.ContentPresenter.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Border.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Border.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Grid.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Control.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.DockPanel.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Border.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.Control.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.Controls.StackPanel.StackMeasureHelper(IStackMeasure measureElement, IStackMeasureScrollData scrollData, Size constraint)
	   at System.Windows.Controls.StackPanel.MeasureOverride(Size constraint)
	   at System.Windows.FrameworkElement.MeasureCore(Size availableSize)
	   at System.Windows.UIElement.Measure(Size availableSize)
	   at System.Windows.ContextLayoutManager.UpdateLayout()
	   at System.Windows.ContextLayoutManager.UpdateLayoutCallback(Object arg)
	   at System.Windows.Media.MediaContext.FireInvokeOnRenderCallbacks()
	   at System.Windows.Media.MediaContext.RenderMessageHandlerCore(Object resizedCompositionTarget)
	   at System.Windows.Media.MediaContext.RenderMessageHandler(Object resizedCompositionTarget)
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

	InnerException:
	  ArgumentException: Cannot add instance of type 'String' to a collection of type 'UIElementCollection'. Only items of type 'UIElement' are allowed.
		 at System.Windows.Controls.UIElementCollection.Cast(Object value)
		 at System.Windows.Controls.UIElementCollection.System.Collections.IList.Add(Object value)
		 at MS.Internal.Xaml.Runtime.ClrObjectRuntime.Add(Object collection, XamlType collectionType, Object value, XamlType valueXamlType)

	GPU0.AdapterCompatibility: NVIDIA
	GPU0.AdapterDACType: Integrated RAMDAC
	GPU0.AdapterRAM: 4293918720
	GPU0.Availability: 3
	GPU0.Caption: NVIDIA GeForce GTX 1080 Ti
	GPU0.ConfigManagerErrorCode: 0
	GPU0.ConfigManagerUserConfig: False
	GPU0.CreationClassName: Win32_VideoController
	GPU0.CurrentBitsPerPixel: 32
	GPU0.CurrentHorizontalResolution: 2560
	GPU0.CurrentNumberOfColors: 4294967296
	GPU0.CurrentNumberOfColumns: 0
	GPU0.CurrentNumberOfRows: 0
	GPU0.CurrentRefreshRate: 59
	GPU0.CurrentScanMode: 4
	GPU0.CurrentVerticalResolution: 1440
	GPU0.Description: NVIDIA GeForce GTX 1080 Ti
	GPU0.DeviceID: VideoController1
	GPU0.DitherType: 0
	GPU0.DriverDate: 20190206000000.000000-000
	GPU0.DriverVersion: 25.21.14.1891
	GPU0.InfFilename: oem19.inf
	GPU0.InfSection: Section108
	GPU0.InstalledDisplayDrivers: C:\WINDOWS\System32\DriverStore\FileRepository\nv_dispi.inf_amd64_21a764822be8dff8\nvldumdx.dll,C:\WINDOWS\System32\DriverStore\FileRepository\nv_dispi.inf_amd64_21a764822be8dff8\nvldumdx.dll,C:\WINDOWS\System32\DriverStore\FileRepository\nv_dispi.inf_amd64_21a764822be8dff8\nvldumdx.dll,C:\WINDOWS\System32\DriverStore\FileRepository\nv_dispi.inf_amd64_21a764822be8dff8\nvldumdx.dll
	GPU0.MaxRefreshRate: 75
	GPU0.MinRefreshRate: 23
	GPU0.Monochrome: False
	GPU0.Name: NVIDIA GeForce GTX 1080 Ti
	GPU0.PNPDeviceID: PCI\VEN_10DE&DEV_1B06&SUBSYS_374C1458&REV_A1\4&BAB4994&0&0008
	GPU0.Status: OK
	GPU0.SystemCreationClassName: Win32_ComputerSystem
	GPU0.SystemName: PCBORIS
	GPU0.VideoArchitecture: 5
	GPU0.VideoMemoryType: 2
	GPU0.VideoModeDescription: 2560 x 1440 x 4294967296 colors
	GPU0.VideoProcessor: GeForce GTX 1080 Ti
	Log: 1: BasicCameraController(0,0): []: Fatal: The asset BasicCameraController is missing or incorrectly indexed in the package. Please report this issue.
	2: MyComponent(0,0): []: Fatal: The asset MyComponent is missing or incorrectly indexed in the package. Please report this issue.
	3: MyProcessor(0,0): []: Fatal: The asset MyProcessor is missing or incorrectly indexed in the package. Please report this issue.

