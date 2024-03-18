using FretBadger.Music.NoteTypes;

namespace FretBadger.Music;

public class Key
{
    public Key(string name, Note[] notes, KeyChord[] chords)
    {
        Name = name;
        Notes = notes;
        Chords = chords;
    }

    public string Name { get; }
    public Note[] Notes { get; }
    public KeyChord[] Chords { get; }
}