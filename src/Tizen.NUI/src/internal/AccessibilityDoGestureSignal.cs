/*
 * Copyright(c) 2019 Samsung Electronics Co., Ltd.
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

using System.Diagnostics;
using System;
using System.Drawing;

namespace Tizen.NUI
{
    using global::System;
    using global::System.ComponentModel;
    using global::System.Runtime.InteropServices;
    using Tizen.NUI.BaseComponents;

    public class AccessibilityDoGestureSignal : Disposable
    {
        public struct GestureInfo {
            public uint type { get; set; }
            public int xBeg { get; set; }
            public int xEnd { get; set; }
            public int yBeg { get; set; }
            public int yEnd { get; set; }
            public uint state { get; set; }
            public uint eventTime { get; set; }
            public uint boolValue { get; set; }
        }

        public class GestureInfoArgs : EventArgs
        {
            public GestureInfo gestureInfo { get; internal set; }
        }

        private delegate void ConverterType(IntPtr data);
        private ConverterType converterCallback;
        private EventHandler<GestureInfoArgs> gestureInfoHandler;

        // this function converts c/c++ structures to c#
        // IntPtr contains pointer to std::pair<GestureInfo, bool>
        private void Converter(IntPtr data) {
            if (data == IntPtr.Zero)
                return;

            var arg = new GestureInfoArgs();
            var ges = new GestureInfo();

            ges.type = ConvertParam1(data);
            ges.xBeg = ConvertParam2(data);
            ges.xEnd = ConvertParam3(data);
            ges.yBeg = ConvertParam4(data);
            ges.yEnd = ConvertParam5(data);
            ges.state = ConvertParam6(data);
            ges.eventTime = ConvertParam7(data);
            ges.boolValue = ConvertParam8(data);

            arg.gestureInfo = ges;

            gestureInfoHandler?.Invoke(this, arg);
        }

        public event EventHandler<GestureInfoArgs> eventHandler {
            add
            {
                converterCallback = Converter;
                Connect(converterCallback);
                gestureInfoHandler += value;
            }
            remove
            {
                gestureInfoHandler -= value;
                converterCallback = Converter;
                Disconnect(converterCallback);
            }
        }

        internal AccessibilityDoGestureSignal(global::System.IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn)
        {
        }

        internal uint ConvertParam1(global::System.IntPtr data) {
            uint result = Interop.DoGestureSignal.ConvertParam1(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        internal int ConvertParam2(global::System.IntPtr data) {
            int result = Interop.DoGestureSignal.ConvertParam2(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        internal int ConvertParam3(global::System.IntPtr data) {
            int result = Interop.DoGestureSignal.ConvertParam3(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        internal int ConvertParam4(global::System.IntPtr data) {
            int result = Interop.DoGestureSignal.ConvertParam4(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        internal int ConvertParam5(global::System.IntPtr data) {
            int result = Interop.DoGestureSignal.ConvertParam5(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        internal uint ConvertParam6(global::System.IntPtr data) {
            uint result = Interop.DoGestureSignal.ConvertParam6(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        internal uint ConvertParam7(global::System.IntPtr data) {
            uint result = Interop.DoGestureSignal.ConvertParam7(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        internal uint ConvertParam8(global::System.IntPtr data) {
            uint result = Interop.DoGestureSignal.ConvertParam8(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        protected override void ReleaseSwigCPtr(System.Runtime.InteropServices.HandleRef swigCPtr)
        {
            Interop.DoGestureSignal.Delete(swigCPtr);
        }

        public AccessibilityDoGestureSignal() : this(Interop.DoGestureSignal.New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool Empty()
        {
            bool ret = Interop.DoGestureSignal.Empty(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public uint GetConnectionCount()
        {
            uint ret = Interop.DoGestureSignal.GetConnectionCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Connect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<System.Delegate>(func);
            {
                Interop.DoGestureSignal.Connect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Disconnect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<System.Delegate>(func);
            {
                Interop.DoGestureSignal.Disconnect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

//        internal void Connect(ConnectionTrackerInterface connectionTracker, SWIGTYPE_p_Dali__FunctorDelegate arg1)
//        {
//            Interop.DoGestureSignal.DoGestureSignal_Connect__SWIG_4(swigCPtr, ConnectionTrackerInterface.getCPtr(connectionTracker), SWIGTYPE_p_Dali__FunctorDelegate.getCPtr(arg1));
//            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
//        }

        public void Emit()
        {
            Interop.DoGestureSignal.Emit(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}

