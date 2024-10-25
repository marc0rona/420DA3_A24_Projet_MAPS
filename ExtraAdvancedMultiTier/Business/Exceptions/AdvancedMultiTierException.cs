using ExtraAdvancedMultiTier.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAdvancedMultiTier.Business.Exceptions;
public class AdvancedMultiTierException : AbstractException<string> {

    public AdvancedMultiTierException(string? message = null, string? code = null, Exception? previous = null) : base(message, code, previous) { }
}
