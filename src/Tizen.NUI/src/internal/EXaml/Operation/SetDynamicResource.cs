﻿/*
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
using System.Reflection;
using System.Text;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using Tizen.NUI.Binding.Internals;

namespace Tizen.NUI.EXaml
{
    internal class SetDynamicResource : Operation
    {
        public SetDynamicResource(int instanceIndex, int propertyIndex, string key)
        {
            this.instanceIndex = instanceIndex;
            this.propertyIndex = propertyIndex;
            this.key = key;
        }

        public void Do()
        {
            var instance = LoadEXaml.GatheredInstances[instanceIndex] as BindableObject;
            var property = GatherBindableProperties.GatheredBindableProperties[propertyIndex];

            instance.SetDynamicResource(property, key);
        }

        private int instanceIndex;
        private int propertyIndex;
        private string key;
    }
}