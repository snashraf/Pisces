﻿using System.Collections.Generic;
using Pisces.Domain.Models;
using Pisces.Domain.Models.Alleles;

namespace Pisces.Domain.Interfaces
{
    public interface ICandidateVariantFinder
    {
        IEnumerable<CandidateAllele> FindCandidates(AlignmentSet alignmentSet, string genome, string chromosomeName);
    }
}