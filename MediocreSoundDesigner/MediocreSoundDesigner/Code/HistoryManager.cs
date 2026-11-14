
namespace MediocreSoundDesigner;

// Manages the editing history of the software
// Manages the order that saved states are stored and retrieved
public class HistoryManager
{
    // stores the track states in the order in which they were saved
    // most recently saved state will be on the top, i.e. it will be retrieved first
    private readonly Stack<HistoryEntry> undoStack = new();
    private readonly Stack<HistoryEntry> redoStack = new();

    // makes sure the history is not empty so the user can undo or redo a change
    public bool CanUndo => undoStack.Count > 0;
    public bool CanRedo => redoStack.Count > 0;

    /// <summary>
    /// Saves the current state of the supplied track and adds it to the history.
    /// </summary>
    /// <param name="track">The track thats state is being saved.</param>
    public void SaveState(Track track)
    {
        redoStack.Clear();
        undoStack.Push(new HistoryEntry(track));
    }

    /// <summary>
    /// Removes all past state instances of the track
    /// being deleted from the edit history.
    /// </summary>
    /// <param name="track">The track being deleted.</param>
    public void RemoveTrackHistory(Track track)
    {
        // for undoStack
        Stack<HistoryEntry> tempStack = new();

        // remove each entry from the undo history and identify
        // those which apply to the deleted track
        while (undoStack.Count > 0)
        {
            HistoryEntry entry = undoStack.Pop();

            // make sure they are the same track
            // if false, then add to tempStack
            if (!ReferenceEquals(entry.OgTrack, track))
            {
                tempStack.Push(entry);
            }
        }

        // rebuild undoStack after all history for deleted track is removed
        while (tempStack.Count > 0)
        {
            undoStack.Push(tempStack.Pop());
        }


        // for redoStack
        if (redoStack.Count > 0)
        {
            while (redoStack.Count > 0)
            {
                HistoryEntry entry = redoStack.Pop();

                if (!ReferenceEquals(entry.OgTrack, track))
                {
                    tempStack.Push(entry);
                }
            }

            while (tempStack.Count > 0)
            {
                redoStack.Push(tempStack.Pop());
            }
        }
    }

    /// <summary>
    /// Retrieves and removes the most recently saved track state in the undo stack.
    /// Undoes the most recent change.
    /// </summary>
    /// <returns></returns>
    public HistoryEntry Undo()
    {
        // undoStack is empty, nothing to undo
        if (!CanUndo) return null;

        // remove and return the save state
        redoStack.Push(new HistoryEntry(undoStack.Peek().OgTrack));
        return undoStack.Pop();
    }

    /// <summary>
    /// Retrieves and removes the most recently saved track state in the redo stack.
    /// Redoes the most recently undone change.
    /// </summary>
    /// <returns></returns>
    public HistoryEntry Redo()
    {
        if (!CanRedo) return null;

        undoStack.Push(new HistoryEntry(redoStack.Peek().OgTrack));
        return redoStack.Pop();
    }
}
