# Transcriptomics
Source code for RNA MS analysis.

### Files
#### Program.cs and Program(InternalFragments).cs
Change these variable values:
- outputPath
- rawfilePath
- oligonucleotide: G, U, A, C sequence without modifications
- SteamReader parameter: for Program(InternalFragments).cs only (line 30), to specify the location of the text file

Notes:
- Comment out the modification section (line 33-40) when running the script for 21nt RNA
- To run Program(InternalFragments).cs, rename Program.cs to Program(fragments).cs, and Program(InternalFragments).cs to Program.cs

#### InternalFragMZ_21nt.txt
- Text file contains calculated m/z of all possible internal fragments of the 21nt RNA. 
- The first row contains the charge state.
- The first column contains the monoisotopic mass of an internal fragment and the second column contains the position of the internal fragment.
- The m/z values start on column three.
