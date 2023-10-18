using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace The.Surfing.Funny.Story.RNTheSurfingFunnyStory
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTheSurfingFunnyStoryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTheSurfingFunnyStoryModule"/>.
        /// </summary>
        internal RNTheSurfingFunnyStoryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTheSurfingFunnyStory";
            }
        }
    }
}
