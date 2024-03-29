namespace FretBadger.Music.NoteTypes;

public sealed class BFlat : Note
{
    public static BFlat Instance { get; } = new ();
    private BFlat() { }
    
    public override int Value => 10;
    public override char Letter => 'B';
    public override Sign Sign => Sign.Flat;
    public override string Display => DisplayStrings.BFlat;
    public override Note Alt => Notes.ASharp;

    public override Note AddSemitone() => Notes.B;
    public override Note SubtractSemitone() => Notes.A;
}