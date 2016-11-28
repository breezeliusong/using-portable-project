using MyTunes.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyTunes.UWP
{
    public class StreamLoader : IStreamLoader
    {

        public  Stream GetStreamForFilename(string filename)
        {
            return Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(filename)
                .AsTask().Result
                .OpenStreamForReadAsync().Result;
        }
    }
}
