using FretBadger.Music.NoteTypes;

namespace FretBadger.Music;

public static class KeyRoots
{
    public static readonly Note[] Major =
    {
        Notes.C,
        Notes.DFlat,
        Notes.D,
        Notes.EFlat,
        Notes.E,
        Notes.F,
        Notes.GFlat,
        Notes.G,
        Notes.AFlat,
        Notes.A,
        Notes.BFlat,
        Notes.B,
    };
    
    public static readonly Note[] Minor =
    {
        Notes.C,
        Notes.CSharp,
        Notes.D,
        Notes.EFlat,
        Notes.E,
        Notes.F,
        Notes.FSharp,
        Notes.G,
        Notes.GSharp,
        Notes.A,
        Notes.BFlat,
        Notes.B,
    };
}