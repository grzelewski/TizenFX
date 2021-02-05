/*
 * Copyright(c) 2021 Samsung Electronics Co., Ltd.
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Tizen.NUI;

namespace Tizen.NUI.BaseComponents
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class Address {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Address(string xbus, string xpath) {
            bus = xbus;
            path = xpath;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string bus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string path { get; set; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public class AddressCollection : SafeHandle {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public AddressCollection(IntPtr ptr) : base(ptr, true) {}

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool IsInvalid { get { return this.handle == IntPtr.Zero; }}

        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint RelationSize(View.RelationType relation) {
            uint result = Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityRelations_RelationSize(this, Convert.ToInt32(relation));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Address At(View.RelationType relation, int position) {
            var bus = Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityRelations_At(this, Convert.ToInt32(relation), position, 0);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();

            var path = Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibilityRelations_At(this, Convert.ToInt32(relation), position, 1);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();

            return new Address(bus, path);
        }

        protected override bool ReleaseHandle() {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_delete_AccessibilityRelations(handle);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            this.SetHandle(IntPtr.Zero);
            return true;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class ReadingInfoTypes : SafeHandle {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ReadingInfoTypes() : base (IntPtr.Zero, true) {
            var obj = Interop.ControlDevel.Dali_Toolkit_DevelControl_new_ReadingInfoType();
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            this.SetHandle(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ReadingInfoTypes(IntPtr ptr) : base(ptr, true) {}

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool IsInvalid { get { return this.handle == IntPtr.Zero; }}

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Set(ReadingInfoType type, bool v) {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_ReadingInfoTypes_Set(this, (int)type, Convert.ToInt32(v));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Get(ReadingInfoType type) {
            bool result = Interop.ControlDevel.Dali_Toolkit_DevelControl_ReadingInfoTypes_Get(this, (int)type);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        protected override bool ReleaseHandle() {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_delete_ReadingInfoType(handle);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            this.SetHandle(IntPtr.Zero);
            return true;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class AccessibilityStates : SafeHandle {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public AccessibilityStates() : base (IntPtr.Zero, true) {
            var obj = Interop.ControlDevel.Dali_Toolkit_DevelControl_new_States();
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            this.SetHandle(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public AccessibilityStates(IntPtr ptr) : base(ptr, true) {}

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool IsInvalid { get { return this.handle == IntPtr.Zero; }}

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Set(AccessibilityState type, bool v) {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_States_Set(this, (int)type, Convert.ToInt32(v));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Get(AccessibilityState type) {
            bool result = Interop.ControlDevel.Dali_Toolkit_DevelControl_States_Get(this, (int)type);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        protected override bool ReleaseHandle() {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_delete_States(handle);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            this.SetHandle(IntPtr.Zero);
            return true;
        }
    }

    public partial class View
    {
        ///////////////////////////////////////////////////////////////////
        // ****************** Accessiblity Attributes *******************//
        ///////////////////////////////////////////////////////////////////

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AppendAccessibilityAttribute(string key, string val) {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_AppendAccessibilityAttribute(SwigCPtr, key, val);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveAccessibilityAttribute(string key) {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_RemoveAccessibilityAttribute(SwigCPtr, key);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ClearAccessibilityAttributes() {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_ClearAccessibilityAttributes(SwigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        ///////////////////////////////////////////////////////////////////
        // ************************** Highlight *************************//
        ///////////////////////////////////////////////////////////////////

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ClearAccessibilityHighlight() {
            bool result = Interop.ControlDevel.Dali_Toolkit_DevelControl_ClearAccessibilityHighlight(SwigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool GrabAccessibilityHighlight() {
            bool result = Interop.ControlDevel.Dali_Toolkit_DevelControl_GrabAccessibilityHighlight(SwigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        ///////////////////////////////////////////////////////////////////
        // ****************** Accessiblity Relations ********************//
        ///////////////////////////////////////////////////////////////////

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AppendAccessibilityRelation(View second, RelationType relation) {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_AppendAccessibilityRelation(SwigCPtr, second.SwigCPtr, (int)relation);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveAccessibilityRelation(View second, RelationType relation) {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_RemoveAccessibilityRelation(SwigCPtr, second.SwigCPtr, (int)relation);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ClearAccessibilityRelations() {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_ClearAccessibilityRelations(SwigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public AddressCollection GetAccessibilityRelations() {
            var result = new AddressCollection(Interop.ControlDevel.Dali_Toolkit_DevelControl_new_GetAccessibilityRelations(SwigCPtr));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetAccessibilityReadingInfoType(ReadingInfoTypes types) {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_SetAccessibilityReadingInfoType(SwigCPtr, types);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public ReadingInfoTypes GetAccessibilityReadingInfoType() {
            var result = new ReadingInfoTypes(Interop.ControlDevel.Dali_Toolkit_DevelControl_new_GetAccessibilityReadingInfoType(SwigCPtr));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        ///////////////////////////////////////////////////////////////////
        // ****************** Accessiblity Relations ********************//
        ///////////////////////////////////////////////////////////////////

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void NotifyAccessibilityStateChange(AccessibilityStates states, bool recursive) {
            Interop.ControlDevel.Dali_Toolkit_DevelControl_NotifyAccessibilityStateChange(SwigCPtr, states, Convert.ToInt32(recursive));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public AccessibilityStates GetAccessibilityStates() {
            var result = new AccessibilityStates(Interop.ControlDevel.Dali_Toolkit_DevelControl_new_GetAccessibilityStates(SwigCPtr));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return result;
        }

        private IntPtr strdup(string arg)
        {
            return Interop.ControlDevel.Dali_Toolkit_DevelControl_AccessibleImpl_NUI_DuplicateString(arg);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetAccessibilityConstructor(int role, bool modal = false)
        {
            var gcHandles = new List<GCHandle>();

            Interop.ControlDevel.AccessibilityGetName getName = () => strdup(AccessibilityGetName());
            gcHandles.Add(GCHandle.Alloc(getName));

            Interop.ControlDevel.AccessibilityGetDescription getDescription = () => strdup(AccessibilityGetDescription());
            gcHandles.Add(GCHandle.Alloc(getDescription));

            Interop.ControlDevel.AccessibilityDoAction doAction = (name) => AccessibilityDoAction(Marshal.PtrToStringAnsi(name));
            gcHandles.Add(GCHandle.Alloc(doAction));

            // TODO: Pass this callback to SetAccessibilityConstructor
            // ... = () => { gcHandles.ForEach((h) => h.Free()); };

            Interop.ControlDevel.Dali_Toolkit_DevelControl_SetAccessibilityConstructor
                (SwigCPtr, // arg1
                role, // arg2
                modal, // arg3
                Marshal.GetFunctionPointerForDelegate(getName), // arg4
                Marshal.GetFunctionPointerForDelegate(getDescription), // arg5
                Marshal.GetFunctionPointerForDelegate(doAction)); // arg6

            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}
