using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace My.Mudle.RNMyMudle
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMyMudleModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMyMudleModule"/>.
        /// </summary>
        internal RNMyMudleModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMyMudle";
            }
        }
    }
}
