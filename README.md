# Glycounter
## Pre-ID
Accepts one or more .raw or .mzML file(s) and extracts information about the oxonium ions in your spectra. A csv file with additional ions to be considered (with headers "Mass" and "Description") can be uploaded as well.
Scan settings are customizable per dissociation method (for example: usually ETD will have less intense/fewer oxonium ions than other dissociation methods so the defaults are lower).
### Variables
**ppm Tolerance**: tolerance for determining if the oxonium ion is present

**Signal-to-Noise Requirement**: S/N ratio needed for oxonium ions

**Intensity Threshold**: If S/N is not available in the file, an intensity threshold is used instead. This will always be the case for ion trap .raw files and all .mzML files.

**Scan Settings - Peak Depth (Must be within N most intense peaks)**: number of peaks which are checked for the Oxonium Count Requirement

**Scan Settings - TIC Fraction**: fraction of total TIC which needs to be oxonium ions for LikelyGlycoSpectrum

**Scan Settings - Oxonium Count Requirement**: Number of oxonium ions that need to be in the peak depth for LikelyGlycoSpectrum. When this is set to 0 the default amount is used. The default depends on the number of oxonium ions checked. For HCD and UVPD the defaults are: 

| Number of Oxonium Ions Checked | Default Oxonium Count Requirement| 
|:------------------------------:|:--------------------------------:|
| less than 6                    | 4                                |
| between 6 and 15               | half of number of checked ions   |
| greater than 15                | 8                                |

These defaults are halved for ETD spectra. The Check Common Ions button checks 17 ions, so if used with the default setting the count requirement would be 8 for HCD/UVPD and 4 for ETD.

### LikelyGlycoSpectrum
A spectrum is considered likely to be a glycopeptide if it meets the requirements set by the user before the run. This is based on the Oxonium Count Requirement (minimum amount of oxonium ions needed to be observed in the N most intense peaks set by the Peak Depth option) and the chosen TIC fraction (minimum percentage of TIC that needs to be oxonium ions).
If the HexNAc (204.0867 m/z) oxonium ion is selected, it must show up in the set peak depth for a spectrum to be considered LikelyGlyco.
If the settings are not changed by the user or an unrecognizable input is entered, the default values will be used.

## Ynaught
Calculates and extracts Y-ions and/or glycan neutral losses from database searched data. Accepts a formatted .txt PSMs file with the headers "Spectrum Number", "Charge State", "Peptide Sequence", and "Modifications"; a glycan masses .txt with headers "Glycan" and "Mass"; and a .raw file. Ynaught currently does not support .mzML files. 
Additional csv files can be uploaded with custom Y-ions or neutral losses (Headers "Mass" and "Description").

### Variables
**ppm tolerance**: tolerance for determining if the ion is present

**Signal-to-Noise Requirement**: S/N ratio needed for ions

**Isotope Options**: Choose if you want to look for C13 isotopes

**Charge State Options**: Larger glycopeptide fragments have the potential to be at any charge state between +1 and the precursor charge state. The charge state limits are determined based on z-X and z-Y where z is the precursor charge, z-X is the highest considered charge state, and z-Y is the lowest considered charge state.
For example: if the precursor charge is 4 and I want to consider anything with a charge +2 to +4, I would enter 0 for X and 2 for Y. If I only wanted to consider the precursor charge then X and Y should be 0.
