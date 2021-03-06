// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.



#region Namespace Suppressions
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Chakra.Executor")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Collections")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Modules.AppState")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Modules.DevSupport")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Modules.Image")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Modules.NetInfo")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Modules.Network")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Modules.StatusBar")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Modules.Vibration")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Shell")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Touch")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.UIManager.Annotations")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.UIManager.Events")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.UIManager.LayoutAnimation")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Views.Image")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Views.Picker")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Views.Scroll")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Views.Switch")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Views.TextInput")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Views.View")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ReactNative.Views.Web")]
#endregion

#region Native Module CA1704 Suppressions
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Subviews", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#removeSubviewsFromContainerWithID(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Subview", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#findSubviewIn(System.Int32,Newtonsoft.Json.Linq.JArray,ReactNative.Bridge.ICallback)")]
#endregion

#region Native Module CA1709 Suppressions
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "connect", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#connectAnimatedNodeToView(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "disconnect", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#disconnectAnimatedNodes(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "disconnect", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#disconnectAnimatedNodeFromView(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "set", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#setAnimatedNodeValue(System.Int32,System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "drop", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#dropAnimatedNode(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "stop", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#stopListeningToAnimatedNodeValue(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "start", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#startListeningToAnimatedNodeValue(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "create", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#createAnimatedNode(System.Int32,Newtonsoft.Json.Linq.JObject)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "create", Scope = "member", Target = "ReactNative.Modules.Core.Timing.#createTimer(System.Int32,System.Int32,System.Double,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "delete", Scope = "member", Target = "ReactNative.Modules.Core.Timing.#deleteTimer(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "get", Scope = "member", Target = "ReactNative.Modules.NetInfo.NetInfoModule.#getCurrentConnectivity(ReactNative.Bridge.IPromise)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "send", Scope = "member", Target = "ReactNative.Modules.Network.NetworkingModule.#sendRequest(System.String,System.Uri,System.Int32,System.String[][],Newtonsoft.Json.Linq.JObject,System.String,System.Boolean,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "abort", Scope = "member", Target = "ReactNative.Modules.Network.NetworkingModule.#abortRequest(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "set", Scope = "member", Target = "ReactNative.Modules.StatusBar.StatusBarModule.#setHidden(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "set", Scope = "member", Target = "ReactNative.Modules.StatusBar.StatusBarModule.#setColor(System.Nullable`1<System.UInt32>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "set", Scope = "member", Target = "ReactNative.Modules.StatusBar.StatusBarModule.#setTranslucent(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "vibrate", Scope = "member", Target = "ReactNative.Modules.Vibration.VibrationModule.#vibrate(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "cancel", Scope = "member", Target = "ReactNative.Modules.Vibration.VibrationModule.#cancel()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "remove", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#removeRootView(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "create", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#createView(System.Int32,System.String,System.Int32,Newtonsoft.Json.Linq.JObject)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "update", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#updateView(System.Int32,System.String,Newtonsoft.Json.Linq.JObject)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "manage", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#manageChildren(System.Int32,System.Int32[],System.Int32[],System.Int32[],System.Int32[],System.Int32[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "set", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#setChildren(System.Int32,System.Int32[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "replace", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#replaceExistingNonRootView(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#removeSubviewsFromContainerWithID(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "remove", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#removeSubviewsFromContainerWithID(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "measure", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#measure(System.Int32,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "measure", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#measureInWindow(System.Int32,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "measure", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#measureLayout(System.Int32,System.Int32,ReactNative.Bridge.ICallback,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "measure", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#measureLayoutRelativeToParent(System.Int32,ReactNative.Bridge.ICallback,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "find", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#findSubviewIn(System.Int32,Newtonsoft.Json.Linq.JArray,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "set", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#setJSResponder(System.Int32,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "clear", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#clearJSResponder()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "dispatch", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#dispatchViewManagerCommand(System.Int32,System.Int32,Newtonsoft.Json.Linq.JArray)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "show", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#showPopupMenu(System.Int32,System.String[],ReactNative.Bridge.ICallback,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "configure", Scope = "member", Target = "ReactNative.UIManager.UIManagerModule.#configureNextLayoutAnimation(Newtonsoft.Json.Linq.JObject,ReactNative.Bridge.ICallback,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "get", Scope = "member", Target = "ReactNative.Modules.AppState.AppStateModule.#getCurrentAppState(ReactNative.Bridge.ICallback,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "invoke", Scope = "member", Target = "ReactNative.Modules.Core.DeviceEventManagerModule.#invokeDefaultBackPressHandler()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "report", Scope = "member", Target = "ReactNative.Modules.Core.ExceptionsManagerModule.#reportFatalException(System.String,Newtonsoft.Json.Linq.JArray,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "report", Scope = "member", Target = "ReactNative.Modules.Core.ExceptionsManagerModule.#reportSoftException(System.String,Newtonsoft.Json.Linq.JArray,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "update", Scope = "member", Target = "ReactNative.Modules.Core.ExceptionsManagerModule.#updateExceptionMessage(System.String,Newtonsoft.Json.Linq.JArray,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "dismiss", Scope = "member", Target = "ReactNative.Modules.Core.ExceptionsManagerModule.#dismissRedbox()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "start", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#startAnimatingNode(System.Int32,System.Int32,Newtonsoft.Json.Linq.JObject,ReactNative.Bridge.ICallback)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "stop", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#stopAnimation(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "connect", Scope = "member", Target = "ReactNative.Animated.NativeAnimatedModule.#connectAnimatedNodes(System.Int32,System.Int32)")]
#endregion

#region JavaScript Module CA1709 Suppressions
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "call", Scope = "member", Target = "ReactNative.Modules.Core.JSTimersExecution.#callTimers(System.Collections.Generic.IList`1<System.Int32>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "emit", Scope = "member", Target = "ReactNative.Modules.Core.RCTDeviceEventEmitter.#emit(System.String,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RCT", Scope = "type", Target = "ReactNative.Modules.Core.RCTNativeAppEventEmitter")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "emit", Scope = "member", Target = "ReactNative.Modules.Core.RCTNativeAppEventEmitter.#emit(System.String,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "run", Scope = "member", Target = "ReactNative.UIManager.AppRegistry.#runApplication(System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "unmount", Scope = "member", Target = "ReactNative.UIManager.AppRegistry.#unmountApplicationComponentAtRootTag(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RCT", Scope = "type", Target = "ReactNative.UIManager.Events.RCTEventEmitter")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "receive", Scope = "member", Target = "ReactNative.UIManager.Events.RCTEventEmitter.#receiveEvent(System.Int32,System.String,Newtonsoft.Json.Linq.JObject)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "receive", Scope = "member", Target = "ReactNative.UIManager.Events.RCTEventEmitter.#receiveTouches(System.String,Newtonsoft.Json.Linq.JArray,Newtonsoft.Json.Linq.JArray)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "HMR", Scope = "type", Target = "ReactNative.DevSupport.HMRClient")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "enable", Scope = "member", Target = "ReactNative.DevSupport.HMRClient.#enable(System.String,System.String,System.String,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RCT", Scope = "type", Target = "ReactNative.Modules.Core.RCTDeviceEventEmitter")]
#endregion

#region View Manager CA1011 Suppressions
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "ReactNative.UIManager.NativeViewHierarchyManager.#AddRootView(System.Int32,ReactNative.UIManager.SizeMonitoringCanvas,ReactNative.UIManager.ThemedReactContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "ReactNative.Views.Picker.ReactPickerManager.#SetEnabled(Windows.UI.Xaml.Controls.ComboBox,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "ReactNative.Views.Scroll.ReactScrollViewManager.#SetBackgroundColor(Windows.UI.Xaml.Controls.ScrollViewer,System.UInt32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "ReactNative.Views.Scroll.ReactScrollViewManager.#SetEnabled(Windows.UI.Xaml.Controls.ScrollViewer,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "ReactNative.Views.Switch.ReactSwitchManager.#SetDisabled(Windows.UI.Xaml.Controls.ToggleSwitch,System.Boolean)")]
#endregion

#region View Manager CA1822 Suppressions
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "ReactNative.Views.Web.ReactWebViewManager.#SetSource(Windows.UI.Xaml.Controls.WebView,Newtonsoft.Json.Linq.JObject)")]
#endregion

