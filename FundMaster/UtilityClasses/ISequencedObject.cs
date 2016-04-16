using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundMaster
{
    /// <summary>
    /// An object that can be given a sequential order in a collection.
    /// </summary>
    public interface ISequencedObject
    {
        /// <summary>
        /// The sequence number of the object
        /// </summary>
        int SequenceNumber { get; set; }

    }
}
