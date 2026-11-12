
namespace MediocreSoundDesigner;

// Manages the editing history of the software
// Manages the order that saved states are stored and retrieved
public class HistoryManager
{
    // stores the track states in the order in which they were saved
    // most recently saved state will be on the top, i.e. it will be retrieved first
    private readonly Stack<HistoryEntry> undoStack = new();

    // makes sure the history is not empty so the user can undo a change
    public bool CanUndo => undoStack.Count > 0;


    /// <summary>
    /// Saves the current state of the supplied track and adds it to the history.
    /// </summary>
    /// <param name="track">The track thats state is being saved.</param>
    public void SaveState(Track track)
    {
        undoStack.Push(new HistoryEntry(track));
    }


    // 
    public void RemoveTrackHistory(Track track)
    {
        Stack<HistoryEntry> tempStack = new();
        //foreach (HistoryEntry entry in undoStack)  --  could maybe work, unsure
        //for (int i = 0; i < undoStack.Count; i++)  --  actually this probably wont work

        // remove each entry from the history and identify
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

        /*
         * Idea: could also try using stack method "Contains(X)", with x being 
         * any entry that has an OgTrack = to track. That is, assuming that is
         * how that method works
         */

        // rebuild undoStack after all history for deleted track is removed
        while (tempStack.Count > 0)
        {
            undoStack.Push(tempStack.Pop());
        }
    }
}
