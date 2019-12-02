using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordCollectionAssistant.CommandPattern
{
    /// <summary>
    /// Handles the lists of commands and storing/invoking them
    /// with a redo/undo stack.
    /// </summary>
    public class RecordInvoker
    {
        private Stack<Command> undoStack = new Stack<Command>();
        private Stack<Command> redoStack = new Stack<Command>();

        /// <summary>
        /// Do command does a command. Will call exeucte onh command and 
        /// clears redoStack. Then adds this command to undoStack.
        /// </summary>
        /// <param name="cmd"></param>
        public void doCommand(Command cmd)
        {
            cmd.execute();
            redoStack.Clear();
            undoStack.Push(cmd);
        }

        /// <summary>
        /// Clears stacks, this is done on logout or project close.
        /// </summary>
        public void clearStacks()
        {
            undoStack.Clear();
            redoStack.Clear();
        }

        /// <summary>
        /// Checks if undo stack is empty, used for 
        /// disabling undo button on GUI.
        /// </summary>
        /// <returns></returns>
        public bool checkUndoStack()
        {
            return undoStack.Count > 0;
        }

        /// <summary>
        /// Checks if redo stack is empty, used for 
        /// disabling Redo button on GUI.
        /// </summary>
        /// <returns></returns>
        public bool checkRedoStack()
        {
            return redoStack.Count > 0;
        }

        /// <summary>
        /// Undoes a command by removing the last executed command from the
        /// undo stack and calling the unexecute method from the command.
        /// Then adds this command to the Redo stack.
        /// </summary>
        public void undo()
        {
            if (undoStack.Count != 0)
            {
                Command undoneCmd = undoStack.Pop();
                undoneCmd.unexecute();
                redoStack.Push(undoneCmd);
            }
        }

        /// <summary>
        /// Redoes a command by popping a command from the redo stack and 
        /// then executing that command. Then adds this command to the top of the
        /// undo stack.
        /// </summary>
        public void redo()
        {
            if (redoStack.Count != 0)
            {
                Command todoCmd = redoStack.Pop();
                todoCmd.execute();
                undoStack.Push(todoCmd);
            }
        }

    }
}
