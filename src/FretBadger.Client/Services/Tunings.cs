using FretBadger.Music;
using FretBadger.Music.NoteTypes;

namespace FretBadger.Client.Services;

public static class Tunings
{
    public static Note[] Parse(string tuning)
    {
        var list = new List<Note>();
        var notes = tuning.AsSpan();
        for (int i = 0; i < notes.Length; i++)
        {
            var n = notes[i];
            if (!char.IsUpper(n) || n is < 'A' or > 'G') throw new MusicException("Invalid note specified");
            var sign = Sign.Natural;
            if (i + 1 < notes.Length)
            {
                var s = notes[i + 1];
                if (s == 'f')
                {
                    sign = Sign.Flat;
                    i++;
                }
                else if (s == 's')
                {
                    sign = Sign.Sharp;
                    i++;
                }
            }

            list.Add(Music.Notes.Get(n, sign));
        }

        var openNoteArray = list.ToArray();
        return openNoteArray;
    }
}