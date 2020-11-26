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

    public class StringToVoidSignal : Disposable
    {
        public class StringToVoidArgs : EventArgs
        {
            public string arg1 { get; internal set; }
        }

        private delegate void ConverterType(IntPtr data);
        private ConverterType converterCallback;
        private EventHandler<StringToVoidArgs> stringToVoidHandler;

        // this function converts c/c++ structures to c#
        // IntPtr contains pointer to std::string
        private void Converter(IntPtr data) {
            if (data == IntPtr.Zero)
                return;

            var arg = new StringToVoidArgs();
            arg.arg1 = ConvertParam1(data);
            stringToVoidHandler?.Invoke(this, arg);
        }

        public event EventHandler<StringToVoidArgs> eventHandler {
            add
            {
                converterCallback = Converter;
                Connect(converterCallback);
                stringToVoidHandler += value;
            }
            remove
            {
                stringToVoidHandler -= value;
                converterCallback = Converter;
                Disconnect(converterCallback);
            }
        }

        internal StringToVoidSignal(global::System.IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn)
        {
        }

        internal string ConvertParam1(global::System.IntPtr data) {
            string result = Interop.StringToVoidSignal.ConvertParam1(data);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        protected override void ReleaseSwigCPtr(System.Runtime.InteropServices.HandleRef swigCPtr)
        {
            Interop.StringToVoidSignal.Delete(swigCPtr);
        }

        public StringToVoidSignal() : this(Interop.StringToVoidSignal.New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool Empty()
        {
            bool ret = Interop.StringToVoidSignal.Empty(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public uint GetConnectionCount()
        {
            uint ret = Interop.StringToVoidSignal.GetConnectionCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Connect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<System.Delegate>(func);
            {
                Interop.StringToVoidSignal.Connect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Disconnect(System.Delegate func)
        {
            System.IntPtr ip = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<System.Delegate>(func);
            {
                Interop.StringToVoidSignal.Disconnect(swigCPtr, new System.Runtime.InteropServices.HandleRef(this, ip));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
        }

//        internal void Connect(ConnectionTrackerInterface connectionTracker, SWIGTYPE_p_Dali__FunctorDelegate arg1)
//        {
//            Interop.StringToVoidSignal.StringToVoidSignal_Connect__SWIG_4(swigCPtr, ConnectionTrackerInterface.getCPtr(connectionTracker), SWIGTYPE_p_Dali__FunctorDelegate.getCPtr(arg1));
//            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
//        }

        public void Emit()
        {
            Interop.StringToVoidSignal.Emit(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}

