using FretBadger.Fretboards;
using FretBadger.Music.NoteTypes;

namespace FretBadger.Client.Models;

public class FretboardViewModel
{
    public FretboardViewModel(Fretboard fretboard, Note[] notes, string id, string title)
    {
        Fretboard = fretboard;
        Notes = notes;
        Id = id;
        Title = title;
    }

    public Fretboard Fretboard { get; }
    public Note[] Notes { get; }
    public string Id { get; }
    public string Title { get; }
    public Fret OpenFret => Fretboard.Frets[0];
}