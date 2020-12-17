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
using System.ComponentModel;
using System.Runtime.InteropServices;
using Tizen.NUI;

namespace Tizen.NUI.BaseComponents
{
    public partial class ReadingInfoTypes
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public enum ReadingInfoType
        {
            Name = 0,
            Role,
            Description,
            State
        };
    }

    public partial class AccessibilityStates {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public enum AccessibilityState
        {
            Invalid = 0,
            Active,
            Armed,
            Busy,
            Checked,
            Collapsed,
            Defunct,
            Editable,
            Enabled,
            Expandable,
            Expanded,
            Focusable,
            Focused,
            HasTooltip,
            Horizontal,
            Iconified,
            Modal,
            MultiLine,
            MultiSelectable,
            Opaque,
            Pressed,
            Resizeable,
            Selectable,
            Selected,
            Sensitive,
            Showing,
            SingleLine,
            Stale,
            Transient,
            Vertical,
            Visible,
            ManagesDescendants,
            Indeterminate,
            Required,
            Truncated,
            Animated,
            InvalidEntry,
            SupportsAutocompletion,
            SelectableText,
            IsDefault,
            Visited,
            Checkable,
            HasPopup,
            ReadOnly,
            Highlighted,
            Highlightable,
            MaxCount,
        };
    }

    public partial class View
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public enum AccessibilityGesture
        {
            OneFingerHover = 0,
            TwoFingerHover,
            ThreeFingerHover,
            OneFingerFlickLeft,
            OneFingerFlickRight,
            OneFingerFlickUp,
            OneFingerFlickDown,
            TwoFingersFlickLeft,
            TwoFingersFlickRight,
            TwoFingersFlickUp,
            TwoFingersFlickDown,
            ThreeFingersFlickLeft,
            ThreeFingersFlickRight,
            ThreeFingersFlickUp,
            ThreeFingersFlickDown,
            OneFingerSingleTap,
            OneFingerDoubleTap,
            OneFingerTripleTap,
            TwoFingersSingleTap,
            TwoFingersDoubleTap,
            TwoFingersTripleTap,
            ThreeFingersSingleTap,
            ThreeFingersDoubleTap,
            ThreeFingersTripleTap,
            OneFingerFlickLeftReturn,
            OneFingerFlickRightReturn,
            OneFingerFlickUpReturn,
            OneFingerFlickDownReturn,
            TwoFingersFlickLeftReturn,
            TwoFingersFlickRightReturn,
            TwoFingersFlickUpReturn,
            TwoFingersFlickDownReturn,
            ThreeFingersFlickLeftReturn,
            ThreeFingersFlickRightReturn,
            ThreeFingersFlickUpReturn,
            ThreeFingersFlickDownReturn,
            OneFingerDoubleTapNHold,
            TwoFingersDoubleTapNHold,
            ThreeFingersDoubleTapNHold,
            MaxCount
        };

        [EditorBrowsable(EditorBrowsableState.Never)]
        public enum RelationType
        {
            NullOf = 0,
            LabelFor,
            LabelledBy,
            ControllerFor,
            ControlledBy,
            MemberOf,
            TooltipFor,
            NodeChildOf,
            NodeParentOf,
            Extended,
            FlowsTo,
            FlowsFrom,
            SubwindowOf,
            Embeds,
            EmbeddedBy,
            PopupFor,
            ParentWindowOf,
            DescriptionFor,
            DescribedBy,
            Details,
            DetailsFor,
            ErrorMessage,
            ErrorFor,
            MaxCount
        };

        [EditorBrowsable(EditorBrowsableState.Never)]
        public enum GestureState
        {
            Begin = 0,
            Ongoing,
            Ended,
            Aborted
        };
    }
}
