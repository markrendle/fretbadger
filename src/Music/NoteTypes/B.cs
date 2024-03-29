namespace FretBadger.Music.NoteTypes;

public sealed class B : Note
{
    public static B Instance { get; } = new ();
    private B() { }
    
    public override int Value => 11;
    public override char Letter => 'B';
    public override Sign Sign => Sign.Natural;
    public override string Display => DisplayStrings.B;
    public override Note Alt => Notes.CFlat;

    public override Note AddSemitone() => Notes.C;
    public override Note SubtractSemitone() => Notes.BFlat;

    public override Note AsSharp() => ASharpSharp.Instance;
    public override Note AsFlat() => CFlat.Instance;
}
