using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSMSL.Proteomics;

namespace GlyCounter
{
    internal class PSM
    {
        public int spectrumNumber { get; set; }
        public int charge { get; set; }
        public double precursorMZ { get; set; }
        public Peptide peptide { get; set; }
        public Peptide peptideNoGlycanMods { get; set; }
        public int hcdCount { get; set; }
        public int etdCount { get; set; }
        public string totalGlycanComposition { get; set; }
        //this dictionary is set up to be "site, mass"
        public Dictionary<int,double> modificationDictionary { get; set; }  
    }
}
