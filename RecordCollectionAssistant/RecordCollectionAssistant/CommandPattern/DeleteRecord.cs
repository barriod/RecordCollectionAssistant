using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordCollectionAssistant.Data;

namespace RecordCollectionAssistant.CommandPattern
{
    /// <summary>
    /// DeleteRecord command, inherits from Command. Class for handling
    /// deleting records.
    /// </summary>
    public class DeleteRecord : Command
    {

        private int IDToRemove;
        private Record lastRecRemoved;

        /// <summary>
        /// Constructor takes id to remove record by and the list to
        /// remove the record from.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="list"></param>
        public DeleteRecord(int id, RecordList list) : base(list)
        {
            IDToRemove = id;
        }

        /// <summary>
        /// Execute command, takes ID of record to remove and removes
        /// from list.
        /// </summary>
        public override void execute()
        {
            lastRecRemoved = recList.getRecord(IDToRemove);
            recList.removeRecord(IDToRemove);
        }

        /// <summary>
        /// Unexecute command, takes last ID of record removed and
        /// adds it back into the list.
        /// </summary>
        public override void unexecute()
        {
            recList.addRecord(lastRecRemoved);
        }
    }
}
