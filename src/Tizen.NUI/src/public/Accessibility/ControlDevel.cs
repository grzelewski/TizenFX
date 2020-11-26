/*
 * Copyright(c) 2020 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

using global::System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Tizen.NUI.BaseComponents;
using Tizen.NUI;
#if (NUI_DEBUG_ON)
using tlog = Tizen.Log;
#endif

namespace Tizen.NUI.Accessibility
{
    public class ControlDevel
    {
        private ControlDevel()
        {
//            dummy = new View();
//            dummy.Name = "dali-atspi-singleton";
        }

        ~ControlDevel()
        {
        }

        public static ControlDevel Instance
        {
            get => _accessibility;
        }

        public static AccessibilityActivateSignal AccessibilityActivateSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityActivateSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityActivateSignal(ptr,true);
        }

        public static AccessibilityReadingSkippedSignal AccessibilityReadingSkippedSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityReadingSkippedSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityReadingSkippedSignal(ptr,true);
        }

        public static AccessibilityReadingPausedSignal AccessibilityReadingPausedSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityReadingPausedSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityReadingPausedSignal(ptr,true);
        }

        public static AccessibilityReadingResumedSignal AccessibilityReadingResumedSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityReadingResumedSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityReadingResumedSignal(ptr,true);
        }

        public static AccessibilityReadingCancelledSignal AccessibilityReadingCancelledSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityReadingCancelledSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityReadingCancelledSignal(ptr,true);
        }

        public static AccessibilityReadingStoppedSignal AccessibilityReadingStoppedSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityReadingStoppedSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityReadingStoppedSignal(ptr,true);
        }

        public static AccessibilityGetNameSignal AccessibilityGetNameSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityGetNameSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityGetNameSignal(ptr,true);
        }

        public static AccessibilityGetDescriptionSignal AccessibilityGetDescriptionSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityGetDescriptionSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityGetDescriptionSignal(ptr,true);
        }

        public static AccessibilityDoGestureSignal AccessibilityDoGestureSignal(global::System.Runtime.InteropServices.HandleRef control) {
            var ptr = Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityDoGestureSignal(control);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return new AccessibilityDoGestureSignal(ptr,true);
        }

        public static void AppendAccessibilityRelation(global::System.Runtime.InteropServices.HandleRef arg1, global::System.Runtime.InteropServices.HandleRef arg2, int arg3) {
            Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AppendAccessibilityRelation(arg1, arg2, arg3);
        }

        public static void RemoveAccessibilityRelation(global::System.Runtime.InteropServices.HandleRef arg1, global::System.Runtime.InteropServices.HandleRef arg2, int arg3) {
            Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_RemoveAccessibilityRelation(arg1, arg2, arg3);
        }

//        public static extern global::System.IntPtr Dali_Toolkit_DevelControl_new_GetAccessibilityRelations(global::System.Runtime.InteropServices.HandleRef arg1);
//        public static extern global::System.IntPtr Dali_Toolkit_DevelControl_new_GetAccessibilityRelations(global::System.Runtime.InteropServices.HandleRef arg1);
//
//        public static extern void                  Dali_Toolkit_DevelControl_delete_AccessibilityRelations(global::System.Runtime.InteropServices.HandleRef arg1);
//        public static extern void                  Dali_Toolkit_DevelControl_delete_AccessibilityRelations(global::System.Runtime.InteropServices.HandleRef arg1);

        public static void ClearAccessibilityRelations(global::System.Runtime.InteropServices.HandleRef control) {
            Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_ClearAccessibilityRelations(control);
        }

        public static void AppendAccessibilityAttribute(global::System.Runtime.InteropServices.HandleRef arg1, string arg2, string arg3) {
            Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_AppendAccessibilityAttribute(arg1, arg2, arg3);
        }

        public static void RemoveAccessibilityAttribute(global::System.Runtime.InteropServices.HandleRef arg1, string arg2) {
            Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_RemoveAccessibilityAttribute(arg1, arg2);
        }

        public static void ClearAccessibilityAttributes(global::System.Runtime.InteropServices.HandleRef arg1) {
            Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_ClearAccessibilityAttributes(arg1);
        }

        public static void SetAccessibilityReadingInfoType(global::System.Runtime.InteropServices.HandleRef arg1, global::System.Runtime.InteropServices.HandleRef arg2) {
            Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_SetAccessibilityReadingInfoType(arg1, arg2);
        }

//        public static  global::System.IntPtr Dali_Toolkit_DevelControl_new_GetAccessibilityReadingInfoType(global::System.Runtime.InteropServices.HandleRef arg1);
//        public static extern global::System.IntPtr Dali_Toolkit_DevelControl_new_GetAccessibilityReadingInfoType(global::System.Runtime.InteropServices.HandleRef arg1);
//
//        public static extern void                  Dali_Toolkit_DevelControl_delete_ReadingInfoType(global::System.Runtime.InteropServices.HandleRef arg1);
//        public static extern void                  Dali_Toolkit_DevelControl_delete_ReadingInfoType(global::System.Runtime.InteropServices.HandleRef arg1);

        public static bool ClearAccessibilityHighlight(global::System.Runtime.InteropServices.HandleRef arg1) {
            return Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_ClearAccessibilityHighlight(arg1);
        }

        public static bool GrabAccessibilityHighlight(global::System.Runtime.InteropServices.HandleRef arg1) {
            return Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_GrabAccessibilityHighlight(arg1);
        }

//        public static extern global::System.IntPtr Dali_Toolkit_DevelControl_new_GetAccessibilityStates(global::System.Runtime.InteropServices.HandleRef arg1);
//        public static extern global::System.IntPtr Dali_Toolkit_DevelControl_new_GetAccessibilityStates(global::System.Runtime.InteropServices.HandleRef arg1);
//
//        public static extern void                  Dali_Toolkit_DevelControl_delete_States(global::System.Runtime.InteropServices.HandleRef arg1);
//        public static extern void                  Dali_Toolkit_DevelControl_delete_States(global::System.Runtime.InteropServices.HandleRef arg1);

        public static global::System.IntPtr NotifyAccessibilityStateChange(global::System.Runtime.InteropServices.HandleRef arg1, global::System.Runtime.InteropServices.HandleRef arg2, uint arg3) {
            return Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_NotifyAccessibilityStateChange(arg1, arg2, arg3);
        }

        public static global::System.IntPtr GetBoundAccessibilityObject(global::System.Runtime.InteropServices.HandleRef arg1) {
            return Tizen.NUI.Interop.ControlDevel.Dali_Toolkit_DevelControl_GetBoundAccessibilityObject(arg1);
        }
 
  
  
  
  
//          static public bool GetStatus()
//        {
//            return true;
//        }
//
//        [EditorBrowsable(EditorBrowsableState.Never)]
//        public bool Say(string sentence, bool discardable)
//        {
//            IntPtr callbackIntPtr = IntPtr.Zero;
//            if (_sayFinishedEventHandler != null)
//            {
//                callback = _sayFinishedEventCallback;
//                callbackIntPtr = Marshal.GetFunctionPointerForDelegate<Delegate>(callback);
//            }
//            bool ret = Interop.Accessibility.accessibility_say(View.getCPtr(dummy), sentence, discardable, callbackIntPtr);
//            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
//            return ret;
//        }
//
//        [EditorBrowsable(EditorBrowsableState.Never)]
//        public void PauseResume(bool pause)
//        {
//            Interop.Accessibility.accessibility_pause_resume(View.getCPtr(dummy), pause);
//            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
//        }
//
//        [EditorBrowsable(EditorBrowsableState.Never)]
//        public class SayFinishedEventArgs : EventArgs
//        {
//            [EditorBrowsable(EditorBrowsableState.Never)]
//            public SayFinishedStates State
//            {
//                private set;
//                get;
//            }
//
//            internal SayFinishedEventArgs(int result)
//            {
//                State = (SayFinishedStates)(result);
//                tlog.Fatal(tag, $"SayFinishedEventArgs Constructor! State={State}");
//            }
//        }
//
//        [EditorBrowsable(EditorBrowsableState.Never)]
//        public enum SayFinishedStates
//        {
//            [EditorBrowsable(EditorBrowsableState.Never)]
//            Invalid = -1,
//            [EditorBrowsable(EditorBrowsableState.Never)]
//            Cancelled = 1,
//            [EditorBrowsable(EditorBrowsableState.Never)]
//            Stopped = 2,
//            [EditorBrowsable(EditorBrowsableState.Never)]
//            Skipped = 3
//        }
//
//        [EditorBrowsable(EditorBrowsableState.Never)]
//        public event EventHandler<SayFinishedEventArgs> SayFinished
//        {
//            add => _sayFinishedEventHandler += value;
//            remove => _sayFinishedEventHandler -= value;
//        }
//
//        internal void PauseResume(View target, bool pause)
//        {
//            Interop.Accessibility.accessibility_pause_resume(View.getCPtr(target), pause);
//            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
//        }
//
//        internal bool Say(View target, string sentence, bool discardable)
//        {
//            IntPtr callbackIntPtr = IntPtr.Zero;
//            if (_sayFinishedEventHandler != null)
//            {
//                callback = _sayFinishedEventCallback;
//                callbackIntPtr = Marshal.GetFunctionPointerForDelegate<Delegate>(callback);
//            }
//            bool ret = Interop.Accessibility.accessibility_say(View.getCPtr(target), sentence, discardable, callbackIntPtr);
//            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
//            return ret;
//        }

        private static readonly ControlDevel _accessibility = new ControlDevel();

//        private event EventHandler<SayFinishedEventArgs> _sayFinishedEventHandler;
//
//        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
//        private delegate void _sayFinishedEventCallbackType(int result);
//
//        private _sayFinishedEventCallbackType callback = null;
//
//        private void _sayFinishedEventCallback(int result)
//        {
//            tlog.Fatal(tag, $"_sayFinishedEventCallback(res={result}) called!");
//            _sayFinishedEventHandler?.Invoke(this, new SayFinishedEventArgs(result));
//        }
//
//        private View dummy;

//        private static string tag = "NUITEST";
    }
}
