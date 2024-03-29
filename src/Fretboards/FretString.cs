﻿using FretBadger.Music;
using FretBadger.Music.NoteTypes;

namespace FretBadger.Fretboards;

public class FretString
{
    public FretString(Note note)
    {
        Note = note;
        Badge = note.Sign switch
        {
            Sign.Natural => note.Display,
            Sign.Flat => note.Display,
            Sign.Sharp => note.Alt.Display,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public Note Note { get; }
    public string Badge { get; set; }
    public int? Index { get; set; }
    public bool IsRoot { get; set; }
}