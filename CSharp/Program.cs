using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kmpp = true;
            float tolerance = 0.1f;
            float yinyang_t = 0.1f;
            UInt16 features_size = 2;
            UInt32 clusters_size = 3;
            UInt32 samples_size = 300;
            UInt32 seed = 3;
            UInt32 device = 0;
            UInt32 verbosity = 2;
            float[] samples = new float[samples_size * features_size];
            float[] centro = new float[features_size*clusters_size];
            UInt32[] assignments = new uint[samples_size];
            Random rd = new Random();
            for (int i = 0; i < samples_size; i++)
            {
                samples[i] = Convert.ToSingle(rd.NextDouble());
                
            }
            //samples = new[] {1.1f, 1.2f, 2.1f, 2.2f, 3.0f, 3.3f};
            int x = CUDAKM.kmeans_cuda(kmpp, tolerance, yinyang_t, samples_size, features_size, clusters_size, seed,
                device, verbosity, samples,  centro,  assignments);
            Console.ReadLine();
        }
    }
}
