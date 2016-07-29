using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CSharp
{
    class CUDAKM
    {
        [DllImport("CUDAKMeans.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public static extern int kmeans_cuda(bool kmpp, float tolerance, float yinyang_t, UInt32 samples_size,
            UInt16 features_size, UInt32 clusters_size, UInt32 seed,
            UInt32 device, UInt32 verbosity, float[] samples,
             float[] centroids,  UInt32[] assignments);
    }
}
