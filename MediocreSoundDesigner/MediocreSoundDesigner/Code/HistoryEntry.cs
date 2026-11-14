
namespace MediocreSoundDesigner;

// Responsible for associating saved states with their respective tracks
public class HistoryEntry
{
    // properties
    public Track OgTrack { get; }
    public TrackSnapshot Snapshot { get; }


    // ctor
    public HistoryEntry(Track track)
    {
        // save which track the entry belongs to
        this.OgTrack = track;

        // capture the current state of the track immediately
        this.Snapshot = new TrackSnapshot(track);
    }
}
