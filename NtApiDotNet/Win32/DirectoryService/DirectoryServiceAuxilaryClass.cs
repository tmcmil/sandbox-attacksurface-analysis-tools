﻿//  Copyright 2021 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace NtApiDotNet.Win32.DirectoryService
{
    /// <summary>
    /// Class to represent an auxiliary class.
    /// </summary>
    public struct DirectoryServiceAuxiliaryClass
    {
        /// <summary>
        /// The name of the auxilary class.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Whether the auxilary class is a system class.
        /// </summary>
        public bool System { get; }

        internal DirectoryServiceAuxiliaryClass(string name, bool system)
        {
            Name = name;
            System = system;
        }
    }
}
