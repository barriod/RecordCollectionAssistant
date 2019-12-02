using RecordCollectionAssistant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordCollectionAssistant.CommandPattern
{
    /// <summary>
    /// AddRecord command, inherits from Command. Class for handling
    /// adding records.
    /// </summary>
    public class AddRecord : Command
    {
        private Record recordAdded;

        /// <summary>
        /// Add Record command puts command on stack and adds record to list.
        /// Saves record in "recordAdded" in case of unexecute undo command.
        /// </summary>
        /// <param name="newRec"></param>
        /// <param name="list"></param>
        public AddRecord(Record newRec, RecordList list) : base(list)
        {
            recordAdded = newRec;
        }

        /// <summary>
        /// Executes command for AddRecord by adding record to list
        /// and saving added record as recordAdded.
        /// </summary>
        public override void execute()
        {
            recList.addRecord(recordAdded);
        }

        /// <summary>
        /// Unexecutes command for AddRecord by removing recently added
        /// record to list. Uses the recordAdded object to find last added
        /// record.
        /// </summary>
        public override void unexecute()
        {
            recList.removeRecord(recordAdded.getInfo().ID);
        }
    }
}
