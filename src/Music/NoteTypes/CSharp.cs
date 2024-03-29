namespace FretBadger.Music.NoteTypes;

public sealed class CSharp : Note
{
    public static CSharp Instance { get; } = new ();
    private CSharp() { }
    
    public override int Value => 1;
    public override char Letter => 'C';
    public override Sign Sign => Sign.Sharp;
    public override string Display => DisplayStrings.CSharp;
    public override Note Alt => Notes.DFlat;

    public override Note AddSemitone() => Notes.D;
    public override Note SubtractSemitone() => Notes.C;
}