﻿// Copyright 2012, 2013, 2014 Derek J. Bailey
// 
// This file (PeptideSpectralMatchScoreType.cs) is part of CSMSL.
// 
// CSMSL is free software: you can redistribute it and/or modify it
// under the terms of the GNU Lesser General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CSMSL is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
// FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public
// License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with CSMSL. If not, see <http://www.gnu.org/licenses/>.

namespace CSMSL.Analysis.Identification
{
    public enum PeptideSpectralMatchScoreType
    {
        OmssaEvalue = 3,
        EValue = 1,
        LowerIsBetter = 2,
        HigherIsBetter = -3,
        XCorr = -1,
        Morpheus = -2,
        MSAmanda = -4
    }
}