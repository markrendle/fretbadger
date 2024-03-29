namespace FretBadger.Music.NoteTypes;

public sealed class F : Note
{
    public static F Instance { get; } = new ();
    private F() { }
    
    public override int Value => 5;
    public override char Letter => 'F';
    public override Sign Sign => Sign.Natural;
    public override string Display => DisplayStrings.F;
    public override Note Alt => Notes.ESharp;

    public override Note AddSemitone() => Notes.FSharp;
    public override Note SubtractSemitone() => Notes.E;

    public override Note AsFlat() => GFlatFlat.Instance;
    public override Note AsSharp() => ESharp.Instance;
}