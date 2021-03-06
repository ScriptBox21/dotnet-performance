// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Helper functionality to locate inputs and find outputs for
// k-nucleotide benchmark in CoreCLR test harness

using System;
using System.IO;
using System.Text;

namespace BenchmarksGame
{
    class NucleotideHelpers
    {
        public string InputFile;
        public int[] expectedCountLetter;
        public int[] expectedCountPairs;
        public int[] expectedCountFragments;
        public int[][] expectedFrequencies;

        public NucleotideHelpers(bool bigInput)
        {
            if (bigInput)
            {
                InputFile = InputFileHelper.FindInputFile("knucleotide-input-big.txt");
                expectedCountLetter = new int[] { 302923, 301375, 198136, 197566 };
                expectedCountPairs = new int[] { 91779, 91253, 91225, 90837, 60096, 60030, 59889, 59795, 59756, 59713, 59572, 59557, 39203, 39190, 39081, 39023 };
                expectedCountFragments = new int[] { 11765, 3572, 380, 7, 7 };
            }
            else
            {
                InputFile = InputFileHelper.FindInputFile("knucleotide-input.txt");
                expectedCountLetter = new int[] { 1576, 1480, 974, 970 };
                expectedCountPairs = new int[] { 496, 480, 470, 420, 316, 315, 310, 302, 298, 292, 273, 272, 202, 201, 185, 167 };
                expectedCountFragments = new int[] { 54, 24, 4, 0, 0 };
            }
            expectedFrequencies = new int[][] { expectedCountLetter, expectedCountPairs };
        }

        
    }
}
