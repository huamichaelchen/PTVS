﻿// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Microsoft.CookiecutterTools.ViewModel {
    class CategorizedViewModel : INotifyPropertyChanged {
        private string _displayName;

        /// <summary>
        /// Constructor for design view.
        /// </summary>
        public CategorizedViewModel() :
            this(null) {
        }

        public CategorizedViewModel(string displayName) {
            _displayName = displayName;
        }

        public bool Selectable => false;

        public string DisplayName {
            get {
                return _displayName;
            }

            set {
                if (value != _displayName) {
                    _displayName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DisplayName)));
                }
            }
        }

        public ObservableCollection<object> Templates { get; } = new ObservableCollection<object>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
