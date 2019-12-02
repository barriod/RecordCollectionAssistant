using RecordCollectionAssistant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordCollectionAssistant.CommandPattern
{
    /// <summary>
    /// Parent class for Commands. Used in Command Pattern
    /// to imlement undo/redo functionality.
    /// </summary>
    public abstract class Command
    {
        protected RecordInvoker recInv;
        protected RecordList recList;

        /// <summary>
        /// Constructor, needs record list adding/deleting records
        /// is adding/removing records from.
        /// </summary>
        /// <param name="newList"></param>
        public Command(RecordList newList)
        {
            recList = newList;
        }

        /// <summary>
        /// Gets the list to update the RecordList after an
        /// add or delete command is executed/unexecuted.
        /// </summary>
        /// <returns></returns>
        public RecordList getList()
        {
            return recList;
        }

        /// <summary>
        /// Abastract method execute
        /// </summary>
        public abstract void execute();

        /// <summary>
        /// Abstract method unexecute
        /// </summary>
        public abstract void unexecute();
    }
}
